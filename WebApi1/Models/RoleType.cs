using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class RoleType
    {
        public int? UserId { get; set; }
        public string UserRole { get; set; }

        public virtual TblUser User { get; set; }
    }
}
