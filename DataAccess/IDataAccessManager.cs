namespace TakiUI4.DataAccess
{
    public interface IDataAccessManager
    {
        IMainDataAccess MainDataAccess { get; }
    }
    public class DataAccessManager : IDataAccessManager
    {
        private readonly IMainDataAccess _mainDataAccess;
        public DataAccessManager(IMainDataAccess MainDataAccess)
        {
            _mainDataAccess = MainDataAccess;
        }
        public IMainDataAccess MainDataAccess => _mainDataAccess;
    }
}
