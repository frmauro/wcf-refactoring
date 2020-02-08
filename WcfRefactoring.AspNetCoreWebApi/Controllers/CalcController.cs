using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WcfRefactoring.AspNetCoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase, ICalc
    {
        private readonly ILogger<CalcController> _logger;
        private readonly ICalc _calc;

        public CalcController(ILogger<CalcController> logger, ICalc calc)
        {
            _logger = logger;
            _calc = calc;
        }


        [HttpGet]
        public string HellowWorld() => "Up and Running";

        [HttpPost]
        public int Sum([FromForm] int part1, [FromForm] int part2)
        {
            return this._calc.Sum(part1, part2);
        }
    }
}
