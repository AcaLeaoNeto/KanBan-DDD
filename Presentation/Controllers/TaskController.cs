using Microsoft.AspNetCore.Mvc;
using Domain.Entitys;
using Domain.Interfaces.Service;
using AutoMapper;
using Domain.Entitys.Dtos;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController: ControllerBase
    {
        private readonly ITaskServices _IServiceTask;
        private readonly IMapper _Mapper;

        public TaskController(ITaskServices IServiceTask, IMapper Mapper)
        {
            _IServiceTask = IServiceTask;
            _Mapper = Mapper;
        }


        [HttpPatch]
        public async Task<ActionResult> ChangeBord(int BoardId, int TaskId)
        {
            await Task.CompletedTask;
            _IServiceTask.ChangeBord(BoardId, TaskId);
            return Ok();
        }


        [HttpDelete]
        public async Task<ActionResult> Delete(DtoTasks obj)
        {
            await Task.CompletedTask;
            _IServiceTask.Delete(_Mapper.Map<Tasks>(obj));
            return Ok();
        }


        [HttpGet]
        public async Task<ActionResult<List<Tasks>>> GetAll()
        {
            await Task.CompletedTask;
            // var objs = _IServiceTask.GetAll();
            //return _Mapper.Map<List<DtoTasks>>(objs);
            return _IServiceTask.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<DtoTasks>>> GetById(int id)
        {
            await Task.CompletedTask;
            var obj = _IServiceTask.GetById(id);
            return Ok(_Mapper.Map<DtoTasks>(obj));
        }

        [HttpPost]
        public async Task<ActionResult> Insert(DtoTasks obj)
        {
            await Task.CompletedTask;
            _IServiceTask.Insert(_Mapper.Map<Tasks>(obj));
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(Tasks obj)
        {
            await Task.CompletedTask;
            _IServiceTask.Update(obj);
            return Ok();
        }
    }
}
