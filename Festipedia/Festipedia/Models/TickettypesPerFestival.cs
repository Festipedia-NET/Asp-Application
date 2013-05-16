using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class TickettypesPerFestival
    {
        public int fest_id { get; set; }
        public int typ_id { get; set; }
        public int aantal { get; set; }
        public virtual Festival Festival { get; set; }
        public virtual Tickettype Tickettype { get; set; }
    }
}
