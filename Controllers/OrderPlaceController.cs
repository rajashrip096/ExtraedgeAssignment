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
    public class OrderPlaceController : ControllerBase
    {
        private readonly IOrderPlaceService _service;
        public OrderPlaceController(IOrderPlaceService service)
        {
            _service = service;
        }
        // GET: api/<OrderPlaceController>
        [HttpGet]
        [Route("GetAllOrderPlace")]
        public IActionResult GetAllOrderPlace()
        {
            return new ObjectResult(_service.GetAllOrderPlace());
        }

        [HttpGet]
        [Route("GetOrderPlaceById/{id}")]
        public IActionResult GetOrderPlaceById(int id)
        {
            return new ObjectResult(_service.GetOrderPlaceById(id));
        }


        // POST api/<OrderPlaceController>
        [HttpPost]
        [Route("AddOrderPlace")]
        public int AddOrderPlace([FromBody] OrderPlace orderplace)
        {
            return _service.AddOrderPlace(orderplace);
        }

        [HttpPost]
        [Route("ModifyOrderPlace")]
        public int ModifyOrderPlace([FromBody] OrderPlace orderplace)
        {
            return _service.ModifyOrderPlace(orderplace);
        }


        // DELETE api/<OrderPlaceController>/5
        [HttpGet]
        [Route("DeleteOrderPlace/{id}")]
        public int DeleteOrderPlace(int id)
        {
            return _service.DeleteOrderPlace(id);
        }
    }
}
