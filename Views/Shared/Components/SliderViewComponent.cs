using Microsoft.AspNetCore.Mvc;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Views.Shared.Components
{
    public class SliderViewComponent: ViewComponent
    {
        private readonly IServiceManager _serviceManager;
        public SliderViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _serviceManager.SliderService.GetListAsync(); 
            return View("Default", result.DataList); 
        }
    }
}
