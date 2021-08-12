using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class Insurance
    {
        public Insurance()
        {
            InsuranceClaims = new HashSet<InsuranceClaim>();
        }

        public int IapplicationId { get; set; }
        public int? CropId { get; set; }
        public int? UserId { get; set; }
        public string Year { get; set; }
        public string Season { get; set; }
        public string Area { get; set; }
        public decimal? SumInsuredPerHectare { get; set; }

        public virtual CropForSale Crop { get; set; }
        public virtual TblUser User { get; set; }
        public virtual ICollection<InsuranceClaim> InsuranceClaims { get; set; }
    }
}
