using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aikido.Application.Uke.Interfaces;

namespace Aikido.WebAPI.Uke.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UkeController : ControllerBase
    {
        private readonly IDoAtemi _uke;
        public UkeController(IDoAtemi uke)
        {
            _uke = uke;
        }
        // GET uke
        [HttpGet]
        public ActionResult<string> Get()
        {
            var atemiModel = _uke.ExecuteAtemi();
            return atemiModel.ToString();
        }
    }
}
