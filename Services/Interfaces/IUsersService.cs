using TakiUI4.Models.DTO.Users;

namespace TakiUI4.Services.Interfaces
{
    public interface IUsersService: IAsyncCrudService<AddUsersDTO, DeleteUsersDTO, GetUsersDTO>
    {
    }
}
