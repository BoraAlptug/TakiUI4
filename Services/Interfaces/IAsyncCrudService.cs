// Services/Interfaces/IAsyncCrudService.cs
using TakiUI4.Models.Utilities;

namespace TakiUI4.Services.Interfaces
{
    public interface IAsyncCrudService<TAdd, TDelete, TGet>
        where TAdd : class
        where TDelete : class
        where TGet : class
    {
        Task<ResponseModel<TAdd>> AddAsync(TAdd entity);
        Task<ResponseModel<TDelete>> DeleteAsync(TDelete entity);
        Task<ResponseModel<TGet>> GetListAsync();
    }
}
