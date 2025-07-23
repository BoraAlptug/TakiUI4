using Microsoft.AspNetCore.Mvc;
using TakiUI4.Areas.Admin.Models;
using TakiUI4.Models.DTO.Category;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Areas.Admin.Controllers
{
    public class CategoryController : BaseAdminController<
        AddCategoryDTO,
        DeleteCategoryDTO,
        GetCategoryDTO,
        CategoryViewModel>
    {
        public CategoryController(IServiceManager serviceManager)
            : base(serviceManager) { }

        public override async Task<IActionResult> Add(AddCategoryDTO AddCategory)
        {
            CategoryViewModel model = new CategoryViewModel();
            ResponseModel<AddCategoryDTO> res =await serviceManager.CategoryService.AddAsync(AddCategory);
            ResponseModel<GetCategoryDTO> result = await serviceManager.CategoryService.GetListAsync();
            model.CategoryList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> Delete(DeleteCategoryDTO DeleteCategory)
        {
            CategoryViewModel model = new CategoryViewModel();
            ResponseModel<DeleteCategoryDTO> res =await serviceManager.CategoryService.DeleteAsync(DeleteCategory);
            ResponseModel<GetCategoryDTO> result = await serviceManager.CategoryService.GetListAsync();
            model.CategoryList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> GetList()
        {
            CategoryViewModel model = new CategoryViewModel();
            ResponseModel<GetCategoryDTO> result =await serviceManager.CategoryService.GetListAsync();
            model.CategoryList = result.DataList;
            return View("Index", model);
        }
    }
}
