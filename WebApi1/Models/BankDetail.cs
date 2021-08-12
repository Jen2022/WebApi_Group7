using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class BankDetail
    {
        public int BankId { get; set; }
        public int? UserId { get; set; }
        public string AccountNo { get; set; }
        public string IfscCode { get; set; }

        public virtual TblUser User { get; set; }
    }
}
