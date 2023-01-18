using Domain.Entitys;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;

namespace Domain.Services
{
    public class BoardServices : BaseServices<Board> , IBoardServices
    {
        private readonly IRepositoryBoard _IRepBoard;

        public BoardServices(IRepositoryBoard IRepBoard) : base(IRepBoard)
        {
            _IRepBoard = IRepBoard;
        }
    }
}
