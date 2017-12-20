using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NetCoreLearning.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // 1 create logger
        private readonly ILogger _logger;

        // create logger & logger category 
        //public ValuesController(ILoggerFactory logger)
        //{
        //    _logger = logger.CreateLogger("NetCoreLearning.Controllers.ValuesController");
        //}

        // create logger & logger category 
        //public ValuesController(ILogger<ValuesController> logger)
        //{
        //    _logger = logger;
        //}

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            if (id == 0)
            {
                // logging level
                //_logger.LogWarning(LoggingEvents.GetItemNotFound, "id is invalid.");
            }

            // logging level
            // _logger.LogInformation(LoggingEvents.GetItem, "Get item {id}", id);
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
