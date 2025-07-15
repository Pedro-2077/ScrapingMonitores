using DataAccess;
using DataAccess.Models;
using KabomMonitores;
using Newtonsoft.Json;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string mongoDBConnectionString = "mongodb://localhost:27017";
        string databaseName = "MonitoresDB";
        string collectionName = "MonitoresCollection";
        string baseUrl = "https://www.kabum.com.br/computadores/monitores/monitor-gamer?page_number={0}&page_size=20&facet_filters=&sort=most_searched";

        using HttpClientHandler handler = new HttpClientHandler();
        using HttpClient client = new HttpClient(handler);

        MongoDBServices mongoDBServices = new MongoDBServices(mongoDBConnectionString, databaseName, collectionName);

        try
        {
            List<ProductObject> todosProdutos = new List<ProductObject>();

            // Primeira página
            string html = await client.GetStringAsync(string.Format(baseUrl, 1));

            string trechoBruto = ExtrairTrecho(html, "\"data\":\"{", "\"},\"__N_SSP\"");
            string tratado = trechoBruto.Replace("\\\\", "\\").Replace("\\\"", "\"");
            tratado = "{" + tratado;

            KabumObject primeiraPagina = JsonConvert.DeserializeObject<KabumObject>(tratado);
            var produtosPagina = primeiraPagina.catalogServer.data;
            var numPaginas = primeiraPagina.catalogServer.pagination.total;

            foreach (var produto in produtosPagina)
                todosProdutos.Add(CreateProductObject(produto));

            // Demais páginas (2 até numPaginas)
            for (int i = 2; i <= numPaginas; i++)
            {
                Console.WriteLine($"Coletando página {i} de {numPaginas}...");
                string paginaHtml = await client.GetStringAsync(string.Format(baseUrl, i));

                string trecho = ExtrairTrecho(paginaHtml, "\"data\":\"{", "\"},\"__N_SSP\"");
                string jsonTratado = trecho.Replace("\\\\", "\\").Replace("\\\"", "\"");
                jsonTratado = "{" + jsonTratado;

                KabumObject pagina = JsonConvert.DeserializeObject<KabumObject>(jsonTratado);
                var produtos = pagina.catalogServer.data;

                foreach (var produto in produtos)
                    todosProdutos.Add(CreateProductObject(produto));

                await Task.Delay(1000); // Respeitar o servidor
            }

            // Inserir todos no MongoDB
            await mongoDBServices.InsertProductsAsync(todosProdutos);
            Console.WriteLine($"Total de produtos inseridos: {todosProdutos.Count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }

    public static string ExtrairTrecho(string html, string inicio, string fim)
    {
        if (string.IsNullOrEmpty(html) || string.IsNullOrEmpty(inicio) || string.IsNullOrEmpty(fim))
            return string.Empty;

        int indiceInicio = html.IndexOf(inicio);
        if (indiceInicio == -1)
            return string.Empty;

        indiceInicio += inicio.Length;
        int indiceFim = html.IndexOf(fim, indiceInicio);
        if (indiceFim == -1)
            return string.Empty;

        return html.Substring(indiceInicio, indiceFim - indiceInicio);
    }

    private static ProductObject CreateProductObject(Datum produto)
    {
        return new ProductObject
        {
            nomeProduto = produto.name,
            linkProduto = produto.externalUrl,
            precoDe = produto.price,
            precoVenda = produto.priceMarketplace,
            comEstoque = produto.available,
            mediaAvaliacao = produto.rating,
        };
    }
}
