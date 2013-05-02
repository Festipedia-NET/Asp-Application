using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class Ticket
    {
        public int fest_id { get; set; }
        public int gebr_id { get; set; }
        public int typ_id { get; set; }
        public System.DateTime ticket_datum { get; set; }
        public virtual Festival Festival { get; set; }
        public virtual GeregistreerdeGebruiker GeregistreerdeGebruiker { get; set; }
        public virtual Tickettype Tickettype { get; set; }
    }
}
