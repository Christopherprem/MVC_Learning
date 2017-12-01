using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNetLearning.Controllers
{
    public class AEWRAController : ApiController    ///Api Controller with empty read/write action
    {
        // GET api/aewra
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/aewra/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/aewra
        public void Post([FromBody]string value)
        {
        }

        // PUT api/aewra/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/aewra/5
        public void Delete(int id)
        {
        }
    }
}
