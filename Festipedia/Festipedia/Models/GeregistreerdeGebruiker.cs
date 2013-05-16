using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class GeregistreerdeGebruiker
    {
        public GeregistreerdeGebruiker()
        {
            this.Tickets = new List<Ticket>();
        }

        public int gebr_id { get; set; }
        public string gebr_naam { get; set; }
        public string gebr_adres { get; set; }
        public System.DateTime gebr_gebDat { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
