﻿using System;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Video : NamedEntity
    {
        public new static string SingleEndpoint => "video";
        public new static string ListEndpoint => "videos";
        public new static string EndpointId => "2300";

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("high_url")]
        public string HighUrl { get; set; }

        [JsonProperty("low_url")]
        public string LowUrl { get; set; }

        [JsonProperty("embed_player")]
        public string EmbedPlayer { get; set; }
        
        [JsonProperty("length_seconds")]
        public int LengthSeconds { get; set; }
        
        [JsonProperty("publish_date")]
        public DateTime? PublishDate { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("video_type")]
        public string VideoType { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }
    }
}