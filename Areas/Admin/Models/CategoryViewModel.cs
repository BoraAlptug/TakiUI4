using TakiUI4.Models.DTO.Category;

namespace TakiUI4.Areas.Admin.Models
{
    public class CategoryViewModel
    {
        public AddCategoryDTO? AddCategory { get; set; } = new AddCategoryDTO();
        public DeleteCategoryDTO? DeleteCategory { get; set; } = new DeleteCategoryDTO();
        public List<GetCategoryDTO>? CategoryList { get; set; } = new List<GetCategoryDTO>();

    }
}
