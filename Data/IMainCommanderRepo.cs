using System.Collections.Generic;
using MainCommander.Models;

namespace MainCommander.Data
{
    public interface IMainCommaderRepo
    {
        IEnumerable<MainCommand> GetAll();
        MainCommand GetById(int id);
    }
}