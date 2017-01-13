using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ComicVine.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ComicVine
{
    public partial class Api
    {
        protected RestClient Client { get; } = new RestClient();
        protected static string ApiAddress => "http://comicvine.gamespot.com/api";
        public string ApiKey { get; set; }

        public Api()
        {
            this.Client.FollowRedirects = true;
            this.Client.BaseUrl = new Uri(ApiAddress);
        }

        protected IRestRequest CreateRequest(string uri, Filters filters)
        {
            var request = new RestRequest(uri) { Method = Method.GET };

            request.AddParameter("format", "json");
            request.AddParameter("api_key", this.ApiKey);

            return filters != null ? ApplyFilters(request, filters) : request;
        }

        protected T GetResponse<T>(IRestRequest request)
        {
            var response = this.Client.Execute(request);

            var json = JObject.Parse(response.Content);

            if (json["error"].Value<string>() != "OK") return default(T);

            // Fix for occasional death date appearing as time object with timezone d
            try
            {
                var deathDateObject = json["results"]?["death"]?.ToObject<DateObject>();
                if (deathDateObject?.Date != null)
                {
                    json["results"]["death"] = deathDateObject.Date;
                }
            }
            catch (Exception)
            {
                // Ignored
            }


            var result = JsonConvert.DeserializeObject<Result<T>>(json.ToString());

            return result.Results;
        }

        protected List<T> FetchList<T>(string endpoint, Filters filters)
        {
            var request = this.CreateRequest(endpoint, filters);

            return this.GetResponse<List<T>>(request);
        }

        protected T FetchSingle<T>(string endpoint, int id, Filters filters)
        {
            var idString = this.EndpointIds[endpoint] != "" ? $"{this.EndpointIds[endpoint]}-{{id}}" : id.ToString();
            var request = this.CreateRequest($"{endpoint}/{idString}", filters);
            request.AddUrlSegment("id", id.ToString());

            return this.GetResponse<T>(request);
        }

        protected T FetchSingle<T>(string endpoint, int id, Filters filters, IEnumerable<string> inflateWith) where T : Entity
        {
            var entity = this.FetchSingle<T>(endpoint, id, filters);

            if (inflateWith == null) return entity;

            var singles = entity.GetType().GetProperties().Where(p => inflateWith.Contains(p.Name) && PropertyIsEntity(p)).ToList();
            singles.ForEach(s =>
            {
                var type = this.GetType();
                var method = type.GetMethod("GetEntity");
                var genMethod = method.MakeGenericMethod(s.PropertyType);
                var p = genMethod.Invoke(this, new[] { s.GetValue(entity), filters });
                s.SetValue(entity, p);
            });

            //var singlesUpdated = singles.Select(s => this.Get((Entity)s.GetValue(entity), int.Parse(entity.Id), null).ChangeType(s.PropertyType)).ToList();


            //var c = entity.GetType().GetProperties().Where(p => p.PropertyType.Name == "List`1" && p.PropertyType.GenericTypeArguments.First()?.BaseType?.FullName == typeof(Entity).FullName).ToList();
            //var d = c.Where(l => l.PropertyType.GenericTypeArguments.First().Name == "Power").Select(l => l.GetValue(entity)).ToList();

            return entity;
        }

        public T GetEntity<T>(T entity, Filters filters) where T : Entity
        {
            var endpoint = entity.GetType().GetProperty("SingleEndpoint").GetValue(entity).ToString();
            return this.FetchSingle<T>(endpoint, int.Parse(entity.Id), filters);
        }


        public T Get<T>(string name, Filters filters = null, IEnumerable<string> inflateWith = null) where T : NamedEntity
        {
            var entities = this.Get<T>(new Filters
            {
                Filter = $"name:{name}",
                FieldList = "id,name"
            }).ToList();

            var entity = entities.FirstOrDefault(e => e.Name == name) ?? entities.First();
            return this.Get<T>(int.Parse(entity.Id), filters, inflateWith);

        }

        public T Get<T>(int id, Filters filters = null, IEnumerable<string> inflateWith = null) where T : Entity
        {
            var endpoint = typeof(T).GetProperty("SingleEndpoint").GetValue(null).ToString();
            return this.FetchSingle<T>(endpoint, id, filters, inflateWith);
        }

        public IEnumerable<T> Get<T>(Filters filters = null) where T : Entity
        {
            var endpoint = typeof(T).GetProperty("ListEndpoint").GetValue(null).ToString();
            return this.FetchList<T>(endpoint, filters);
        }


        protected static bool PropertyIsEntity(PropertyInfo prop)
        {
            var type = prop.PropertyType.BaseType;

            while (type?.BaseType != null)
            {
                type = type.BaseType;

                if (type == typeof (Entity)) return true;
            }

            return false;
        }
        

        protected static IRestRequest ApplyFilters(IRestRequest request, Filters filters)
        {
            if (!string.IsNullOrWhiteSpace(filters.FieldList)) request.AddParameter("field_list", filters.FieldList);
            if (filters.Limit != 10) request.AddParameter("limit", filters.Limit);
            if (filters.Offset > 0) request.AddParameter("offset", filters.Offset);
            if (!string.IsNullOrWhiteSpace(filters.Sort)) request.AddParameter("sort", filters.Sort);
            if (!string.IsNullOrWhiteSpace(filters.Filter)) request.AddParameter("filter", filters.Filter);

            return request;
        }

        protected static IRestRequest ApplyResources(IRestRequest request, ResourceType resourceType)
        {
            var resources = new List<string>();

            if ((resourceType & ResourceType.Character) == ResourceType.Character) resources.Add("character");
            if ((resourceType & ResourceType.Concept) == ResourceType.Concept) resources.Add("concept");
            if ((resourceType & ResourceType.Origin) == ResourceType.Origin) resources.Add("origin");
            if ((resourceType & ResourceType.Object) == ResourceType.Object) resources.Add("object");
            if ((resourceType & ResourceType.Location) == ResourceType.Location) resources.Add("location");
            if ((resourceType & ResourceType.Issue) == ResourceType.Issue) resources.Add("issue");
            if ((resourceType & ResourceType.StoryArc) == ResourceType.StoryArc) resources.Add("story_arc");
            if ((resourceType & ResourceType.Volume) == ResourceType.Volume) resources.Add("volume");
            if ((resourceType & ResourceType.Publisher) == ResourceType.Publisher) resources.Add("publisher");
            if ((resourceType & ResourceType.Person) == ResourceType.Person) resources.Add("person");
            if ((resourceType & ResourceType.Team) == ResourceType.Team) resources.Add("team");
            if ((resourceType & ResourceType.Video) == ResourceType.Video) resources.Add("video");

            if (resources.Count == 0) return request;

            request.AddParameter("resources", string.Join(",", resources));

            return request;
        }

        protected readonly Dictionary<string, string> EndpointIds = new Dictionary<string, string>
        {
            {"video_type", ""},
            {"video_category", ""},
            {"promo", "1700"},
            {"video", "2300"},
            {"issue", "4000"},
            {"character", "4005"},
            {"publisher", "4010"},
            {"concept", "4015"},
            {"location", "4020"},
            {"movie", "4025"},
            {"origin", "4030"},
            {"power", "4035"},
            {"person", "4040"},
            {"story_arc", "4045"},
            {"volume", "4050"},
            {"object", "4055"},
            {"episode", "4070"},
            {"series", "4075"}
        };
    }
}
