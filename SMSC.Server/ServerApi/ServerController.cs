using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSC.Domain;
using SMSC.Domain.Objects;
using SMSC.Server;

namespace SMSC.Server.ServerApi
{
    //[Route("[controller]")]
    //[ApiController]

    public class ServerController : ControllerBase
    {
        public ServerController()
        {

        }

        [Produces("application/xml")]
        [HttpPost]
        public async Task<IActionResult> SendMessages([FromBody] PackageRequest packageRequest)
        {
            if (ModelState.IsValid)
            {
                var res = new PackageResponse
                {
                    Send = new List<ResponseMsg>
                    {
                        new ResponseMsg { Id=1, MsgErrorCode="test" },
                        new ResponseMsg { Id=2, ServerId="1", Value="test" }
                    }
                };

                return Ok(res);
            }

            return BadRequest(ErrorResponse.GetError(ErrorCodes.BAD_XML));
        }

        [HttpGet]
        public IActionResult Check()
        {
            return Ok(new { status = "works" });
        }
    }
}