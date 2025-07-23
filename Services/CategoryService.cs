using TakiUI4.Areas.Admin.Models;
using TakiUI4.DataAccess;
using TakiUI4.Models.DTO.Category;
using TakiUI4.Services.Base;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Services
{
    public class CategoryService : BaseCrudService<AddCategoryDTO, DeleteCategoryDTO, GetCategoryDTO>, ICategoryService
    {
        public CategoryService(IDataAccessManager dataAccessManager) : base(dataAccessManager)
        {
        }

        protected override string AddRoute => AdminRoutes.AddCategoryRoute;
        protected override string DeleteRoute => AdminRoutes.DeleteCategoryRoute;
        protected override string GetListRoute => AdminRoutes.GetCategoryListRoute;
    }
}
