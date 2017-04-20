using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.Controllers
{
    public class DummyController : Controller
    {
        private HRContext _ctx;

        public DummyController(HRContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
