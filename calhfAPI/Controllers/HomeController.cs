using calhfAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace calhfAPI.Controllers
{
    private CalhfContext _dbContext;

    public HomeController(calhfContext

    [Route("api/[controller")]
    [ApiController]

    public class HomeController : ControllerBase
    {
        [HttpGet("StatusCode")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("CreateTable")]
        
        public IActionResult Create()
        {
            return Ok();         
        }

    
    }



}
