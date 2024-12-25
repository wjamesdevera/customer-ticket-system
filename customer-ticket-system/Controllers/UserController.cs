using customer_ticket_system.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace customer_ticket_system.Controllers
{
    public class UserController : ApiController
    {

        [HttpGet]
        [Route("")]
        public IHttpActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Login([FromBody] User loggingUser)
        {
            if (loggingUser == null)
            {
                return BadRequest();
            }
            return Ok(new { status = "success", data = ""});
        }
    }
}
