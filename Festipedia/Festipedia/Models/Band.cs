using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class Band
    {
        public Band()
        {
            this.BandsPerFestivals = new List<BandsPerFestival>();
        }

        public int band_id { get; set; }
        public string band_naam { get; set; }
        public string band_soortMuziek { get; set; }
        public string band_url { get; set; }
        public virtual ICollection<BandsPerFestival> BandsPerFestivals { get; set; }
    }
}
