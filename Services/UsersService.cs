using TakiUI4.Areas.Admin.Models;
using TakiUI4.DataAccess;
using TakiUI4.Models.DTO.Users;
using TakiUI4.Models.DTOs.Product;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Base;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Services
{
    public class UsersService : BaseCrudService<AddUsersDTO, DeleteUsersDTO, GetUsersDTO>, IUsersService
    {
        public UsersService(IDataAccessManager dataAccessManager) : base(dataAccessManager)
        {
        }

        protected override string AddRoute => AdminRoutes.AddUserRoute;
        protected override string DeleteRoute => AdminRoutes.DeleteUserRoute;
        protected override string GetListRoute => AdminRoutes.GetUserListRoute;

        public async Task<ResponseModel<AddUsersDTO>> AddAsync(AddUsersDTO entity)
        {
            return await _dataAccessManager.MainDataAccess.PostRequestAsync<AddUsersDTO, AddUsersDTO>(AddRoute, entity);
        }

        public Task<ResponseModel<DeleteUsersDTO>> DeleteAsync(DeleteUsersDTO entity)
        {
            return _dataAccessManager.MainDataAccess.PostRequestAsync<DeleteUsersDTO, DeleteUsersDTO>(DeleteRoute, entity);
        }

        public Task<ResponseModel<GetUsersDTO>> GetListAsync()
        {
            return _dataAccessManager.MainDataAccess.GetRequestAsync<GetUsersDTO>(GetListRoute);
        }
    }
}
