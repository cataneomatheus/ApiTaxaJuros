using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers.TaxaJuro
{
    [Route("TaxaJuro")]
    public class TaxaJuroController : ControllerBase
    {
        [HttpGet]
        public double GetTaxa()
        {
            return 0.01;
        }
    }
}
