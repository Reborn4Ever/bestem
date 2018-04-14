using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksReference;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NgProjectTrackerBEST.Services;

namespace NgProjectTrackerBEST.Controllers
{
    [Produces("application/json")]
    [Route("api/TasksController")]
    public class TasksController : Controller
    {

        private const string NAV_PAGE_NAME = "Task_ARGGOBEST";
        private readonly NavServiceClientFactory _navServiceClientFactory;

        public TasksController(NavServiceClientFactory navServiceClientFactory)
        {
            _navServiceClientFactory = navServiceClientFactory;
        }

        [HttpGet("[action]/{searchName?}")]
        public async Task<IActionResult> List(string searchName = null)
        {

            var serviceRef = _navServiceClientFactory.CreatePageClient<Task_ARGGOBEST_PortClient, Task_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Task_ARGGOBEST_PortClient(binding, address));
            Task_ARGGOBEST_Filter[] filters = null;
            if (!string.IsNullOrWhiteSpace(searchName))
                filters = new[] { new Task_ARGGOBEST_Filter { Field = Task_ARGGOBEST_Fields.Task_Title, Criteria = "@*" + searchName + "*" } };

            return Ok((await serviceRef.ReadMultipleAsync(filters, null, 0)).ReadMultiple_Result1);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Save([FromBody] Task_ARGGOBEST task)
        {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Task_ARGGOBEST_PortClient, Task_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Task_ARGGOBEST_PortClient(binding, address));
            //call create if it's a new record, otherwise call update
            var createTask = string.IsNullOrEmpty(task.Key) ?
                (await serviceRef.CreateAsync(new Create(task))).Task_ARGGOBEST :
                (await serviceRef.UpdateAsync(new Update(task))).Task_ARGGOBEST;
            return Ok(createTask);
        }

        [HttpGet("[action]/{taskId}")]
        public async Task<IActionResult> Read(int taskId)
        {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Task_ARGGOBEST_PortClient, Task_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Task_ARGGOBEST_PortClient(binding, address));
            return Ok((await serviceRef.ReadAsync(taskId)).Task_ARGGOBEST);
        }


    }
}
