using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrumentFE_WF {
    public class InstrumentGen {
        public string SensorName    { get; set; }
        public string SerialNumber  { get; set; }
        public string SignalType    { get; set; }
        public string MeasureType   { get; set; }
        public string Options       { get; set; }
        public string LRV           { get; set; }
        public string URV           { get; set; }
        public string Comment       { get; set; }

        private List<InstrumentGen> InstrumentList = new List<InstrumentGen>();

        public void CreateInstrument(
                                        string sensorName,
                                        string serialNumber,
                                        string signalType,
                                        string measureType,
                                        string options,
                                        string lrv,
                                        string urv,
                                        string comment) {
            InstrumentGen newInstrument = new InstrumentGen() {
                SensorName = sensorName,
                SerialNumber = serialNumber,
                SignalType = signalType,
                MeasureType = measureType,
                Options = options,
                LRV = lrv,
                URV = urv,
                Comment = comment};

            InstrumentList.Add(newInstrument);
        }

        public List<InstrumentGen> GetInstruments() {
            return InstrumentList;
        }

    }
}
