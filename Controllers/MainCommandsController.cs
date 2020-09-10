using System.Collections.Generic;
using MainCommander.Data;
using MainCommander.Models;
using Microsoft.AspNetCore.Mvc;

namespace MainCommander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class MainCommandsController : ControllerBase
    {
        private readonly IMainCommanderRepo _repo;

        public MainCommandsController(IMainCommanderRepo repo)
        {
            _repo = repo;
        }
        // private readonly MockMainCommanderRepo _repo = new MockMainCommanderRepo();
        [HttpGet]
        public ActionResult<IEnumerable<MainCommand>> GetAll()
        {
            var commandItems = _repo.GetAll();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<MainCommand> GetById(int id)
        {
            var commandItem = _repo.GetById(id);
            return Ok(commandItem);
        }

    }
}