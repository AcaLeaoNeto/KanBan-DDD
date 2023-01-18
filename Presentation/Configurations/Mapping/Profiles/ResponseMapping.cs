using AutoMapper;
using Domain.Entitys;
using Domain.Entitys.Dtos;

namespace Presentation.Configurations.Mapping.Profiles 
{
    public class ResponseMapping : Profile
    {
        public ResponseMapping()
        {
            RegisterMaps();
        }

        private void RegisterMaps()
        {
            CreateMap<Board, DtoBoard>();
            CreateMap<Tasks, DtoTasks>();
        }
    }
}
