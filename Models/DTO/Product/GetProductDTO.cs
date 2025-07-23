

namespace TakiUI4.Models.DTOs.Product
{
    public class GetProductDTO
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public List<GetProductImageDTO>? ProductImageList { get; set; }
    }
}
