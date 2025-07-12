namespace MonitoresScraping
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Banner
    {
        public string altura { get; set; }
        public string extensao { get; set; }
        public string largura { get; set; }
        public int ordem { get; set; }
        public int tipoLocal { get; set; }
        public string urlArquivo { get; set; }
        public string urlDestino { get; set; }
    }

    public class FiltrosSelecionado
    {
        public string nome { get; set; }
        public string url { get; set; }
        public string url_amigavel { get; set; }
    }

    public class Item
    {
        public string url { get; set; }
        public string url_amigavel { get; set; }
        public int resultados { get; set; }
        public string nome { get; set; }
    }

    public class OrdenacoesDisponivei
    {
        public string nome { get; set; }
        public string campos { get; set; }
        public string url { get; set; }
        public string url_amigavel { get; set; }
    }

    public class Produto
    {
        public string codigoSku { get; set; }

        //ProdutoNome
        public string nomeProduto { get; set; }
        public string imagemProduto { get; set; }
        public string codigoReferenciaProduto { get; set; }

        //ProdutoLink
        public string linkProduto { get; set; }

        //ProdutoPreco
        public double precoDe { get; set; }
        public string precoDeFormatado { get; set; }

        //ProdutoPrecoVenda
        public double precoVenda { get; set; }
        public string precoVendaFormatado { get; set; }

        //ProdutoPrecoVendaBoleto
        public double precoVendaBoleto { get; set; }
        public string precoVendaBoletoFormatado { get; set; }

        //Quantidade de Parcelas
        public int quantidadeParcelas { get; set; }

        //Valor da Parcela
        public double valorParcela { get; set; }
        public string valorParcelaFormatado { get; set; }

        //Jursos
        public double juros { get; set; }

        //Estoque
        public bool comEstoque { get; set; }
        public string nomeCategoria { get; set; }

        //Nome da Marca
        public string nomeMarca { get; set; }

        //Marca Fabricante
        public string nomeFabricante { get; set; }

        //Media de Avaliação
        public int mediaAvaliacao { get; set; }
        public object selos { get; set; }
        public bool lancamento { get; set; }
        public DateTime data_lancamento { get; set; }
        public int campanha_id { get; set; }
        public string descricao_campanha { get; set; }

        // Data Fim da Campanha
        public string data_fim_campanha { get; set; }

        //Oferta Relâmpago
        public bool oferta_relampago { get; set; }
    }

    public class Refinamento
    {
        public string titulo { get; set; }
        public List<Item> items { get; set; }
    }

    public class ChipArtObject
    {
        public bool sucesso { get; set; }
        public string meta_tag_title { get; set; }
        public string meta_tag_abstract { get; set; }
        public string meta_tag_keyword { get; set; }
        public string meta_tag_description { get; set; }
        public string texto_apoio { get; set; }
        public List<string> historico { get; set; }
        public string titulo_pagina { get; set; }
        public List<Banner> banners { get; set; }
        public List<object> refinamentos_por_intervalo { get; set; }
        public List<Refinamento> refinamentos { get; set; }
        public List<object> termos_relacionados { get; set; }
        public List<object> outros_termos { get; set; }
        public List<OrdenacoesDisponivei> ordenacoes_disponiveis { get; set; }
        public int total_encontrado { get; set; }
        public int total_exibindo { get; set; }
        public List<FiltrosSelecionado> filtros_selecionados { get; set; }
        public bool busca_sugestiva { get; set; }
        public List<Produto> produtos { get; set; }
        public string url_pagina_anterior { get; set; }
        public string url_pagina_anterior_amigavel { get; set; }
        public int numero_pagina_atual { get; set; }
        public string url_ultima_pagina { get; set; }
        public string url_ultima_pagina_amigavel { get; set; }
        public string url_proxima_pagina { get; set; }
        public string url_proxima_pagina_amigavel { get; set; }
        public int quantidade_paginas { get; set; }
    }


}
