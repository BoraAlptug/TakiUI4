using TakiUI4.Services.Interfaces;

namespace TakiUI4.Services
{
    public class ServiceManager : IServiceManager
    {
        public IProductService ProductService { get; }
        public ICategoryService CategoryService { get; }
        public IUsersService UsersService { get; }
        public ISliderService SliderService { get; }

        public ServiceManager(
            IProductService productService,
            ICategoryService categoryService,
            IUsersService usersService,
            ISliderService sliderService
        )
        {
            ProductService = productService;
            CategoryService = categoryService;
            UsersService = usersService;
            SliderService = sliderService;
        }
    }
}
