using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class Faciliteiten
    {
        public Faciliteiten()
        {
            this.FacPerCamps = new List<FacPerCamp>();
        }

        public int fac_id { get; set; }
        public string fac_omschr { get; set; }
        public decimal fac_eenhprijs { get; set; }
        public virtual ICollection<FacPerCamp> FacPerCamps { get; set; }
    }
}
