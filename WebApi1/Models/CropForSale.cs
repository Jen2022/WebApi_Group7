using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class CropForSale
    {
        public CropForSale()
        {
            BidderMarketplaces = new HashSet<BidderMarketplace>();
            Insurances = new HashSet<Insurance>();
        }

        public int CropId { get; set; }
        public int? UserId { get; set; }
        public string CropType { get; set; }
        public string CropName { get; set; }
        public double Quantity { get; set; }
        public int SoilPh { get; set; }
        public string FertilizerType { get; set; }
        public DateTime DateOfSoldCrop { get; set; }
        public decimal? Msp { get; set; }
        public decimal? SoldPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string StatusOfCropSell { get; set; }
        public string SoilCert { get; set; }

        public virtual TblUser User { get; set; }
        public virtual ICollection<BidderMarketplace> BidderMarketplaces { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
    }
}
