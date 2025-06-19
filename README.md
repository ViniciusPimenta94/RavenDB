# Projeto de Integração com RavenDB

Este projeto .NET demonstra como conectar e interagir com uma instância do banco de dados RavenDB utilizando a biblioteca `Raven.Client`.

## 📌 Funcionalidades

- Conexão com instância RavenDB
- Inserção, consulta e atualização de documentos
- Exemplo de modelo de entidade

## 🛠 Requisitos

- .NET 6 SDK ou superior
- RavenDB Client (`Raven.Client` via NuGet)
- Visual Studio 2022 (opcional)

## ▶️ Como Executar

1. Restaure os pacotes:
   ```bash
   dotnet restore
   ```

2. Compile a solução:
   ```bash
   dotnet build
   ```

3. Execute o projeto:
   ```bash
   dotnet run --project RavenDB.csproj
   ```

## 📁 Estrutura

- `Program.cs` - Código principal de execução
- `RavenDB.csproj` - Configuração do projeto
- `bin/`, `obj/` - Diretórios de build (ignorados)
