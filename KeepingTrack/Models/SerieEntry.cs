using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepingTrack.Models
{
    public class SerieEntry
    {
        public string title { get; set; }
        public string type { get; set; }
        public string image { get; set; }
        public int progressSeason { get; set; }
        public int progressEpisode { get; set; }
    }
}