
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;

namespace Domain.Services
{
    public class BaseServices<T> : IBaseServices<T> where T: class
    {
        private readonly IRepositoryBase<T> _IBase;

        public BaseServices(IRepositoryBase<T> iBase)
        {
            _IBase = iBase;
        }

        public void Delete(T obj)
        {
            _IBase.Delete(obj);
        }

        public List<T> GetAll()
        {
            return _IBase.GetAll();
        }

        public T GetById(int id)
        {
            return _IBase.GetById(id);
        }

        public void Insert(T obj)
        {
            _IBase.Insert(obj);
        }

        public void Update(T obj)
        {
            _IBase.Update(obj);
        }
    }
}
