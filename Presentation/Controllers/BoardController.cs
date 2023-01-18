using AutoMapper;
using Domain.Entitys;
using Domain.Entitys.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardServices _IBoardServices;
        private readonly IMapper _Mapper;

        public BoardController(IBoardServices IBoardServices, IMapper Mapper)
        {
            _IBoardServices = IBoardServices;
            _Mapper = Mapper;
        }


        [HttpDelete]
        public async Task<ActionResult> Delete(DtoBoard obj)
        {
            await Task.CompletedTask;
            _IBoardServices.Delete(_Mapper.Map<Board>(obj));
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<Board>>> GetAll()
        {
            await Task.CompletedTask;
            //var objs = _IBoardServices.GetAll();
            //return _Mapper.Map<List<DtoBoard>>(objs);
            return _IBoardServices.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<DtoBoard>>> GetById(int id)
        {
            await Task.CompletedTask;
            var obj = _IBoardServices.GetById(id);
            return Ok(_Mapper.Map<DtoBoard>(obj));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(DtoBoard obj)
        {
            await Task.CompletedTask;
            _IBoardServices.Insert(_Mapper.Map<Board>(obj));
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(Board obj)
        {
            await Task.CompletedTask;
            _IBoardServices.Update(obj);
            return Ok();
        }
    }
}
