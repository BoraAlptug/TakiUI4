namespace TakiUI4.Models.DTO.Slider
{
    public class GetSliderDTO
    {
        public int SliderID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? MediaUrl { get; set; }
        public int? MediaID { get; set; }
        public double? FileSizeMB { get; set; }
        public string? MediaType { get; set; }

    }
}
