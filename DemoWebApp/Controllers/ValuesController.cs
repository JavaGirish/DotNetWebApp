using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebApp.Controllers
{
    public class ValuesController : ApiController
    {
        IList<string> listData = new List<string>()
        {
            "value1", "value2","value3"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return listData;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return listData[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            listData.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            listData[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            listData.RemoveAt(id);

        }
    }
}
