using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrumentFE_WF
{
    
    public class InstrumentGateway
    {
        ApplicationDBContext _dbContext = new ApplicationDBContext();

        public bool Add(Instrument instrument) {
            _dbContext.Add(instrument);
            _dbContext.SaveChanges();
            return _dbContext.SaveChanges() > 0;

        }

        public List<Instrument> GetAll()
        {
            return _dbContext.instruments.ToList();
        }
    }
}
