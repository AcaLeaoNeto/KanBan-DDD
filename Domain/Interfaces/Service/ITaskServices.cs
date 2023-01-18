using Domain.Entitys;

namespace Domain.Interfaces.Service
{
    public interface ITaskServices : IBaseServices<Tasks>
    {
        void ChangeBord(int BoardId, int TaskId);
    }
}
