using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrumentFE_WF
{
    public  class InstrumentManager
    {
        InstrumentGateway _instrumentGateway = new InstrumentGateway();

        public bool Add(Instrument instrument)
        {
            return _instrumentGateway.Add(instrument);
        }

        public List<Instrument> GetAll()
        {
            return _instrumentGateway.GetAll();
        }
    }
}
