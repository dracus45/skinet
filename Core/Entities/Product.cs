namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }    
        public ProductCompany ProductCompany { get; set; }
        public int ProductCompanyId { get; set; }
        public string Um { get; set; }
        public decimal Price { get; set; }
        public int Currency { get; set; }
        public int Vat { get; set; }    
    }
}