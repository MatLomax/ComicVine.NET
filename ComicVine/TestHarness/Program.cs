using System;
using ComicVine.Models;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new ComicVine.Api { ApiKey = "75557359ec059cafd5ffe96731c96f6a86f8588d" };

            // Search characters
            //var characterList = api.GetCharacterList(new ComicVine.Filters
            //{
            //    Filter = "name:Buzz",
            //    FieldList = "name",
            //    Limit = 3
            //});

            //var character = api.FetchSingle<Character>("character", 1253, null, new[] { "FirstAppearedInIssue" });
            //var volumes = api.GetVolumeList(new ComicVine.Filters { FieldList = "name,count_of_issues,publisher", Filter = "name:Quiver"});
            //var power = api.GetPower(51);
            //var storyArc = api.GetStoryArc(5);

            //var volume = api.GetVolume(769);

            //var query = "Eye of the World";

            //var volume = api.GetVolumeList(new Filters {Filter = $"name:{query}", FieldList = "name,count_of_issues,publisher,start_year"});

            //var people = api.GetPersonList(new Filters { Filter = "name:Jack", FieldList = "id,name", Limit = 20 });

            //var fullPeople = people.Select(p => api.GetPerson(p.Id)).ToList();

            //var searchObjects = api.GetObjectList(new Filters {Filter = "name:Infinity Gauntlet"});

            //var power = api.Get<Power>("power", 51, new Filters(), "a");

            //var storyArcs = api.Get<StoryArc>(new Filters
            //{
            //    Filter = "name:Civil War",
            //    FieldList = "id,name",
            //    Limit = 15
            //});

            var storyArc = api.Get<StoryArc>(58879);


            //var civilWar = api.Get<StoryArc>("Civil War II", null, new [] { "Publisher" });


            //var marvel = api.Get<Publisher>("Dark Horse", new Filters { FieldList = "id,characters" });


            Console.ReadLine();
        }
    }
}
