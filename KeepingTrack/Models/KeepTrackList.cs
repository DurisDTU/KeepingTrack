using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepingTrack.Models
{
    public class KeepTrackList
    {
        public List<MovieEntry> movielist { get; set; } = new List<MovieEntry>();
        public List<SerieEntry> serielist { get; set; } = new List<SerieEntry>();
        public MovieEntry movieEntry { get; set; }
        public SerieEntry serieEntry { get; set; }


    }
}