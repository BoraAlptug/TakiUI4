namespace TakiUI4.Models.DTOs.Product
{
    public class GetProductImageDTO
    {
        public int? ProductImageID { get; set; }
        public double? FileSizeMB { get; set; }
        public string? ImageUrl { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }
}
