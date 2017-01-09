using System;

namespace ComicVine
{
    [Flags]
    public enum ResourceType
    {
        Character = 1,
        Concept = 2,
        Origin = 4,
        Object = 8,
        Location = 16,
        Issue = 32,
        StoryArc = 64,
        Volume = 128,
        Publisher = 256,
        Person = 512,
        Team = 1024,
        Video = 2048
    }
}