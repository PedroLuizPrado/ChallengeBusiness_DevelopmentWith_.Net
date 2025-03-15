# Projeto - Redução de Sinistros Odontológicos com Visão Computacional🦷

## Desenvolvedores:

- **Murillo Ferreira Ramos** - RM553315
- **Pedro Luiz Prado** - RM553874
- **William Kenzo Hayashi** - RM552659

## Descrição do Problema👨‍⚕️:

O setor odontológico enfrenta desafios recorrentes em relação ao controle e redução de sinistros. Os sinistros odontológicos ocorrem quando o serviço é utilizado de forma inadequada, seja por excesso de consultas, tratamentos desnecessários ou, em casos mais graves, fraudes. Esses fatores aumentam significativamente os custos para operadoras, como a Odontoprev, impactando diretamente a sustentabilidade financeira da empresa. Além disso, o atendimento excessivo sem a devida necessidade pode gerar desgaste na relação paciente-profissional, reduzindo a confiança e prejudicando o tratamento adequado.

A falta de mecanismos preditivos eficientes que auxiliem na identificação precoce de padrões anômalos contribui para o aumento de sinistros e fraudes, uma vez que operadoras não conseguem prever ou mitigar tais ocorrências de maneira funcional. O foco do projeto é propor uma solução tecnológica que ajude a reduzir sinistros no setor odontológico por meio da análise de dados e visão computacional, utilizando imagens odontológicas para antecipar possíveis riscos e evitar tratamentos desnecessários.

## Descrição dos Objetivos da Solução Idealizada🤖:

O objetivo central do projeto é desenvolver um aplicativo mobile que utiliza visão computacional para realizar uma análise personalizada da saúde bucal dos usuários a partir de imagens capturadas pelos próprios pacientes. O sistema será capaz de interpretar essas imagens, identificar possíveis problemas odontológicos e sugerir planos de cuidados contínuos com base nas necessidades individuais.

A gamificação será utilizada de forma estratégica para motivar o uso constante do aplicativo. Por meio de desafios diários e metas de saúde, o usuário será incentivado a melhorar seus hábitos de higiene bucal de maneira divertida e natural. Esses elementos de design manterão o paciente engajado, melhorando sua saúde bucal e criando um vínculo de longo prazo com o serviço.

Para a Odontoprev, o aplicativo representa uma inovação disruptiva, oferecendo uma ferramenta que reduz sinistros e fraudes, ao mesmo tempo em que melhora a experiência dos usuários. Ao prever e mitigar tratamentos desnecessários ou consultas em excesso, o aplicativo contribui para a sustentabilidade da operadora e se torna um diferencial competitivo, atraindo novos clientes e fidelizando os atuais.

## A Função da .NET no Projeto📋:

No projeto, a plataforma .NET será utilizada para desenvolver as seguintes funcionalidades:

- **Cadastro e Login**: O usuário deverá fornecer as seguintes informações:
  - **Nome**: Para identificar o usuário.
  - **Email**: Para cadastro.
  - **Senha**: Para proteger a conta.
  - **CPF**: Para salvar dados na conta.
  - **Primeiro Tratamento**: Para registrar a quantidade de tratamentos realizados.
  - **IsActive**: Para verificar se o usuário está ativo ou não.
  - **Role**: Para tratar o usuário como um usuário comum e não como um admin.
  - **Avatar**: Define uma imagem padrão para o user.

Essas informações serão armazenadas no sistema para garantir a personalização e segurança da experiência do usuário.

## Sprint02

Durante a Sprint02, foram adicionadas as seguintes implementações e funcionalidades:

- **Views e Layouts**:
  - Configuração de rotas padrão e rotas personalizadas para as páginas da aplicação.
  - Implementação do layout principal, incluindo cabeçalho, rodapé e navegação personalizada com Bootstrap.
  - Criação de views para as funcionalidades principais com validações correspondentes das viewmodels.
  - Definição de ViewModels para transferir dados entre a camada de apresentação e a lógica de negócio.

