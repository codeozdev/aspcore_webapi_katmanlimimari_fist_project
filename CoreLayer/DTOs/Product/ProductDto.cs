namespace CoreLayer.DTOs.Product
{
    public class ProductDto : BaseDto
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
