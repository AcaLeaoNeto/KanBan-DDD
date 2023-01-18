using AutoMapper;
using Domain.Entitys;
using Domain.Entitys.Dtos;


namespace Presentation.Configurations.Mapping.Profiles
{
    public class RequestMapping : Profile
    {

        public RequestMapping()
        {
            RegisterMaps();
        }

        private void RegisterMaps()
        {
            CreateMap<DtoBoard, Board>();
            CreateMap<DtoTasks, Tasks>();
        }
    }
}
