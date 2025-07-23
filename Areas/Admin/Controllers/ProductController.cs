using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TakiUI4.Areas.Admin.Models;
using TakiUI4.Models.DTO.Product;
using TakiUI4.Models.DTOs.Product;
using TakiUI4.Models.Utilities;
using TakiUI4.Services;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Areas.Admin.Controllers
{
    public class ProductController : BaseAdminController<
        AddProductDTO,
        DeleteProductDTO,
        GetProductDTO,
        ProductViewModel>
    {
        public ProductController(IServiceManager serviceManager)
            : base(serviceManager) { }

        public override async Task<IActionResult> Add(AddProductDTO AddProduct)
        {
            ProductViewModel model = new ProductViewModel();
            ResponseModel<AddProductDTO> res =await serviceManager.ProductService.AddAsync(AddProduct);
            ResponseModel<GetProductDTO> result = await serviceManager.ProductService.GetListAsync();
            model.ProductList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> Delete(DeleteProductDTO DeleteProduct)
        {
            ProductViewModel model = new ProductViewModel();
            ResponseModel<DeleteProductDTO> res =await serviceManager.ProductService.DeleteAsync(DeleteProduct);
            ResponseModel<GetProductDTO> result = await serviceManager.ProductService.GetListAsync();
            model.ProductList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> GetList()
        {
            ProductViewModel model = new ProductViewModel();
            ResponseModel<GetProductDTO> result =await serviceManager.ProductService.GetListAsync();
            model.ProductList = result.DataList;
            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddImages(AddProductImageDTO addProductImageDTO)
        {
            ProductViewModel model = new ProductViewModel();
            ResponseModel<AddProductImageDTO> res = await serviceManager.ProductService.AddProductImagesAsync(addProductImageDTO);
            ResponseModel<GetProductDTO> result = await serviceManager.ProductService.GetListAsync();
            model.ProductList = result.DataList;
            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteImage(DeleteProductImageDTO deleteProductImage)
        {
            ProductViewModel model = new ProductViewModel();
            ResponseModel<DeleteProductImageDTO> res = await serviceManager.ProductService.DeleteProductImagesAsync(deleteProductImage);
            ResponseModel<GetProductDTO> result = await serviceManager.ProductService.GetListAsync();
            model.ProductList = result.DataList;
            return View("Index", model);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(GetProductDTO getProductDTO)
        {
            ProductViewModel model = new ProductViewModel();
            ResponseModel<GetProductDTO> product =await serviceManager.ProductService.GetProductById(getProductDTO);
            
            return View(product);
        }


    }
}
