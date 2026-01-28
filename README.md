# 🚀 Gerenciador de Tarefas API - Trilha .NET 10

![.NET](https://img.shields.io/badge/.NET-10.0-512bd4)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?logo=microsoft-sql-server&logoColor=white)
![EF Core](https://img.shields.io/badge/EF_Core-10.0-blue)

Este projeto foi desenvolvido como parte do desafio técnico da trilha .NET da DIO. Trata-se de uma API robusta para gerenciamento de tarefas, onde apliquei recursos do C# 14 e conceitos avançados de persistência de dados e arquitetura de software.

## 🌟 Diferenciais Técnicos

Diferente do projeto base, realizei melhorias estratégicas para alinhar o sistema aos padrões atuais do mercado:

* **Upgrade Tecnológico:** Projeto migrado de .NET 6 para **.NET 10.0 (LTS)**, visando melhor performance e suporte de longo prazo.
* **Sintaxe Moderna:** Refatoração de controladores utilizando Primary Constructors (C# 14), reduzindo código boilerplate e aumentando a legibilidade.
* **Rigor de Tipagem:** Habilitado o `Nullable context` para prevenir erros de referência nula (NullReferenceException).
* **Gestão de Dados:** Implementação de consultas LINQ avançadas para filtragem por múltiplos critérios (Título, Data e Status).

## 🛠️ Tecnologias e Ferramentas

* **Backend:** C# 14, ASP.NET Core Web API (.NET 10)
* **Banco de Dados:** SQL Server
* **ORM:** Entity Framework Core (EF Core)
* **Documentação:** Swagger (OpenAPI)
* **Controle de Versão:** Git / GitHub

## 📈 Evolução e Modernização Técnica

Este projeto foi desenvolvido seguindo um rigoroso critério de manutenção e atualização tecnológica. Embora a base do desafio tenha sido concebida em versões anteriores, apliquei um fluxo de **modernização proativa** para alinhar a solução às práticas atuais da Engenharia de Software.

### Por que o upgrade para .NET 10 (LTS)?

Ao identificar o lançamento da versão estável mais recente, realizei a migração direta do framework para o **.NET 10.0 (LTS)**. Esta decisão baseia-se em três pilares fundamentais:

* **Conformidade Tecnológica:** Garantir que o sistema opere na versão com suporte de longo prazo (Long Term Support), eliminando dívidas técnicas de versões legadas.
* **Performance e C# 14:** Aproveitar as melhorias de compilador e as novas sintaxes do C# 14, resultando em um código mais limpo e eficiente.
* **Segurança (Future-proofing):** Implementar as bibliotecas mais recentes do Entity Framework Core e ASP.NET Core para assegurar a proteção contra vulnerabilidades conhecidas em versões anteriores.

> **Nota de Processo:** Esta abordagem de "Manutenção Evolutiva" reflete minha metodologia de trabalho: o software deve ser tratado como um ativo em constante evolução, onde a estabilidade e a modernização andam juntas para entregar valor real ao usuário final.

## 📖 Como Executar o Projeto

1.  **Configuração de Ambiente:**
    Ajuste a `Connection String` no arquivo `appsettings.json` para o seu servidor local.
    > Certifique-se de incluir `TrustServerCertificate=True` se estiver em ambiente de desenvolvimento local.

2.  **Persistência de Dados (Migrations):**
    No terminal do VS Code, execute:
    ```bash
    dotnet ef database update
    ```

3.  **Iniciar a API:**
    ```bash
    dotnet run
    ```
    A API iniciará o servidor local. Você pode acessar a documentação interativa e testar os endpoints através da rota **Swagger**:
    * `http://localhost:PORTA/swagger/index.html` 
    
    *(Substitua `PORTA` pela porta gerada automaticamente pelo .NET, geralmente informada no terminal após o comando `dotnet run`).*

## ⚖️ Sobre o Autor

**Cassiano Silverston**
Advogado com OAB ativa e experiência em produtos jurídicos na **Thomson Reuters**, atualmente em transição de carreira para a **Engenharia de Software**. Minha missão é unir o rigor analítico e a organização de processos da área jurídica com a agilidade e inovação do desenvolvimento backend .NET.

---
