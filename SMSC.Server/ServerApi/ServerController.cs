using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSC.Server;
using SMSC.Server.ServerApi.Models;

namespace SMSC.Server.ServerApi
{
    //[Route("[controller]")]
    //[ApiController]
    public class ServerController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SendMessages([FromBody] PackageDTO packageDto)
        {
            if (ModelState.IsValid)
            {

            }

            return Ok();
        }

        [HttpGet]
        public IActionResult Check()
        {
            return Ok(new { status = "works" });
        }
    }
}