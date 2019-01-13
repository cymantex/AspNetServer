using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetServer.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/username
        [HttpGet("{username}", Name = "Get")]
        public string Get(int id) {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value) {

        }

        // PUT: api/User/username
        [HttpPut("{username}")]
        public void Put(int id, [FromBody] string value) {

        }

        // DELETE: api/User/username
        [HttpDelete("{username}")]
        public void Delete(int id) {
        }
    }
}
