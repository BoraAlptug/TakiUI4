using TakiUI4.Areas.Admin.Models;
using TakiUI4.Models.DTO.Category;
using TakiUI4.Models.DTOs.Product;

namespace TakiUI4.Services.Interfaces
{
    public interface ICategoryService: IAsyncCrudService<AddCategoryDTO, DeleteCategoryDTO, GetCategoryDTO>
    {
    }
}