- **Layout e Design**:
  - Arquivo `_Layout.cshtml` atualizado para incluir links e scripts necessários para o funcionamento do Bootstrap e Popper.js.
  - Estruturação do layout com navegação e estilo responsivo para facilitar a usabilidade.

- **Configuração e Estrutura**:
  - Definição das configurações para a aplicação .NET no arquivo `Program.cs`, incluindo mapeamento de rotas e configuração de middlewares essenciais.
  - Integração de Bootstrap e Popper.js para aprimorar a interface e funcionalidade da aplicação.

Essas atualizações foram feitas para melhorar a navegação, a usabilidade e o layout da aplicação, atendendo aos requisitos da Sprint02.

# 📌 Sprint03 - Atualização e Estrutura do Projeto

## 📖 Visão Geral
A Sprint03 foi marcada pela evolução do projeto, consolidando sua arquitetura e garantindo maior robustez e organização para atender às necessidades da API. Optamos por uma arquitetura **monolítica**, pois é o modelo mais familiar para a equipe e, considerando o escopo do projeto, foi a escolha mais eficiente e adequada para garantir uma implementação ágil e bem estruturada.

## 💡 Motivos para Escolha da Arquitetura Monolítica
1. **Familiaridade da Equipe**
   - A equipe já possui experiência consolidada com o desenvolvimento monolítico, o que agiliza a implementação e reduz a curva de aprendizado.
   
2. **Adequação ao Escopo do Projeto**
   - Como o projeto se trata exclusivamente de uma API, não há necessidade imediata de um modelo distribuído, como microservices. A abordagem monolítica permite um desenvolvimento mais direto e eficiente.
   
3. **Facilidade de Manutenção e Depuração**
   - Em um ambiente monolítico, todos os componentes estão centralizados, tornando mais simples a manutenção, depuração e testes.
   
4. **Gerenciamento de Banco de Dados Simplificado**
   - Em uma estrutura monolítica, há um único banco de dados centralizado, facilitando a modelagem, migração e administração dos dados.
   
## ⚙️ Atualizações Implementadas
### **1️⃣ Organização da Estrutura do Projeto**
- Separação do código por **camadas** para melhor modularização:
  - `Domain`: Contém as entidades e regras de negócio fundamentais.
  - `Infrastructure`: Gerencia a camada de acesso a dados, incluindo **repositórios e contexto do banco**.
  - `Application`: Responsável por DTOs, interfaces e serviços para intermediar a comunicação entre o domínio e a apresentação.
  - `Presentation`: Camada que expõe os endpoints da API e gerencia as requisições HTTP.

### **2️⃣ Implementação do Banco de Dados com Oracle**
- Utilizamos o **Entity Framework Core** para gerenciar a persistência dos dados.
- Criamos e aplicamos **migrações** para estruturar o banco corretamente.
- Ajustamos os mapeamentos das entidades, garantindo consistência entre as classes e o banco de dados.

### **3️⃣ Documentação com Swagger**
- Implementamos a documentação automática via **Swashbuckle.AspNetCore**, facilitando a visualização e testes dos endpoints.
- Adicionamos **anotações XML** para documentar as entidades, métodos e parâmetros da API.

### **4️⃣ CRUD Completo para NomeUsuário**
- Desenvolvemos operações completas de **Criação, Leitura, Atualização e Exclusão (CRUD)** para gerenciar usuários na API.
- Ajustamos os DTOs para garantir uma melhor estruturação e evitar exposição direta das entidades do domínio.

## 🚀 Conclusão e Próximos Passos
A atualização da Sprint03 trouxe maior organização e estrutura para o projeto, garantindo uma API robusta e bem documentada. A escolha da arquitetura monolítica foi fundamental para manter a equipe produtiva e garantir a entrega dentro do prazo, com um modelo eficiente para o escopo definido.

Os próximos passos incluem **otimizações na segurança, validação avançada de entrada de dados e testes automatizados**, preparando o projeto para futuras integrações e escalabilidade.

📌 **Status da Sprint03**: ✅ Concluído com sucesso!

📢 **Mantenha-se atualizado!** Continue acompanhando nosso progresso para mais melhorias e refinamentos na API. 💡





