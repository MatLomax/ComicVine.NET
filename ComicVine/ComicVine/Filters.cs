namespace ComicVine
{
    public class Filters
    {
        public string FieldList { get; set; }
        public int Limit { get; set; } = 10;
        public int Offset { get; set; } = 0;
        public string Sort { get; set; }
        public string Filter { get; set; }
    }
}