namespace TakiUI4.Services.Interfaces
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        ICategoryService CategoryService { get; }
        IUsersService UsersService { get; }
        ISliderService SliderService { get; }

    }
}
