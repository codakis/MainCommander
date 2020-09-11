using System.Collections.Generic;
using AutoMapper;
using MainCommander.Data;
using MainCommander.Dtos;
using MainCommander.Models;
using Microsoft.AspNetCore.Mvc;

namespace MainCommander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class MainCommandsController : ControllerBase
    {
        private readonly IMainCommanderRepo _repo;
        public IMapper _mapper { get; }

        public MainCommandsController(IMainCommanderRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        // private readonly MockMainCommanderRepo _repo = new MockMainCommanderRepo();
        [HttpGet]
        public ActionResult<IEnumerable<MainCommandReadDto>> GetAll()
        {
            var commandItems = _repo.GetAll();
            return Ok(_mapper.Map<IEnumerable<MainCommandReadDto>>(commandItems));
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<MainCommandReadDto> GetById(int id)
        {
            var commandItem = _repo.GetById(id);
            if (commandItem != null)
                return Ok(_mapper.Map<MainCommandReadDto>(commandItem));
            return NotFound();
        }

        [HttpPost]
        public ActionResult<MainCommandReadDto> CreateCommand(MainCommandCreateDto createDto)
        {
            var commandModel = _mapper.Map<MainCommand>(createDto);
            _repo.CreateCommand(commandModel);
            _repo.SaveChanges();

            var commandReadDto = _mapper.Map<MainCommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetById), new { Id = commandReadDto.Id }, commandReadDto);
            //return Ok(createDto);
        }

    }
}