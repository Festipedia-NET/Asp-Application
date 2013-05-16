using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class Podia
    {
        public Podia()
        {
            this.BandsPerFestivals = new List<BandsPerFestival>();
        }

        public int pod_id { get; set; }
        public string pod_omschr { get; set; }
        public string pod_locatie { get; set; }
        public virtual ICollection<BandsPerFestival> BandsPerFestivals { get; set; }
    }
}
