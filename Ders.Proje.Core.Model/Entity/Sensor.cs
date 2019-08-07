using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Proje.Core.Model.Entity
{
    public class Sensor : EntityBase
    {
        public _SensorType SensorType { get; set; }
        public string Name { get; set; }
        public int DeviceID { get; set; }
        public Device Device { get; set; }
        public virtual List<SensorData> SensorData { get; set; }
    }
    public enum _SensorType
    {
        Sicaklik = 0,
        Nem = 1,
        Ldr = 2,
        Mesafe = 3
    }

}
