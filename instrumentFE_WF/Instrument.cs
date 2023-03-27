using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrumentFE_WF
{
    public class Instrument
    {
        [Key]
        public string instrumentName { get; set; }
        public string serialNumber { get; set; }
        public string registerDate { get; set; }
        public string signalType { get; set; }
        public string measureType { get; set; }
        public string options { get; set; }
        public string lrv { get; set; }
        public string urv { get; set; }
        public string comment { get; set; }


    }
}
