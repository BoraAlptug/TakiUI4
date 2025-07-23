using Microsoft.AspNetCore.Mvc;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Views.Shared.Components
{
    public class HeaderViewComponent: ViewComponent
    {
        private readonly IServiceManager _serviceManager;
        public HeaderViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _serviceManager.ProductService.GetListAsync();
            return View("Default");
        }

    }
}
