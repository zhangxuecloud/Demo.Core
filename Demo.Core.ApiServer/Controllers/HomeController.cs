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

        /// <summary>
        /// 首页   
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Index()
        {
            return "Hello World：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
        }
    }
}
