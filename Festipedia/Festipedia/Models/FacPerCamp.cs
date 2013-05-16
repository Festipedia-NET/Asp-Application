using System;
using System.Collections.Generic;

namespace Festipedia.Models
{
    public partial class FacPerCamp
    {
        public int camp_id { get; set; }
        public int fac_id { get; set; }
        public int aantal { get; set; }
        public virtual Camping Camping { get; set; }
        public virtual Faciliteiten Faciliteiten { get; set; }
    }
}
