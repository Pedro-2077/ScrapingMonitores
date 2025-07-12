---

## 🖥️ ScrapingMonitores

Projeto de scraping que coleta informações sobre **monitores disponíveis no site da ChipArt** e armazena os dados estruturados em um banco de dados **MongoDB**.

---

### 🚀 Objetivo

Este projeto foi desenvolvido com o objetivo de automatizar a coleta de dados sobre produtos do tipo **monitor**, incluindo:

* Preço à vista, parcelado e via boleto
* Avaliação média
* Estoque
* Marca e fabricante
* Informações de campanha promocional
* Link e nome do produto

---

### 🧱 Estrutura do Projeto

| Projeto           | Função                                                                                                                 |
| ----------------- | ---------------------------------------------------------------------------------------------------------------------- |
| `ChipArtScraping` | Responsável por fazer o scraping do site, deserializar os dados em objetos C#, e mapear os produtos para persistência. |
| `DataAccess`      | Contém os modelos (`ProductObject`) e serviços de acesso ao banco (`MongoDBServices`).                                 |

---

### 📦 Tecnologias Utilizadas

* **.NET 6.0+**
* **MongoDB**
* **HttpClient** – Para requisições HTTP
* **Newtonsoft.Json** – Para deserialização de JSON
* **MongoDB.Driver** – Para integração com o banco

---

### 🛠️ Como Executar o Projeto

> Certifique-se de ter o **MongoDB** rodando localmente ou forneça a string de conexão correta.

1. Clone este repositório:

```bash
git clone https://github.com/Pedro-2077/ScrapingMonitores.git
cd ScrapingMonitores
```

2. Instale os pacotes NuGet necessários (caso não esteja configurado):

   * `MongoDB.Driver`
   * `Newtonsoft.Json`

3. Altere a **string de conexão MongoDB** (se necessário):

```csharp
String mongoDBConnectionString = "mongodb://localhost:27017";
```

4. Compile e execute o projeto:

```bash
dotnet build
dotnet run --project ChipArtScraping
```

---

### 🧾 Exemplo de Objeto Extraído

```json
{
  "nomeProduto": "Monitor Gamer 24’ LG UltraGear",
  "linkProduto": "https://chipart.com.br/monitor/12345",
  "precoDe": 1499.90,
  "precoVenda": 1299.90,
  "precoVendaBoleto": 1249.90,
  "quantidadeParcelas": 10,
  "valorParcela": 129.99,
  "juros": 0.0,
  "comEstoque": true,
  "nomeMarca": "LG",
  "nomeFabricante": "LG Eletronics",
  "mediaAvaliacao": 5,
  "data_fim_campanha": "2025-12-31",
  "oferta_relampago": false
}
```

---

### 🧠 Organização das Classes

* `Produto`, `ChipArtObject`, `Banner`, `Refinamento`: modelos para representar a estrutura de resposta JSON da API da ChipArt.
* `ProductObject`: modelo utilizado no MongoDB.
* `MongoDBServices`: responsável por persistir os dados.
* `Program.cs`: orquestra a chamada HTTP, deserialização e salvamento dos dados.

---

### 📌 Melhorias Futuras

* [ ] Adicionar tratamento para falhas de conexão
* [ ] Agendamento com **Hangfire** ou **Quartz.NET**
* [ ] Exportação para Excel/CSV
* [ ] Interface gráfica para consulta dos dados extraídos

---

### 👨‍💻 Autor

**Pedro-2077**

🔗 [GitHub](https://github.com/Pedro-2077)
📬 Entre em contato para colaborações!

---

### 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
