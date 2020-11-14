﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PluralVideos.Download.Services.Video
{
    public class Course
    {
        [JsonProperty(PropertyName = "header")]
        public Header Header { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "modules")]
        public virtual ICollection<Module> Modules { get; set; }
    }
}
