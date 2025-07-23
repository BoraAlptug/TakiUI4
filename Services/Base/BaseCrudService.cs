using TakiUI4.DataAccess;
using TakiUI4.Models.Utilities;
using TakiUI4.Services.Interfaces;
using System.Threading.Tasks;

namespace TakiUI4.Services.Base
{
    public abstract class BaseCrudService<TAdd, TDelete, TGet> : IAsyncCrudService<TAdd, TDelete, TGet>
        where TAdd : class
        where TDelete : class
        where TGet : class
    {
        protected readonly IDataAccessManager _dataAccessManager;

        protected BaseCrudService(IDataAccessManager dataAccessManager)
        {
            _dataAccessManager = dataAccessManager;
        }

        protected abstract string AddRoute { get; }
        protected abstract string DeleteRoute { get; }
        protected abstract string GetListRoute { get; }

        public async Task<ResponseModel<TAdd>> AddAsync(TAdd entity)
        {
            return await _dataAccessManager.MainDataAccess.PostRequestAsync<TAdd, TAdd>(AddRoute, entity);
        }

        public async Task<ResponseModel<TDelete>> DeleteAsync(TDelete entity)
        {
            return await _dataAccessManager.MainDataAccess.PostRequestAsync<TDelete, TDelete>(DeleteRoute, entity);
        }

        public async Task<ResponseModel<TGet>> GetListAsync()
        {
            return await _dataAccessManager.MainDataAccess.GetRequestAsync<TGet>(GetListRoute);
        }
    }
}
