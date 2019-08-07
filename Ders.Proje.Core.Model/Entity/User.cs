using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Proje.Core.Model.Entity
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gsm { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }
}
