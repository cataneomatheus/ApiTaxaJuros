using Dominio.TaxaJuros;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.TaxaJuros
{
    [Route("TaxaJuro")]
    public class TaxaJuroController : ControllerBase
    {
        [HttpGet]
        public decimal GetTaxa()
        {
            return new TaxaJuro().Taxa;
        }
    }
}
