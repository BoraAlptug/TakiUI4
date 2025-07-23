using System.Threading.Tasks;
using TakiUI4.Areas.Admin.Models;
using TakiUI4.DataAccess;
using TakiUI4.Models.DTO.Product;
using TakiUI4.Models.DTOs.Product;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Base;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Services
{
    public class ProductService : BaseCrudService<AddProductDTO, DeleteProductDTO, GetProductDTO>, IProductService
    {
        public ProductService(IDataAccessManager dataAccessManager) : base(dataAccessManager)
        {
        }

        protected override string AddRoute => AdminRoutes.AddProductRoute;
        protected override string DeleteRoute => AdminRoutes.DeleteProductRoute;
        protected override string GetListRoute => AdminRoutes.GetProductListRoute;
        protected  string GetByIDRoute => AdminRoutes.GetByIDRoute;

        public Task<ResponseModel<AddProductImageDTO>> AddProductImagesAsync(AddProductImageDTO dto) =>
            _dataAccessManager.MainDataAccess.PostRequestWithFileListAsync<AddProductImageDTO>(
               AdminRoutes.AddProductImageRoute, dto.ProductImageList, "ProductID", dto.ProductID, "ProductImageList");

        public Task<ResponseModel<DeleteProductImageDTO>> DeleteProductImagesAsync(DeleteProductImageDTO dto) =>
            _dataAccessManager.MainDataAccess.PostRequestAsync<DeleteProductImageDTO, DeleteProductImageDTO>(
                AdminRoutes.DeleteProductImageRoute, dto);

        public async Task<ResponseModel<GetProductDTO>> GetProductById(GetProductDTO getProductDTO)
        {            
            ResponseModel < GetProductDTO > res =await _dataAccessManager.MainDataAccess.GetRequestByIdAsync<GetProductDTO>(GetByIDRoute, getProductDTO);
            return res;
        }
    }
}
