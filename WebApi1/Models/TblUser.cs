using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            BankDetails = new HashSet<BankDetail>();
            BidderMarketplaces = new HashSet<BidderMarketplace>();
            CropForSales = new HashSet<CropForSale>();
            Insurances = new HashSet<Insurance>();
            LandDetails = new HashSet<LandDetail>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string AadharCard { get; set; }
        public string PanCard { get; set; }
        public string Certificate { get; set; }
        public string TraderLicense { get; set; }
        public string Password { get; set; }
        public string VerificationStatus { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual ICollection<BankDetail> BankDetails { get; set; }
        public virtual ICollection<BidderMarketplace> BidderMarketplaces { get; set; }
        public virtual ICollection<CropForSale> CropForSales { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
        public virtual ICollection<LandDetail> LandDetails { get; set; }
    }
}
