using TesteIntegracao.Acessorios;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace TesteIntegracao.Testes
{
    public class TaxaJurosTeste
    {        
        private readonly TesteContexto _testeContexto;
        private readonly string _controller = "/taxajuros";

        public TaxaJurosTeste()
        {
            _testeContexto = new TesteContexto();
        }

        [Fact]
        public async Task TaxaPadraoRespostaSucesso()
        {
            var response = await _testeContexto.Client.GetAsync(_controller);

            response.EnsureSuccessStatusCode();

            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task TaxaPadraoDeveRetornar1()
        {
            var response = await _testeContexto.Client.GetAsync(_controller);

            response.EnsureSuccessStatusCode();

            var valorAtual = await JsonSerializer.DeserializeAsync<decimal>(await response.Content.ReadAsStreamAsync());

            Assert.Equal(0.01m, valorAtual);
        }
    }
}
