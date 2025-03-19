# 📌 Sprint03 - Redução de Sinistros Odontológicos com Visão Computacional 🦷

## 👥 Integrantes do Grupo

- **Murillo Ferreira Ramos** - RM553315  
- **Pedro Luiz Prado** - RM553874  
- **William Kenzo Hayashi** - RM552659  

## 📖 Visão Geral do Projeto

O objetivo central do projeto é desenvolver uma API utilizando .NET para auxiliar na **redução de sinistros odontológicos** por meio da análise de dados e visão computacional. Essa API servirá como base para armazenar e gerenciar dados dos usuários, garantindo **segurança, eficiência e escalabilidade** na aplicação.

## 💡 Arquitetura Escolhida

Optamos por uma **arquitetura monolítica** devido a:

1. **Familiaridade da Equipe**: A abordagem monolítica é mais compreendida pelos integrantes, agilizando o desenvolvimento.
2. **Adequação ao Escopo do Projeto**: Sendo uma API específica para um propósito definido, a necessidade de microservices não se justifica.
3. **Facilidade de Manutenção e Depuração**: A centralização da aplicação permite um controle mais eficiente de erros e atualizações.
4. **Gerenciamento de Banco de Dados Simplificado**: Um único banco centralizado facilita o desenvolvimento e as migrações.

## ⚙️ Funcionalidades Implementadas

- **Estrutura em Camadas**: 
  - `Domain`: Define as entidades do sistema.
  - `Infrastructure`: Gerencia repositórios e a conexão com o banco de dados.
  - `Presentation`: Contém os controladores e endpoints da API.

- **Banco de Dados**: 
  - Implementação do **Entity Framework Core**.
  - Uso do banco **Oracle** para armazenar os dados dos usuários.

- **Documentação com Swagger**: 
  - Geração automática de documentação para facilitar a utilização e testes dos endpoints.

- **CRUD Completo para Usuários**:
  - **Criação** de novos usuários.
  - **Consulta** de usuários cadastrados.
  - **Atualização** de informações de usuários.
  - **Remoção** de usuários do banco de dados.

## 🚀 Como Executar a API

### 📌 Pré-requisitos
- .NET 6 ou superior instalado.
- Banco de Dados Oracle configurado.
- Ferramenta Postman ou Swagger para testar os endpoints.

### 🔧 Configuração do Banco de Dados
1. Atualize a string de conexão no arquivo `appsettings.json`.
2. Execute as **migrações** para criar o banco:
   ```sh
   dotnet ef migrations add InicialNovaEstrutura
   dotnet ef database update
   ```
3. Inicie a API:
   ```sh
   dotnet run
   ```

## 🔄 Endpoints da API

### 📌 Usuários

1️⃣ **Criar um novo usuário**  
📌 **POST** `/api/nomeusuarios`  
🔹 **Body (JSON):**
```json
{
  "nomeUsuario": "João Silva",
  "email": "joao@email.com",
  "nascData": "1990-05-15",
  "phoneNumber": "(11) 99999-9999"
}
```
📌 **Resposta:**
```json
{
  "id": 1,
  "nomeUsuario": "João Silva",
  "email": "joao@email.com",
  "nascData": "1990-05-15T00:00:00",
  "phoneNumber": "(11) 99999-9999"
}
```

2️⃣ **Buscar todos os usuários**  
📌 **GET** `/api/nomeusuarios`

📌 **Resposta:**
```json
[
  {
    "id": 1,
    "nomeUsuario": "João Silva",
    "email": "joao@email.com",
    "nascData": "1990-05-15T00:00:00",
    "phoneNumber": "(11) 99999-9999"
  }
]
```

3️⃣ **Buscar um usuário por ID**  
📌 **GET** `/api/nomeusuarios/{id}`  
📌 **Resposta:**
```json
{
  "id": 1,
  "nomeUsuario": "João Silva",
  "email": "joao@email.com",
  "nascData": "1990-05-15T00:00:00",
  "phoneNumber": "(11) 99999-9999"
}
```

4️⃣ **Atualizar um usuário**  
📌 **PUT** `/api/nomeusuarios/{id}`  
🔹 **Body (JSON):**
```json
{
  "nomeUsuario": "João Silva Modificado",
  "email": "joao.novo@email.com",
  "nascData": "1990-05-15",
  "phoneNumber": "(11) 98888-8888"
}
```
📌 **Resposta:**
```json
{
  "id": 1,
  "nomeUsuario": "João Silva Modificado",
  "email": "joao.novo@email.com",
  "nascData": "1990-05-15T00:00:00",
  "phoneNumber": "(11) 98888-8888"
}
```

5️⃣ **Excluir um usuário**  
📌 **DELETE** `/api/nomeusuarios/{id}`  
📌 **Resposta:**
```json
{
  "message": "Usuário removido com sucesso."
}
```

## 📄 Entrega do Projeto

📌 O repositório contém:
- Código-fonte completo da API.
- Explicação da arquitetura utilizada.
- Instruções para rodar a API.
- Testes e validações.


