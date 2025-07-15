
---

## 🖥️ ScrapingMonitores

Projeto de scraping que coleta informações sobre **monitores disponíveis em sites de e-commerce** e armazena os dados estruturados em um banco de dados **MongoDB**.

Atualmente, o projeto suporta:

* ✅ **ChipArt**
* ✅ **Kabum**

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

| Projeto           | Função                                                                                                     |
| ----------------- | ---------------------------------------------------------------------------------------------------------- |
| `ChipArtScraping` | Responsável por fazer o scraping da ChipArt, deserializar os dados e mapear os produtos para persistência. |
| `KabumMonitores`  | Responsável por coletar produtos da Kabum com suporte à paginação dinâmica.                                |
| `DataAccess`      | Contém os modelos (`ProductObject`) e serviços de acesso ao banco (`MongoDBServices`).                     |

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

2. Instale os pacotes NuGet necessários (caso não estejam instalados):

   * `MongoDB.Driver`
   * `Newtonsoft.Json`

3. Altere a **string de conexão MongoDB** (se necessário):

```csharp
string mongoDBConnectionString = "mongodb://localhost:27017";
```

4. Execute o projeto desejado:

```bash
# Para scraping da ChipArt:
dotnet run --project ChipArtScraping

# Para scraping da Kabum:
dotnet run --project KabumMonitores
```

---

### 🧾 Exemplo de Objeto Extraído (Kabum)

```json
{
  "nomeProduto": "Monitor Gamer 24’ LG UltraGear",
  "linkProduto": "https://kabum.com.br/monitor/12345",
  "precoDe": 1499.90,
  "precoVenda": 1299.90,
  "comEstoque": true,
  "mediaAvaliacao": 4.7
}
```

---

### 🧠 Organização das Classes

* `ChipArtObject`, `KabumObject`, `Produto`, `Datum`, `ProductObject`: representam a estrutura de resposta JSON de cada loja.
* `MongoDBServices`: responsável por persistir os dados.
* `Program.cs`: orquestra a chamada HTTP, deserialização, paginação (Kabum) e salvamento no banco.

---

### 📌 Melhorias Futuras

* [ ] Adicionar tratamento para falhas de conexão
* [ ] Agendamento com **Hangfire** ou **Quartz.NET**
* [ ] Exportação para Excel/CSV
* [ ] Interface gráfica para consulta dos dados extraídos
* [ ] Suporte para scraping de outras categorias (ex: placas de vídeo, notebooks)

---

### 👨‍💻 Autor

**Pedro-2077**

🔗 [GitHub](https://github.com/Pedro-2077)
📬 Entre em contato para colaborações ou sugestões!

---

### 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
