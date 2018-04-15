using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksLogReference;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NgProjectTrackerBEST.Services;

namespace NgProjectTrackerBEST.Controllers
{
    [Produces("application/json")]
    [Route("api/TasksLogController")]
    public class TasksLogController : Controller
    {

        private const string NAV_PAGE_NAME = "Task_Logs_ARGGOBEST";
        private readonly NavServiceClientFactory _navServiceClientFactory;

        public TasksLogController(NavServiceClientFactory navServiceClientFactory)
        {
            _navServiceClientFactory = navServiceClientFactory;
        }

        [HttpGet("[action]/{searchName?}")]
        public async Task<IActionResult> List(string searchName = null)
        {

            var serviceRef = _navServiceClientFactory.CreatePageClient<Task_Logs_ARGGOBEST_PortClient, Task_Logs_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Task_Logs_ARGGOBEST_PortClient(binding, address));
            Task_Logs_ARGGOBEST_Filter[] filters = null;
            if (!string.IsNullOrWhiteSpace(searchName))
                filters = new[] { new Task_Logs_ARGGOBEST_Filter { Field = Task_Logs_ARGGOBEST_Fields.Task_Log_Title, Criteria = "@*" + searchName + "*" } };

            return Ok((await serviceRef.ReadMultipleAsync(filters, null, 0)).ReadMultiple_Result1);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Save([FromBody] Task_Logs_ARGGOBEST project)
        {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Task_Logs_ARGGOBEST_PortClient, Task_Logs_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Task_Logs_ARGGOBEST_PortClient(binding, address));
            //call create if it's a new record, otherwise call update
            var createProject = string.IsNullOrEmpty(project.Key) ?
                (await serviceRef.CreateAsync(new Create(project))).Task_Logs_ARGGOBEST :
                (await serviceRef.UpdateAsync(new Update(project))).Task_Logs_ARGGOBEST;
            return Ok(createProject);
        }

        [HttpGet("[action]/{TasksLogId}")]
        public async Task<IActionResult> Read(int TasksLogId)
        {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Task_Logs_ARGGOBEST_PortClient, Task_Logs_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Task_Logs_ARGGOBEST_PortClient(binding, address));
            return Ok((await serviceRef.ReadAsync(TasksLogId)).Task_Logs_ARGGOBEST);
        }


    }
}
