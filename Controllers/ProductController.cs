using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TakiUI4.Areas.Admin.Controllers;
using TakiUI4.Areas.Admin.Models;
using TakiUI4.Models.DTO.Product;
using TakiUI4.Models.DTOs.Product;
using TakiUI4.Models.Utilities;
using TakiUI4.Services;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager serviceManager;
        public ProductController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        //public  async Task<IActionResult> GetList()
        //{
        //    ProductViewModel model = new ProductViewModel();
        //    ResponseModel<GetProductDTO> result =await serviceManager.ProductService.GetListAsync();
        //    model.ProductList = result.DataList;
        //    return View("Index", model);
        //}          
               
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(GetProductDTO getProductDTO)
        {
            ProductViewModel model= new ProductViewModel();
            ResponseModel<GetProductDTO> product =await serviceManager.ProductService.GetProductById(getProductDTO);
            model.ProductList=product.DataList;

            return View("Detail",model);
        }


    }
}
