using Domain.Entitys;
using Domain.Interfaces.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class RepositoryBoard : RepositoryBase<Board>, IRepositoryBoard
    {
        private readonly DbContent _Db;

        public RepositoryBoard(DbContent Db) : base(Db)
        {
            _Db = Db;
        }
    }
}
