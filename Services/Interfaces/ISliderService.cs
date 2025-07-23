using TakiUI4.Models.DTO.Category;
using TakiUI4.Models.DTO.Slider;
using TakiUI4.Models.Utilities;

namespace TakiUI4.Services.Interfaces
{
    public interface ISliderService : IAsyncCrudService<AddSliderDTO, DeleteSliderDTO, GetSliderDTO>
    {
        Task<ResponseModel<AddSliderMediaDTO>> AddMediaAsync(AddSliderMediaDTO sliderMedia);
        Task<ResponseModel<DeleteSliderMediaDTO>> DeleteMediaAsync(DeleteSliderMediaDTO deleteSliderMediaDTO);
    }
}
