using System.Collections.Generic;
using ComicVine.Models;
using RestSharp;

namespace ComicVine
{
    partial class Api
    {
        public IEnumerable<Volume> SearchVolumes(string query)
        {
            var request = new RestRequest("search") { Method = Method.GET };

            request.AddParameter("query", query);
            request.AddParameter("resources", "volume");
            request.AddParameter("field_list", string.Join(",", "id", "name", "start_year", "count_of_issues", "publisher"));

            request.AddParameter("format", "json");
            request.AddParameter("api_key", this.ApiKey);

            var response = this.Client.Execute<Result<List<Volume>>>(request);

            return response.Data.Results;
        }

        public Character GetCharacter(int id, ApiFilters filters = null)
        {
            return this.Get<Character>("character", id, filters);
        }

        public List<Character> GetCharacterList(ApiFilters filters = null)
        {
            return this.Get<List<Character>>("characters", filters);
        }
     
        public Concept GetConcept(int id, ApiFilters filters = null)
        {
            return this.Get<Concept>("concept", id, filters);
        }

        public List<Concept> GetConceptList(ApiFilters filters = null)
        {
            return this.Get<List<Concept>>("concepts", filters);
        }

        public Episode GetEpisode(int id, ApiFilters filters = null)
        {
            return this.Get<Episode>("episode", id, filters);
        }

        public List<Episode> GetEpisodeList(ApiFilters filters = null)
        {
            return this.Get<List<Episode>>("episodes", filters);
        }

        public Issue GetIssue(int id, ApiFilters filters = null)
        {
            return this.Get<Issue>("issue", id, filters);
        }

        public List<Issue> GetIssueList(ApiFilters filters = null)
        {
            return this.Get<List<Issue>>("issues", filters);
        }

        public Location GetLocation(int id, ApiFilters filters = null)
        {
            return this.Get<Location>("location", id, filters);
        }

        public List<Location> GetLocationList(ApiFilters filters = null)
        {
            return this.Get<List<Location>>("locations", filters);
        }

        public Movie GetMovie(int id, ApiFilters filters = null)
        {
            return this.Get<Movie>("movie", id, filters);
        }

        public List<Movie> GetMovieList(ApiFilters filters = null)
        {
            return this.Get<List<Movie>>("movies", filters);
        }

        public Object GetObject(int id, ApiFilters filters = null)
        {
            return this.Get<Object>("object", id, filters);
        }

        public List<Object> GetObjectList(ApiFilters filters = null)
        {
            return this.Get<List<Object>>("objects", filters);
        }

        public Origin GetOrigin(int id, ApiFilters filters = null)
        {
            return this.Get<Origin>("origin", id, filters);
        }

        public List<Origin> GetOriginList(ApiFilters filters = null)
        {
            return this.Get<List<Origin>>("origins", filters);
        }

        public Person GetPerson(int id, ApiFilters filters = null)
        {
            return this.Get<Person>("person", id, filters);
        }

        public List<Person> GetPersonList(ApiFilters filters = null)
        {
            return this.Get<List<Person>>("people", filters);
        }

        public Power GetPower(int id, ApiFilters filters = null)
        {
            return this.Get<Power>("power", id, filters);
        }

        public List<Power> GetPowerList(ApiFilters filters = null)
        {
            return this.Get<List<Power>>("powers", filters);
        }

        public Promo GetPromo(int id, ApiFilters filters = null)
        {
            return this.Get<Promo>("promo", id, filters);
        }

        public List<Promo> GetPromoList(ApiFilters filters = null)
        {
            return this.Get<List<Promo>>("promos", filters);
        }

        public Publisher GetPublisher(int id, ApiFilters filters = null)
        {
            return this.Get<Publisher>("publisher", id, filters);
        }

        public List<Publisher> GetPublisherList(ApiFilters filters = null)
        {
            return this.Get<List<Publisher>>("publishers", filters);
        }

        public Series GetSeries(int id, ApiFilters filters = null)
        {
            return this.Get<Series>("series", id, filters);
        }

        public List<Series> GetSeriesList(ApiFilters filters = null)
        {
            return this.Get<List<Series>>("series_list", filters);
        }

        public StoryArc GetStoryArc(int id, ApiFilters filters = null)
        {
            return this.Get<StoryArc>("story_arc", id, filters);
        }

        public List<StoryArc> GetStoryArcList(ApiFilters filters = null)
        {
            return this.Get<List<StoryArc>>("story_arcs", filters);
        }

        public Team GetTeam(int id, ApiFilters filters = null)
        {
            return this.Get<Team>("team", id, filters);
        }

        public List<Team> GetTeamList(ApiFilters filters = null)
        {
            return this.Get<List<Team>>("teams", filters);
        }

        public List<Type> GetTypeList(ApiFilters filters = null)
        {
            return this.Get<List<Type>>("types", filters);
        }

        public Video GetVideo(int id, ApiFilters filters = null)
        {
            return this.Get<Video>("video", id, filters);
        }

        public List<Video> GetVideoList(ApiFilters filters = null)
        {
            return this.Get<List<Video>>("videos", filters);
        }

        public VideoCategory GetVideoCategory(int id, ApiFilters filters = null)
        {
            return this.Get<VideoCategory>("video_category", id, filters);
        }

        public List<VideoCategory> GetVideoCategoryList(ApiFilters filters = null)
        {
            return this.Get<List<VideoCategory>>("video_categories", filters);
        }

        public VideoType GetVideoType(int id, ApiFilters filters = null)
        {
            return this.Get<VideoType>("video_type", id, filters);
        }

        public List<VideoType> GetVideoTypeList(ApiFilters filters = null)
        {
            return this.Get<List<VideoType>>("video_types", filters);
        }

        public Volume GetVolume(int id, ApiFilters filters = null)
        {
            return this.Get<Volume>("volume", id, filters);
        }

        public List<Volume> GetVolumeList(ApiFilters filters = null)
        {
            return this.Get<List<Volume>>("volumes", filters);
        }
    }
}
