using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Proje.Core.Model.DTO
{
    public class MyDevice
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<MySensor> MySensor { get; set; }
    }
    public class MySensor
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
