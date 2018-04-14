using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectsReference;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NgProjectTrackerBEST.Services;

namespace NgProjectTrackerBEST.Controllers
{
    [Produces("application/json")]
    [Route("api/Projects")]
    public class ProjectsController : Controller
    {

        private const string NAV_PAGE_NAME = "Projects_ARGGOBEST";
        private readonly NavServiceClientFactory _navServiceClientFactory;

        public ProjectsController(NavServiceClientFactory navServiceClientFactory)
        {
            _navServiceClientFactory = navServiceClientFactory;
        }

        // GET: api/Projects
        [HttpGet("[action]/{searchName?}")]
        public async Task<IActionResult> List(string searchName = null)
        {

            var serviceRef = _navServiceClientFactory.CreatePageClient<Projects_ARGGOBEST_PortClient, Projects_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Projects_ARGGOBEST_PortClient(binding, address));
            Projects_ARGGOBEST_Filter[] filters = null;
            if (!string.IsNullOrWhiteSpace(searchName))
                filters = new[] { new Projects_ARGGOBEST_Filter { Field = Projects_ARGGOBEST_Fields.Project_Title, Criteria = "@*" + searchName + "*" } };
            return Ok((await serviceRef.ReadMultipleAsync(filters, null, 0)).ReadMultiple_Result1);
        }

        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET: api/Projects/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Projects
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
