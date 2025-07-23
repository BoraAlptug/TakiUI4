using Microsoft.AspNetCore.Mvc;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Areas.Admin.Controllers
{
    [Area("Admin")]
    public abstract class BaseAdminController<AddDTO, DeleteDTO, GetDTO, TViewModel> : Controller
        where AddDTO : class, new()
        where DeleteDTO : class, new()
        where GetDTO : class, new()
        where TViewModel : class, new()
    {
        protected readonly IServiceManager serviceManager;

        protected BaseAdminController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public virtual IActionResult Index()
        {
            return View(new TViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public abstract  Task<IActionResult> Add(AddDTO dto);

        [HttpPost]
        [ValidateAntiForgeryToken]
        public abstract Task<IActionResult> Delete(DeleteDTO dto);

        [HttpGet]
        public abstract  Task<IActionResult> GetList();

    }
}
