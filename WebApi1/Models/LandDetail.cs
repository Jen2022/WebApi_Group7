using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class LandDetail
    {
        public int LandId { get; set; }
        public int? UserId { get; set; }
        public string LandArea { get; set; }
        public string LandAddress { get; set; }
        public int LandPincode { get; set; }

        public virtual TblUser User { get; set; }
    }
}
