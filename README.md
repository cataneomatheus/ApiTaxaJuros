<h2><b>Aplicativo para Cálculo de Juros Compostos</b></h2>

Projeto possuí duas API's ASP.NET Core (Sdk .NET Core 3.1), conforme descrição abaixo:

Api TaxaJuros
Esta API tem como objetivo retornar um valor padrão de "0,01" referente à taxa de juros.

Api CalculoJuros
Esta API tem como objetivo calcular e retornar um valor X de acordo com 3 parâmetros.
(Valor Incial, Valor Taxa (ApiTaxaJuros) e a quantidade de Meses). Também retorna as urls dos projetos no GitHub (url: https://github.com/cataneomatheus/ApiCalculoJuros.git )


<h2><b>Rodar com Docker</b></h2>

<p>Acesse a pasta raíz do projeto ApiCalculoJuros e no terminal e construa a imagem com o seguinte comando:</p>
<p><code>build -t apitaxajuros-image -f Api/Dockerfile .</code></p>

<p>Em seguida rode o container com o seguinte comando:</p>
<code>docker run -it -d -v "$(pwd)\Api".ToLower() -p 5001:80 --rm --name apitaxajuros-container apitaxajuros-image</code>

<h2><b>Api rodando</b></h2>
<p>Se as duas api's estiverem rodando sem problemas basta acessar a Api pelo link abaixo e fazer as requisições:</p></n>
<code>http://localhost:5001/swagger/index.html</code>


<h2><b>Execução dos testes</b></h2>

<p>Abra o projeto com o Visual Studio 2019, clique com o botão direito em cima do projeto de testes, e em seguida clique em "Executar testes".</p></n>
