# ASP.Net Minimal API – Estrutura Completa (C# .NET)

Este projeto é uma **Minimal API em .NET**, organizada seguindo boas práticas de **Domain-Driven Design (DDD)**, **injeção de dependência**, **separação de camadas**, **validações**, além de conter um **projeto de testes unitários**.

[![Imagem de capa](https://github.com/robsonosbor/asp-net-minimal-api/blob/main/screenshot-swagger.png)](/)

---

## 📌 Tecnologias Utilizadas

- **.NET 9**
- **Minimal API**
- **Entity Framework Core**
- **MySQL** (configurável)
- **AutoMapper**
- **FluentValidation**
- **JWT Authentication**
- **xUnit** (Testes)
- **Moq** (mocks nos testes)

---

## 📁 Estrutura do Projeto

```plaintext

minimal-api/
│── API/ # Projeto principal da API
│ ├── Dominio/ # Regras de negócio
│ │ ├── DTOs/
│ │ ├── Entidades/
│ │ ├── Interfaces/
│ │ └── Servicos/
│ │
│ ├── Infra/ # Persistência e infraestrutura
│ │ ├── Contexto/
│ │ ├── Mapeamentos/
│ │ ├── Migracoes/
│ │ ├── Repositorios/
│ │ └── Utils/
│ │
│ ├── Rotas/ # Endpoints da API
│ ├── appsettings.json
│ ├── Program.cs
│ └── Startup.cs
│
├── Test/ # Projeto de testes
│ ├── Domain/
│ ├── Helpers/
│ ├── Mocks/
│ └── Requests/
│
└── minimal-api.sln


```


## 🚀 Como Executar o Projeto

### 1. Restaurar pacotes

```bash
dotnet restore
```
### 2. Aplicar migrações do banco

```bash
dotnet ef database update --project API
```

### 3. Rodar a API

```bash
dotnet run --project API
```

A API iniciará em:

```arduino
https://localhost:7248
http://localhost:5248
```

## Autenticação

O sistema usa **JWT** para autenticação.

**Endpoint de login**
```bash
POST /login
```

Exemplo:
```json
{
  "email": "admin@teste.com",
  "senha": "123456"
}
```

## Testes Automatizados

Para executar os testes:
```bash
dotnet test
```
Os testes cobrem:

- Serviços de domínio
- Validações
- Requisições
- Mocks de repositórios

## Principais Features

- Cadastro e autenticação de administradores
- Gerenciamento de veículos
- Serviços e regras de domínio bem organizados
- Repositórios utilizando EF Core
- Estrutura limpa e escalável
- Testes unitários bem distribuídos

## Estrutura de Rotas (Resumo)

- **/login** → autenticação JWT
- **/administradores** → CRUD de administradores
- **/veiculos** → CRUD de veículos

## Configuração via appsettings.json
```json
{
  "ConnectionStrings": {
    "ConexaoPadrao": "Server=.;Database=MinimalApi;Integrated Security=True;"
  },
  "Jwt": {
    "Key": "sua-chave-secreta-aqui"
  }
}
```
## Notas do Autor

Este projeto demonstra uma arquitetura simples porém sólida, aplicando conceitos de **DDD**, separação de camadas e testabilidade.

## Contribuições

Fique à vontade para abrir PRs, sugestões ou melhorias na estrutura.