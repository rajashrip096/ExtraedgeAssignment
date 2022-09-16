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
    public class MobileBrandController : ControllerBase
    {
        private readonly IMobileBrandService _mobilebrandservice;
        public MobileBrandController(IMobileBrandService mobilebrandservice)
        {
            _mobilebrandservice = mobilebrandservice;
        }
        [HttpGet]

        [Route("GetMobileBrand")]
        public IActionResult GetMobileBrand()
        {
            return new ObjectResult(_mobilebrandservice.GetAllMobileBrand());
            // test code
        }
        [HttpPost]
        [Route("AddMobileBrand")]
        public IActionResult AddMobileBrand(MobileBrand mobilebrand)
        {
            return new ObjectResult(_mobilebrandservice.AddMobileBrand(mobilebrand));
        }

        [HttpPost]
        [Route("ModifyMobileBrand")]
        public IActionResult ModifyMobileBrand(MobileBrand mobilebrand)
        {
            return new ObjectResult(_mobilebrandservice.ModifyMobileBrand(mobilebrand));
        }

        [HttpGet]
        [Route("DeleteMobileBrand/{id}")]
        public IActionResult DeleteMobileBrand(int id)
        {
            return new ObjectResult(_mobilebrandservice.DeleteMobileBrand(id));
        }

    }
}
