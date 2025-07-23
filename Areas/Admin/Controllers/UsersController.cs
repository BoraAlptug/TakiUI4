using Microsoft.AspNetCore.Mvc;
using TakiUI4.Areas.Admin.Models;
using TakiUI4.Models.DTO.Category;
using TakiUI4.Models.DTO.Users;
using TakiUI4.Models.DTOs.Product;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Areas.Admin.Controllers
{
    public class UsersController : BaseAdminController<
        AddUsersDTO,
        DeleteUsersDTO,
        GetUsersDTO,
        UsersViewModel>
    {
        public UsersController(IServiceManager serviceManager) : base(serviceManager)
        {
        }

        public override async Task<IActionResult> Add(AddUsersDTO AddUsers)
        {
            UsersViewModel model = new UsersViewModel();
            ResponseModel<AddUsersDTO> res = await serviceManager.UsersService.AddAsync(AddUsers);
            ResponseModel<GetUsersDTO> result = await serviceManager.UsersService.GetListAsync();
            model.UsersList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> Delete(DeleteUsersDTO DeleteUsers)
        {
            UsersViewModel model = new UsersViewModel();
            ResponseModel<DeleteUsersDTO> res = await serviceManager.UsersService.DeleteAsync(DeleteUsers);
            ResponseModel<GetUsersDTO> result = await serviceManager.UsersService.GetListAsync();
            model.UsersList = result.DataList;
            return View("Index", model);
        }

        public override async Task<IActionResult> GetList()
        {
            UsersViewModel model = new UsersViewModel();
            ResponseModel<GetUsersDTO> result = await serviceManager.UsersService.GetListAsync();
            model.UsersList = result.DataList;
            return View("Index", model);
        }
    }
}
