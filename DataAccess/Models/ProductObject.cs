using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace DataAccess.Models
{
    public class ProductObject
    {

        [BsonId]
        public ObjectId Id { get; set; }

        public string nomeProduto { get; set; }

        public string linkProduto { get; set; }

        public double precoDe { get; set; }

        public double precoVenda { get; set; }

        public double precoVendaBoleto { get; set; }

        public int quantidadeParcelas { get; set; }

        public double valorParcela { get; set; }

        public double juros { get; set; }

        public bool comEstoque { get; set; }

        public string nomeMarca { get; set; }

        public string nomeFabricante { get; set; }

        public int mediaAvaliacao { get; set; }

        public string data_fim_campanha { get; set; }

        public bool oferta_relampago { get; set; }

    }
}
