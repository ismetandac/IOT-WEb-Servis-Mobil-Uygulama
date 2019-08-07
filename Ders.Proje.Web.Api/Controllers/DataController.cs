using Ders.Proje.Core.Model;
using Ders.Proje.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ders.Proje.Web.Api.Controllers
{
    public class DataController : ApiController
    {
        /// <summary>
        /// Cihazdan Verileri almak için yazıldı
        /// </summary>
        /// <param name="sensorType">sensor tipi</param>
        /// <param name="key">cihaz key</param>
        /// <param name="value">sensor data</param>
        [HttpPost]
        public bool Post(_SensorType sensorType, string key, string value)
        {
            try
            {
                using (var db = new MyDB())
                {
                    var device = db.Device.Include("Sensor").Where(x => x.Key == key).FirstOrDefault();
                    var sensorID = device.Sensor.Where(x => x.SensorType == sensorType).FirstOrDefault().ID;
                    db.SensorData.Add(new SensorData
                    {
                        SensorID = sensorID,
                        Value = value
                    });
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
