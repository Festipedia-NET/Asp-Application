using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class BandsPerFestival
    {
        public int fest_id { get; set; }
        public int band_id { get; set; }
        public int pod_id { get; set; }
        public System.DateTime datum { get; set; }
        public System.TimeSpan uur { get; set; }
        public virtual Band Band { get; set; }
        public virtual Festival Festival { get; set; }
        public virtual Podia Podia { get; set; }
    }
}
