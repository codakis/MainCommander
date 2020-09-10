using MainCommander.Models;
using Microsoft.EntityFrameworkCore;

namespace MainCommander.Data
{
    public class MainCommanderContext : DbContext
    {
        public MainCommanderContext(DbContextOptions<MainCommanderContext> opt) : base(opt)
        {

        }

        public DbSet<MainCommand> Commands { get; set; }
    }
}