using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> lists = new List<string> {
            "Value0","Value1","Value2"
            };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return lists;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return lists[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            lists.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            lists[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            lists.RemoveAt(id);
        }
    }
}
