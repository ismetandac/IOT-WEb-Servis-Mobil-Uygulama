using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Proje.Core.Model.Entity
{
    public class SensorData : EntityBase
    {
        public int SensorID { get; set; }
        public Sensor Sensor { get; set; }
        public string Value { get; set; }
    }
}
