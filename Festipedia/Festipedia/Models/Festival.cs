using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Festipedia.Models
{
    public partial class Festival
    {
        public Festival()
        {
            this.BandsPerFestivals = new List<BandsPerFestival>();
            this.Tickets = new List<Ticket>();
            this.TickettypesPerFestivals = new List<TickettypesPerFestival>();
            this.Campings = new List<Camping>();
        }

        public int fest_id { get; set; }
        public string fest_naam { get; set; }
        public string fest_locatie { get; set; }
        public System.DateTime fest_datum { get; set; }
        public int fest_duur { get; set; }
        public virtual ICollection<BandsPerFestival> BandsPerFestivals { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<TickettypesPerFestival> TickettypesPerFestivals { get; set; }
        public virtual ICollection<Camping> Campings { get; set; }
    }
}
