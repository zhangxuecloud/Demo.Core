using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Demo.Core.ApiServer.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public string Index()
        {
            return "hello" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
        }
    }
}
