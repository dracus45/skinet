namespace Core.Entities
{
    public class ProductCompany : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CompanyCounty { get; set; }
        public string Bank1  { get; set; }
        public string Account1  { get; set; }
        public string Bank2  { get; set; }
        public string Account2  { get; set; }
        public string Bank3  { get; set; }
        public string Account3  { get; set; }
        public string Cui  { get; set; }
        public string Register  { get; set; }
        public string InvoiceSeries  { get; set; }
        public int InvoiceFirst  { get; set; }
        public int InvoiceLast  { get; set; }
        public string ReceiptSeries  { get; set; }
        public int ReceiptFirst  { get; set; }
        public int ReceiptLast  { get; set; }
        public int Vat  { get; set; }
        public string LogoUrl  { get; set; }
    }
}