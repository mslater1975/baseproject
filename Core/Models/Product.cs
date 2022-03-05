namespace Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string Picture1Url { get; set; }
        public string Picture2Url { get; set; }
        public string PictureEnergyUrl { get; set; }
        public string PictureEcoUrl { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
        public bool Display { get; set; }
        public string Weight { get; set; }
        public string HeatOutput { get; set; }
        public string FeaturesAndBenefits1 { get; set; }
        public string FeaturesAndBenefits2 { get; set; }
        public string FeaturesAndBenefits3 { get; set; }
        public string FeaturesAndBenefits4 { get; set; }
        public string FeaturesAndBenefits5 { get; set; }
        public string FeaturesAndBenefits6 { get; set; }
    }
}