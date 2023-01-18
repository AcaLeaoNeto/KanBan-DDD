using Domain.Entitys;

namespace Domain.Interfaces.Repository
{
    public interface IRepositoryTask : IRepositoryBase<Tasks>
    {
        void ChangeBord(int BoardId, int TaskId);
    }
}
