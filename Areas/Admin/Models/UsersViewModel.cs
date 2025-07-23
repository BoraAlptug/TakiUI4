using TakiUI4.Models.DTO.Users;

namespace TakiUI4.Areas.Admin.Models
{
    public class UsersViewModel
    {
        public AddUsersDTO? AddUsers { get; set; } = new AddUsersDTO();
        public DeleteUsersDTO? DeleteUsers { get; set; } = new DeleteUsersDTO();
        public List<GetUsersDTO>? UsersList { get; set; } = new List<GetUsersDTO>();
    }
}
