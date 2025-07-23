namespace TakiUI4.Models.DTO.Product
{
    public class AddProductImageDTO
    {
        public int ProductID { get; set; }
        public List<IFormFile>? ProductImageList { get; set; } 
    }
}
