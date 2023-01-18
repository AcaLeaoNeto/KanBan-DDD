using Domain.Entitys;
using Domain.Interfaces.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class RepositoryTask : RepositoryBase<Tasks>, IRepositoryTask
    {
        private readonly DbContent _Db;

        public RepositoryTask(DbContent Db) : base(Db)
        {
            _Db = Db;
        }

        public  void ChangeBord(int BoardId, int TaskId)
        {
            var TaskTarget = GetById(TaskId);
            TaskTarget.BoardId = BoardId;
            Update(TaskTarget);
        }
    }
}
