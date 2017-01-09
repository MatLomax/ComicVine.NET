using System;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new ComicVine.Api { ApiKey = "75557359ec059cafd5ffe96731c96f6a86f8588d" };

            //var character = api.GetCharacter(1253, new ComicVine.ApiFilters { FieldList = "name" });
            //var volumes = api.GetVolumeList(new ComicVine.ApiFilters { FieldList = "name,count_of_issues,publisher", Filter = "name:Quiver"});
            //var power = api.GetPower(51);
            //var storyArc = api.GetStoryArc(5);

            var volume = api.GetVolume(769);

            Console.ReadLine();
        }
    }
}
