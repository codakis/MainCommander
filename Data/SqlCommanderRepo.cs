using System;
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

        public void CreateCommand(MainCommand cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException(nameof(cmd));

            _context.Commands.Add(cmd);
        }

        public IEnumerable<MainCommand> GetAll()
        {
            return _context.Commands.ToList();
        }

        public MainCommand GetById(int id)
        {
            return _context.Commands.FirstOrDefault(i => i.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);

        }

        public void UpdateCommand(MainCommand cmd)
        {

        }
    }
}