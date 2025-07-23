using TakiUI4.Models.DTO.Product;
using TakiUI4.Models.DTOs.Product;

namespace TakiUI4.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public AddProductDTO? AddProduct { get; set; } = new AddProductDTO();
        public DeleteProductDTO? DeleteProduct { get; set; } = new DeleteProductDTO();
        public AddProductImageDTO? AddProductImage { get; set; } = new AddProductImageDTO();
        public DeleteProductImageDTO? DeleteProductImage { get; set; } = new DeleteProductImageDTO();
        public List<GetProductDTO>? ProductList { get; set; } = new List<GetProductDTO>();

    }
}
