using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class Camping
    {
        public Camping()
        {
            this.FacPerCamps = new List<FacPerCamp>();
            this.Festivals = new List<Festival>();
        }

        public int camp_id { get; set; }
        public string camp_adres { get; set; }
        public int camp_cap { get; set; }
        public virtual ICollection<FacPerCamp> FacPerCamps { get; set; }
        public virtual ICollection<Festival> Festivals { get; set; }
    }
}
