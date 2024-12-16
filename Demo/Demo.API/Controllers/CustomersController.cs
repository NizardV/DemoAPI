using Demo.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.BL;

namespace Demo.API.Controllers
{
    /// <summary>
    /// Customers controller
    /// </summary>
    public class CustomersController : Controller
    {
        private readonly IService _service;

        public CustomersController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public CustomerLight GetLastCustomer(int id)
        {
            var customer = _service.GetCustomer(id);
            return customer;
        }
    }
}
