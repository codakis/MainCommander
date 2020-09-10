using System.Collections.Generic;
using MainCommander.Models;
using Microsoft.AspNetCore.Mvc;

namespace MainCommander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class MainCommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<MainCommand>> GetAll()
        {

        }

        [HttpGet("{id}")]
        public ActionResult<MainCommand> GetById(int id)
        {

        }

    }
}