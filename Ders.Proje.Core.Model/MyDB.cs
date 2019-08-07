using Ders.Proje.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Proje.Core.Model
{
    public class MyDB :DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<SensorData> SensorData { get; set; }
    }
}
