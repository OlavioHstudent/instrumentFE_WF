using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrumentFE_WF
{
    public class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\Program Files\\Microsoft Visual Studio\\2022\\Source\\Repos\\InstrumentFE\\instrumentFE_WF\\DB\\instrumentConfDB.db");
        }
        public DbSet<Instrument> instruments { get; set; }
    }
}
