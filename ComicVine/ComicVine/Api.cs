using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Cache;
using ComicVine.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;

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
        
        protected IRestRequest CreateRequest(string uri, ApiFilters filters)
        {
            var request = new RestRequest(uri) { Method = Method.GET };

            request.AddParameter("format", "json");
            request.AddParameter("api_key", this.ApiKey);

            return filters != null ? ApplyFilters(request, filters) : request;
        }

        protected static IRestRequest ApplyFilters(IRestRequest request, ApiFilters filters)
        {
            if (!string.IsNullOrWhiteSpace(filters.FieldList)) request.AddParameter("field_list", filters.FieldList);
            if (filters.Limit != 10) request.AddParameter("limit", filters.Limit);
            if (filters.Offset > 0) request.AddParameter("offset", filters.Offset);
            if (!string.IsNullOrWhiteSpace(filters.Sort)) request.AddParameter("sort", filters.Sort);
            if (!string.IsNullOrWhiteSpace(filters.Filter)) request.AddParameter("filter", filters.Filter);

            return request;
        }

        public T Get<T>(string endpoint, ApiFilters filters)
        {
            var request = this.CreateRequest(endpoint, filters);

            return this.GetResponse<T>(request);
        }

        public T Get<T>(string endpoint, int id, ApiFilters filters)
        {
            var idString = this.EndpointIds[endpoint] != "" ? $"{this.EndpointIds[endpoint]}-{{id}}" : id.ToString();
            var request = this.CreateRequest($"{endpoint}/{idString}", filters);
            request.AddUrlSegment("id", id.ToString());

            return this.GetResponse<T>(request);
        }

        protected T GetResponse<T>(IRestRequest request)
        {
            var response = this.Client.Execute(request);

            var simpleResult = JsonConvert.DeserializeObject<SimpleResult>(response.Content);

            if (simpleResult.Error != "OK") return default(T);

            var result = JsonConvert.DeserializeObject<Result<T>>(response.Content);

            return result.Results;

            //var response = this.Client.Execute<Result<T>>(request);
            //return response.Data.Results;
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

    public class ApiFilters
    {
        public string FieldList { get; set; }
        public int Limit { get; set; } = 10;
        public int Offset { get; set; } = 0;
        public string Sort { get; set; }
        public string Filter { get; set; }
    }
}
