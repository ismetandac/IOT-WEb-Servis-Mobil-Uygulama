using Ders.Proje.Core.Model;
using Ders.Proje.Core.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ders.Proje.Web.Api.Controllers
{
    public class UserDataController : ApiController
    {
        public List<MyDevice> Get(int id)
        {
            using (var db = new MyDB())
            {
                var data = db.Device
                    .Include("Sensor")
                    .Include("Sensor.SensorData")
                    .Where(x => x.UserID == id).ToList();
                var js = (from x in data
                          select new MyDevice
                          {
                              ID = x.ID,
                              Name = x.Name,
                              MySensor = (from s in x.Sensor
                                          select new MySensor
                                          {
                                              Name = s.Name,
                                              Value = s.SensorData.LastOrDefault().Value
                                          }).ToList()
                          }).ToList();
                return js;
            }
        }
    }
}
