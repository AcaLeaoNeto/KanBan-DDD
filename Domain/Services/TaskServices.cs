
using Domain.Entitys;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;

namespace Domain.Services
{
    public class TaskServices : BaseServices<Tasks> , ITaskServices
    {
        private readonly IRepositoryTask _IRepTask;

        public TaskServices( IRepositoryTask IRepTask) : base(IRepTask)
        {
            _IRepTask = IRepTask;
        }

        public void ChangeBord(int BoardId, int TaskId)
        {
            _IRepTask.ChangeBord(BoardId, TaskId);
        }
    }
}
