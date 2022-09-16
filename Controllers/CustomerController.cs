using ExtraedgeAssignment.Models;
using ExtraedgeAssignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        [Route("GetAllCustomer")]
        public IActionResult GetAllCustomer()
        {
            return new ObjectResult(_service.GetAllCustomer());
        }

        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            return new ObjectResult(_service.GetCustomerById(id));
        }


        // POST api/<CustomerController>
        [HttpPost]
        [Route("AddCustomer")]
        public int AddCustomer([FromBody] Customer cust)
        {
            return _service.AddCustomer(cust);
        }

        [HttpPost]
        [Route("ModifyCustomer")]
        public int ModifyCustomer([FromBody] Customer cust)
        {
            return _service.ModifyCustomer(cust);
        }


        // DELETE api/<CustomerController>/5
        [HttpGet]
        [Route("DeleteCustomer/{id}")]
        public int DeleteCustomer(int id)
        {
            return _service.DeleteCustomer(id);
        }
    }
}
