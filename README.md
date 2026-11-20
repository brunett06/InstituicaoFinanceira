# 🏦 Instituição Financeira (C#)

Aplicação de console em C# que modela um **sistema bancário**: bancos, agências, clientes e contas, com **testes automatizados**.

## Funcionalidades
- **Conta:** depósito, saque, transferência entre contas, resumo da conta e destaque da conta com maior saldo
- **Validações:** nome e número do banco; número, CEP e telefone da agência; CPF e idade do cliente
- **Testes unitários com MSTest** para Banco, Agência, Cliente e Conta (valores válidos e inválidos)

## Tecnologias
![C#](https://img.shields.io/badge/C%23-512BD4?style=flat&logo=dotnet&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET_8-512BD4?style=flat&logo=dotnet&logoColor=white)
![MSTest](https://img.shields.io/badge/MSTest-5C2D91?style=flat&logo=dotnet&logoColor=white)

## Estrutura
```
ControleContas/   # Banco, Agencia, Cliente, Conta e Program
ContaTeste/       # testes unitários (MSTest)
```

## Como rodar
- Aplicação: `dotnet run --project ControleContas`
- Testes: `dotnet test`

## O que pratiquei
Programação orientada a objetos (classes, encapsulamento e relacionamentos), regras de negócio com validação e testes unitários.

---
Feito por [Bruna Aganett](https://github.com/brunett06) · [Portfólio](https://brunaaganettportifolio.lovable.app)
