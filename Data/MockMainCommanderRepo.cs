using System.Collections.Generic;
using MainCommander.Models;

namespace MainCommander.Data
{
    public class MockMainCommanderRepo : IMainCommanderRepo
    {
        public void CreateCommand(MainCommand cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<MainCommand> GetAll()
        {
            var commands = new List<MainCommand> {
               new MainCommand { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and kitchen" },
               new MainCommand { Id = 1, HowTo = "Comb hair", Line = "Comb my hair", Platform = "Just a comb" },
               new MainCommand { Id = 2, HowTo = "Shave beard", Line = "Shaving beard", Platform = "Razor and mirror" }
           };
            return commands;
        }

        public MainCommand GetById(int id)
        {
            return new MainCommand { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and kitchen" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(MainCommand cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}