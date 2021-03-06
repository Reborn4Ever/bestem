﻿using System;
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
    [Route("api/ProjectsController")]
    public class ProjectsController : Controller
    {

        private const string NAV_PAGE_NAME = "Projects_ARGGOBEST";
        private readonly NavServiceClientFactory _navServiceClientFactory;

        public ProjectsController(NavServiceClientFactory navServiceClientFactory)
        {
            _navServiceClientFactory = navServiceClientFactory;
        }

        [HttpGet("[action]/{searchName?}")]
        public async Task<IActionResult> List(string searchName = null)
        {

            var serviceRef = _navServiceClientFactory.CreatePageClient<Projects_ARGGOBEST_PortClient, Projects_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Projects_ARGGOBEST_PortClient(binding, address));
            Projects_ARGGOBEST_Filter[] filters = null;
            if (!string.IsNullOrWhiteSpace(searchName))
                if( int.TryParse(searchName, out int n) )
                    filters = new[] { new Projects_ARGGOBEST_Filter { Field = Projects_ARGGOBEST_Fields.Customer_ID, Criteria = "@*" + searchName + "*" }};
                else
                    filters = new[] { new Projects_ARGGOBEST_Filter { Field = Projects_ARGGOBEST_Fields.Project_Title, Criteria = "@*" + searchName + "*" }};

            return Ok((await serviceRef.ReadMultipleAsync(filters, null, 0)).ReadMultiple_Result1);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Save([FromBody] Projects_ARGGOBEST project)
        {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Projects_ARGGOBEST_PortClient, Projects_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Projects_ARGGOBEST_PortClient(binding, address));
            //call create if it's a new record, otherwise call update
            var createProject = string.IsNullOrEmpty(project.Key) ?
                (await serviceRef.CreateAsync(new Create(project))).Projects_ARGGOBEST :
                (await serviceRef.UpdateAsync(new Update(project))).Projects_ARGGOBEST;
            return Ok(createProject);
        }

        [HttpGet("[action]/{projectId}")]
        public async Task<IActionResult> Read(int projectId)
        {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Projects_ARGGOBEST_PortClient, Projects_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Projects_ARGGOBEST_PortClient(binding, address));
            return Ok((await serviceRef.ReadAsync(projectId)).Projects_ARGGOBEST);
        }

       
    }
}
