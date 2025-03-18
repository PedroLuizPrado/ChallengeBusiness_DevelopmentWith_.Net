# 📌 Sprint03 - Atualização e Estrutura do Projeto

## 📚 Visão Geral
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
### **1⃣ Organização da Estrutura do Projeto**
- Separamos o código por **camadas** para melhor modularização:
  - `Domain`: Contém as entidades e regras de negócio fundamentais.
  - `Infrastructure`: Gerencia a camada de acesso a dados, incluindo **repositórios e contexto do banco**.
  - `Presentation`: Camada que expõe os endpoints da API e gerencia as requisições HTTP.

### **2⃣ Implementação do Banco de Dados com Oracle**
- Utilizamos o **Entity Framework Core** para gerenciar a persistência dos dados.
- Criamos e aplicamos **migrações** para estruturar o banco corretamente.
- Ajustamos os mapeamentos das entidades, garantindo consistência entre as classes e o banco de dados.

### **3⃣ Documentação com Swagger**
- Implementamos a documentação automática via **Swashbuckle.AspNetCore**, facilitando a visualização e testes dos endpoints.
- Adicionamos **anotações XML** para documentar as entidades, métodos e parâmetros da API.

### **4⃣ CRUD Completo para NomeUsuário**
- Desenvolvemos operações completas de **Criação, Leitura, Atualização e Exclusão (CRUD)** para gerenciar usuários na API.
- Ajustamos os DTOs para garantir uma melhor estruturação e evitar exposição direta das entidades do domínio.

## 🚀 Conclusão e Próximos Passos
A atualização da Sprint03 trouxe maior organização e estrutura para o projeto, garantindo uma API robusta e bem documentada. A escolha da arquitetura monolítica foi fundamental para manter a equipe produtiva e garantir a entrega dentro do prazo, com um modelo eficiente para o escopo definido.

Os próximos passos incluem **otimizações na segurança, validação avançada de entrada de dados e testes automatizados**, preparando o projeto para futuras integrações e escalabilidade.

📌 **Status da Sprint03**: ✅ Concluído com sucesso!

📢 **Mantenha-se atualizado!** Continue acompanhando nosso progresso para mais melhorias e refinamentos na API. 💡
