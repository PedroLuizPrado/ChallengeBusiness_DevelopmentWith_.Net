# 📌 Sprint03 - Redução de Sinistros Odontológicos com Visão Computacional 🦷

## 👥 Integrantes do Grupo

* **Murillo Ferreira Ramos** - RM553315
* **Pedro Luiz Prado** - RM553874
* **William Kenzo Hayashi** - RM552659

## 📖 Visão Geral do Projeto

O objetivo central do projeto é desenvolver uma API utilizando .NET para auxiliar na **redução de sinistros odontológicos** por meio da análise de dados e visão computacional. Essa API servirá como base para armazenar e gerenciar dados dos usuários, garantindo **segurança, eficiência e escalabilidade** na aplicação.

## 💡 Arquitetura Escolhida

Optamos por uma **arquitetura monolítica** devido a:

1. **Familiaridade da Equipe**: A abordagem monolítica é mais compreendida pelos integrantes, agilizando o desenvolvimento.
2. **Adequação ao Escopo do Projeto**: Sendo uma API específica para um propósito definido, a necessidade de microservices não se justifica.
3. **Facilidade de Manutenção e Depuração**: A centralização da aplicação permite um controle mais eficiente de erros e atualizações.
4. **Gerenciamento de Banco de Dados Simplificado**: Um único banco centralizado facilita o desenvolvimento e as migrações.

## ⚙️ Funcionalidades Implementadas

* **Estrutura em Camadas**:

  * `Domain`: Define as entidades do sistema.
  * `Infrastructure`: Gerencia repositórios e a conexão com o banco de dados.
  * `Presentation`: Contém os controladores e endpoints da API.

* **Banco de Dados**:

  * Implementação do **Entity Framework Core**.
  * Uso do banco **Oracle** para armazenar os dados dos usuários.

* **Integração com API Externa (CDC)**:

  * A API pública utilizada é a **CDC Open Data API**, especificamente o dataset sobre **saúde bucal em adultos nos Estados Unidos**. Essa base de dados contém informações coletadas por meio do sistema **BRFSS (Behavioral Risk Factor Surveillance System)** e é mantida pelos **Centers for Disease Control and Prevention (CDC)**.

  📊 **O que essa API fornece:**

  * Ano da coleta (`year`)
  * Faixa etária (`category`)
  * Indicador de saúde bucal (`indicator`)
  * Valor percentual (`data_value`)
  * Fonte da amostragem (`samplesize`)
  * Quebra por categorias como raça, sexo e região

  📅 **Período dos Dados:**

  * **Ano inicial:** 2016

  * **Ano mais recente:** 2020

  * Consumo da [CDC Open Data API](https://data.cdc.gov)

  * Filtros por ano e categoria etária

  * Recomendador de tempo de visita ao dentista por idade

* **Middleware de Exceções**:

  * Captura erros da aplicação e retorna resposta JSON amigável
  * Log com `ILogger`

* **Testes Unitários com xUnit + Moq**:

  * Testes para `CdcApiService` e `CdcController`

* **Boas Práticas**:

  * Princípios SOLID
  * Clean Code
  * Inversão de dependência com interfaces

## 🚀 Como Executar a API

### 📌 Pré-requisitos

* .NET 8.0 instalado
* Banco de Dados Oracle configurado
* Visual Studio 2022 ou superior

### 🔧 Execução

```bash
# Aplicar as migrações
> dotnet ef migrations add InicialNovaEstrutura
> dotnet ef database update

# Rodar a API
> dotnet run
```

### 🔍 Documentação Swagger

> Acesse [https://localhost:7005/swagger](https://localhost:7005/swagger)

## 🔄 Endpoints da API

### 📌 Usuários CRUD

* POST `/api/nomeusuarios`
* GET `/api/nomeusuarios`
* GET `/api/nomeusuarios/{id}`
* PUT `/api/nomeusuarios/{id}`
* DELETE `/api/nomeusuarios/{id}`

### 🔍 CDC - Integração externa

* GET `/api/cdc/dados-dentais`
* GET `/api/cdc/comparar?year=2020&category=Adult`
* GET `/api/cdc/alertas`
* GET `/api/cdc/recomendacao-dentista?idade=35`

## 🔮 Testes Automatizados

Para rodar os testes:

```bash
dotnet test
```

* Os testes cobrem consumo da API externa e lógicas dos controladores.
* Moq foi usado para mockar dependências como `ICdcApiService`.

## 📅 Regras de Recomendacao

| Faixa Etária | Frequência Recomendada |
| ------------ | ---------------------- |
| 0 - 5 anos   | A cada 6 meses         |
| 6 - 17 anos  | A cada 12 meses        |
| 18 - 59 anos | A cada 12 meses        |
| 60+ anos     | A cada 6 meses         |

## 📊 Exemplo de Resposta da API Externa (CDC)

```json
{
  "year": "2020",
  "locationabbr": "US",
  "category": "Adult",
  "indicator": "Adults 65+ who have lost teeth",
  "response": "Yes",
  "data_value": "45.0"
}
```

## 📄 Entrega do Projeto

O repositório inclui:

* Código-fonte completo
* Testes automatizados
* Integração externa (CDC API)
* Middleware de tratamento
* Documentação Swagger e README

---

🎓 **FIAP - 2TDSPC** | Projeto de Desenvolvimento Web com .NET
