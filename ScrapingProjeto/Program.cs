using DataAccess;
using DataAccess.Models;
using MonitoresScraping;
using Newtonsoft.Json;



class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        String mongoDBConnectionString = "mongodb://localhost:27017";
        String databaseName = "MonitoresDB";
        String collectionName = "MonitoresCollection";

        string url = "https://i.chipart.openk.com.br/pesquisa?f_departamento=monitores&f_secao=monitores&page={0}";

        using HttpClientHandler handler = new HttpClientHandler
        {

        };

        using HttpClient client = new HttpClient(handler);
        MongoDBServices mongoDBServices = new MongoDBServices(mongoDBConnectionString, databaseName, collectionName);

        try
        {

            String urlPage = string.Format(url, 1); // Alterar o número da página conforme necessário

            string jsonResponse = await client.GetStringAsync(urlPage);

            ChipArtObject myDeserializedClass = JsonConvert.DeserializeObject<ChipArtObject>(jsonResponse);

            int numPaginas = myDeserializedClass.quantidade_paginas;

            List<ProductObject> productObjects = new();

            for (int num = 1; num <= numPaginas; num++)
            {

                urlPage = string.Format(url, num);
                jsonResponse = await client.GetStringAsync(urlPage);
                myDeserializedClass = JsonConvert.DeserializeObject<ChipArtObject>(jsonResponse);

                foreach (Produto produto in myDeserializedClass.produtos)
                {
                    ProductObject productObject = CreateProductObject(produto);

                    if (productObject != null)
                    {
                        productObjects.Add(productObject);
                    }
                }

            }

            await mongoDBServices.InsertProductsAsync(productObjects);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }



    }

    private static ProductObject CreateProductObject(Produto produto)
    {

        return new ProductObject
        {
            nomeProduto = produto.nomeProduto,
            linkProduto = produto.linkProduto,
            precoDe = produto.precoDe,
            precoVenda = produto.precoVenda,
            precoVendaBoleto = produto.precoVendaBoleto,
            quantidadeParcelas = produto.quantidadeParcelas,
            valorParcela = produto.valorParcela,
            juros = produto.juros,
            comEstoque = produto.comEstoque,
            nomeMarca = produto.nomeMarca,
            nomeFabricante = produto.nomeFabricante,
            mediaAvaliacao = produto.mediaAvaliacao,
            data_fim_campanha = produto.data_fim_campanha,
            oferta_relampago = produto.oferta_relampago
        };
    }

}

