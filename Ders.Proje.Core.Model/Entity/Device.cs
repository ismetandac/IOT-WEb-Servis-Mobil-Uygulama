using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Proje.Core.Model.Entity
{
    public class Device : EntityBase
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Sensor> Sensor { get; set; }
    }
}
