using TakiUI4.Areas.Admin.Models;
using TakiUI4.DataAccess;
using TakiUI4.Models.DTO.Product;
using TakiUI4.Models.DTO.Slider;
using TakiUI4.Models.DTO.Users;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Base;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Services
{
    public class SliderService : BaseCrudService<AddSliderDTO, DeleteSliderDTO, GetSliderDTO>, ISliderService
    {
        public SliderService(IDataAccessManager dataAccessManager) : base(dataAccessManager)
        {
        }

        protected override string AddRoute =>AdminRoutes.AddSliderRoute;

        protected override string DeleteRoute => AdminRoutes.DeleteSliderRoute;

        protected override string GetListRoute => AdminRoutes.GetSliderListRoute;

        public Task<ResponseModel<AddSliderMediaDTO>> AddMediaAsync(AddSliderMediaDTO dto) =>
             _dataAccessManager.MainDataAccess.PostRequestWithFileListAsync<AddSliderMediaDTO>(
                 AdminRoutes.AddSliderMediaRoute, dto.SliderMedia, "SliderID", dto.SliderID, "SliderMedia");

        public Task<ResponseModel<DeleteSliderMediaDTO>> DeleteMediaAsync(DeleteSliderMediaDTO deleteSliderMediaDTO)
       =>
            _dataAccessManager.MainDataAccess.PostRequestAsync<DeleteSliderMediaDTO, DeleteSliderMediaDTO>(
                AdminRoutes.DeleteSliderMediaRoute, deleteSliderMediaDTO);
    }
}
