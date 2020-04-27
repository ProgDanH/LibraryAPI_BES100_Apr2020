using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    public class StatusController : Controller
    {
        [HttpGet("/status")]
        public ActionResult GetStatus()
        {
            StatusResponse sr = new StatusResponse
            {
                Msg = "Send a message basic text",
                CheckedBy = "Joe Blowmedown",
                LastChecked = DateTime.Now
            };
            return Ok(sr);
        }
    }
    public class StatusResponse
    {
        public string Msg { get; set; }
        public string CheckedBy { get; set; }
        public DateTime LastChecked { get; set; }
    }
}