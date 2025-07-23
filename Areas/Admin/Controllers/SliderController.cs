using Microsoft.AspNetCore.Mvc;
using TakiUI4.Areas.Admin.Models;
using TakiUI4.Models.DTO.Category;
using TakiUI4.Models.DTO.Slider;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Areas.Admin.Controllers
{
    public class SliderController : BaseAdminController<
        AddSliderDTO,
        DeleteSliderDTO,
        GetSliderDTO,
        SliderViewModel>
    {
        public SliderController(IServiceManager serviceManager) : base(serviceManager)
        {
        }

        public override async Task<IActionResult> Add(AddSliderDTO AddSlider)
        {
            SliderViewModel model = new SliderViewModel();
            ResponseModel<AddSliderDTO> res = await serviceManager.SliderService.AddAsync(AddSlider);
            ResponseModel<GetSliderDTO> result = await serviceManager.SliderService.GetListAsync();
            model.SliderList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> Delete(DeleteSliderDTO DeleteSlider)
        {
            SliderViewModel model = new SliderViewModel();
            ResponseModel<DeleteSliderDTO> res = await serviceManager.SliderService.DeleteAsync(DeleteSlider);
            ResponseModel<GetSliderDTO> result = await serviceManager.SliderService.GetListAsync();
            model.SliderList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> GetList()
        {
            SliderViewModel model = new SliderViewModel();
            ResponseModel<GetSliderDTO> result = await serviceManager.SliderService.GetListAsync();
            model.SliderList = result.DataList;
            return View("Index", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMedia(AddSliderMediaDTO AddSliderMediaDTO)
        {
            SliderViewModel model = new SliderViewModel();
            ResponseModel<AddSliderMediaDTO> res = await serviceManager.SliderService.AddMediaAsync(AddSliderMediaDTO);
            ResponseModel<GetSliderDTO> result = await serviceManager.SliderService.GetListAsync();
            model.SliderList = result.DataList;
            return View("Index", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteMedia(DeleteSliderMediaDTO DeleteSliderMediaDTO)
        {
            SliderViewModel model = new SliderViewModel();
            ResponseModel<DeleteSliderMediaDTO> res = await serviceManager.SliderService.DeleteMediaAsync(DeleteSliderMediaDTO);
            ResponseModel<GetSliderDTO> result = await serviceManager.SliderService.GetListAsync();
            model.SliderList = result.DataList;
            return View("Index", model);
        }

    }
}
