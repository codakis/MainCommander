using System.Collections.Generic;
using System.Linq;
using MainCommander.Models;

namespace MainCommander.Data
{
    public class SqlCommanderRepo : IMainCommanderRepo
    {
        private readonly MainCommanderContext _context;
        public SqlCommanderRepo(MainCommanderContext context)
        {
            _context = context;

        }
        public IEnumerable<MainCommand> GetAll()
        {
            return _context.Commands.ToList();
        }

        public MainCommand GetById(int id)
        {
            return _context.Commands.FirstOrDefault(i => i.Id == id);
        }
    }
}