using TakiUI4.Models.DTO.Slider;

namespace TakiUI4.Areas.Admin.Models
{
    public class SliderViewModel
    {
        public AddSliderDTO? AddSlider { get; set; }= new AddSliderDTO();
        public DeleteSliderDTO? DeleteSlider { get; set; }= new DeleteSliderDTO();
        public List<GetSliderDTO>? SliderList {  get; set; }= new List<GetSliderDTO>();
        public AddSliderMediaDTO? AddSliderMediaDTO { get; set; } = new AddSliderMediaDTO();
        public DeleteSliderMediaDTO? DeleteSliderMediaDTO { get; set; } = new DeleteSliderMediaDTO();
    }
}
