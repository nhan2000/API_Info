using NguyenNhan_5951071068.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenNhan_5951071068.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/WeatherController
        public IEnumerable<WeatherInfo> Get()
        {

            var weatherInfList = new List<WeatherInfo>();
            for(int i = 0; i < 10; i++)
            {
                var WeatherInfo = new WeatherInfo
                {
                    Location = $"Lovation{i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                weatherInfList.Add(WeatherInfo);
            }
            return weatherInfList;
            
        }

        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                Location = $"Location{id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }

        // GET: api/WeatherController/5
        public string Set(int id)
        {
            return "value";
        }

        // POST: api/WeatherController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WeatherController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WeatherController/5
        public void Delete(int id)
        {
        }
    }
}
