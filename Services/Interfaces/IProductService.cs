using TakiUI4.Models.DTO.Product;
using TakiUI4.Models.DTOs.Product;
using TakiUI4.Models.Utilities;

namespace TakiUI4.Services.Interfaces
{
    public interface IProductService : IAsyncCrudService<AddProductDTO, DeleteProductDTO, GetProductDTO>
    {
        Task<ResponseModel<AddProductImageDTO>> AddProductImagesAsync(AddProductImageDTO addProductImageDTO);
        Task<ResponseModel<DeleteProductImageDTO>> DeleteProductImagesAsync(DeleteProductImageDTO deleteProductImageDTO);
        Task<ResponseModel<GetProductDTO>> GetProductById(GetProductDTO getProductDTO);
    }
}
