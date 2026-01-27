# 🚀 Gerenciador de Tarefas API - Trilha .NET 8

![.NET](https://img.shields.io/badge/.NET-8.0-512bd4)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?logo=microsoft-sql-server&logoColor=white)
![EF Core](https://img.shields.io/badge/EF_Core-8.0-blue)

Este projeto foi desenvolvido como parte do desafio técnico da trilha .NET da DIO. Trata-se de uma API robusta para gerenciamento de tarefas, onde apliquei conceitos avançados de persistência de dados e arquitetura de software.

## 🌟 Diferenciais Técnicos

Diferente do projeto base, realizei melhorias estratégicas para alinhar o sistema aos padrões atuais do mercado:

* **Upgrade Tecnológico:** Projeto migrado de .NET 6 para **.NET 8.0 (LTS)**, visando melhor performance e suporte de longo prazo.
* **Rigor de Tipagem:** Habilitado o `Nullable context` para prevenir erros de referência nula (NullReferenceException).
* **Gestão de Dados:** Implementação de consultas LINQ avançadas para filtragem por múltiplos critérios (Título, Data e Status).

## 🛠️ Tecnologias e Ferramentas

* **Backend:** C#, ASP.NET Core Web API
* **Banco de Dados:** SQL Server
* **ORM:** Entity Framework Core (EF Core)
* **Documentação:** Swagger (OpenAPI)
* **Controle de Versão:** Git / GitHub

## 📖 Como Executar o Projeto

1.  **Configuração de Ambiente:**
    Ajuste a `Connection String` no arquivo `appsettings.json` para o seu servidor local.
    > Certifique-se de incluir `TrustServerCertificate=True` se estiver em ambiente de desenvolvimento local.

2.  **Persistência de Dados (Migrations):**
    No terminal do VS Code, execute:
    ```bash
    dotnet ef database update
    ```

3.  **Execução:**
    ```bash
    dotnet run
    ```
    Acesse o Swagger em: `http://localhost:5000/swagger/index.html`

## ⚖️ Sobre o Autor

**Cassiano Silverston**
Advogado com OAB ativa e experiência em produtos jurídicos na **Thomson Reuters**, atualmente em transição de carreira para a **Engenharia de Software**. Minha missão é unir o rigor analítico e a organização de processos da área jurídica com a agilidade e inovação do desenvolvimento backend .NET.

---
