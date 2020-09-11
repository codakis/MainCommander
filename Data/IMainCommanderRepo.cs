using System.Collections.Generic;
using MainCommander.Models;

namespace MainCommander.Data
{
    public interface IMainCommanderRepo
    {
        IEnumerable<MainCommand> GetAll();
        MainCommand GetById(int id);
        void CreateCommand(MainCommand cmd);
        void UpdateCommand(MainCommand cmd);
        bool SaveChanges();
        void Delete(MainCommand cmd);

    }
}