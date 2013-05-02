using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class Tickettype
    {
        public Tickettype()
        {
            this.Tickets = new List<Ticket>();
            this.TickettypesPerFestivals = new List<TickettypesPerFestival>();
        }

        public int typ_id { get; set; }
        public string typ_omschr { get; set; }
        public decimal typ_prijs { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<TickettypesPerFestival> TickettypesPerFestivals { get; set; }
    }
}
