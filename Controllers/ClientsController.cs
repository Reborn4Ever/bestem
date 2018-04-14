using System.Threading.Tasks;
using ClientsReference;
using Microsoft.AspNetCore.Mvc;
using NgProjectTrackerBEST.Services;

namespace NgProjectTrackerBEST.Controllers {

    [Produces("application/json"), Route("api/ClientsController")]
    public class ClientsController : Controller {

        private const string NAV_PAGE_NAME = "Customers_ARGGOBEST";
        private readonly NavServiceClientFactory _navServiceClientFactory;

        public ClientsController(NavServiceClientFactory navServiceClientFactory) {
            _navServiceClientFactory = navServiceClientFactory;
        }

        [HttpGet("[action]/{searchName?}")]
        public async Task<IActionResult> List(string searchName = null) {

            var serviceRef = _navServiceClientFactory.CreatePageClient<Customers_ARGGOBEST_PortClient, Customers_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Customers_ARGGOBEST_PortClient(binding, address));
            Customers_ARGGOBEST_Filter[] filters = null;
            if(!string.IsNullOrWhiteSpace(searchName))
                filters = new[] {new Customers_ARGGOBEST_Filter{Field = Customers_ARGGOBEST_Fields.Name, Criteria = "@*" + searchName + "*"}};
            return Ok((await serviceRef.ReadMultipleAsync(filters, null, 0)).ReadMultiple_Result1);
        }

        [HttpGet("[action]/{customerNo}")]
        public async Task<IActionResult> Read(string customerNo) {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Customers_ARGGOBEST_PortClient, Customers_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Customers_ARGGOBEST_PortClient(binding, address));
            return Ok((await serviceRef.ReadAsync(customerNo)).Customers_ARGGOBEST);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Save([FromBody] Customers_ARGGOBEST customer) {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Customers_ARGGOBEST_PortClient, Customers_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Customers_ARGGOBEST_PortClient(binding, address));
            //call create if it's a new record, otherwise call update
            var updatedCustomer = string.IsNullOrEmpty(customer.Key) ? 
                (await serviceRef.CreateAsync(new Create(customer))).Customers_ARGGOBEST : 
                (await serviceRef.UpdateAsync(new Update(customer))).Customers_ARGGOBEST;
            return Ok(updatedCustomer);
        }

        [HttpGet("[action]/{customerNo}")]
        public async Task<IActionResult> Delete(string customerNo) {
            var serviceRef = _navServiceClientFactory.CreatePageClient<Customers_ARGGOBEST_PortClient, Customers_ARGGOBEST_Port>(NAV_PAGE_NAME,
                (binding, address) => new Customers_ARGGOBEST_PortClient(binding, address));
            await serviceRef.DeleteAsync(customerNo);
            return Ok();
        }

    }
}
