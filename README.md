📈 Project Evolution

Este projeto consiste em um sistema de gestão de clientes corporativos, desenvolvido com o objetivo de aplicar e evoluir conceitos de backend com C# e .NET, seguindo boas práticas de arquitetura e modelagem de domínio.

O sistema simula um cenário real onde uma empresa pode gerenciar múltiplos clientes, aplicando validações, regras de negócio e controle de dados.

---

🟢 v1 — Console Application + TXT Storage

Primeira versão funcional do sistema, com foco em fundamentos.

✔ Cadastro de clientes via console  
✔ Captura de dados (nome, email, telefone)  
✔ Persistência em arquivo .txt  
✔ Uso de StreamWriter  
✔ Estrutura inicial com separação de responsabilidades  

Objetivo: consolidar fundamentos de C# e manipulação de dados.

---

🟡 v2 — Modelagem de Domínio + Relacionamentos

Evolução para uma estrutura mais próxima de sistemas reais.

✔ Criação da entidade Empresa  
✔ Relacionamento 1:N (Empresa → Clientes)  
✔ Uso de Enums (Status, Tipo de Cliente)  
✔ Introdução da camada de Controllers  
✔ Início da camada de validações  

Objetivo: aplicar conceitos de modelagem de domínio e organização de código.

---

🔵 v3 — Regras de Negócio e Validações

Foco em consistência e integridade dos dados.

✔ Validação de CPF, Email e Nome  
✔ Separação entre validação e regra de negócio  
✔ Regras como:
   - Cliente bloqueado não pode executar determinadas ações  

Objetivo: garantir integridade e confiabilidade do sistema.

---

🟣 v4 — Persistência com Banco de Dados (Em breve)

✔ Integração com SQL Server  
✔ Implementação de repositórios  
✔ Verificação de CPF único  
✔ Uso de ORM (Entity Framework)

---

🚀 v5 — API REST (Planejado)

✔ Transformação em API com ASP.NET Core  
✔ Endpoints RESTful  
✔ Autenticação e autorização (JWT)  
✔ Aplicação de princípios SOLID  
✔ Estrutura baseada em Clean Architecture  

---

🎯 Objetivo do Projeto

Desenvolver um sistema evolutivo que simula um ambiente real de backend, consolidando conhecimentos em:

- C#
- .NET
- Arquitetura de Software
- Modelagem de Domínio
- Boas práticas de desenvolvimento
