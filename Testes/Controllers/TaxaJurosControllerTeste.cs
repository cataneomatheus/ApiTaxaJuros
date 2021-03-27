using Api.Controllers.TaxaJuros;
using Xunit;

namespace ApiTaxaJuros.Testes.Controllers
{
    public class TaxaJurosControllerTeste
    {
        [Fact]
        public void TaxaPadraoDeveRetornar1()
        {
            var taxaJurosController = new TaxaJuroController();
            var valorAtual = taxaJurosController.GetTaxa();

            Assert.Equal(0.01m, valorAtual);
        }
    }
}
