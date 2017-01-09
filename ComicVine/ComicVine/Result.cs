namespace ComicVine
{
    public class SimpleResult
    {
        public string Error { get; set; }
    }

    public class Result<T>
    {
        public string Error { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int NumberOfPageResults { get; set; }
        public int NumberOfTotalResults { get; set; }
        public int StatusCode { get; set; }
        public string Version { get; set; }
        public T Results { get; set; }
    }
}