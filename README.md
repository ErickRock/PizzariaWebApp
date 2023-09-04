Este projeto é uma aplicação ASP.NET Core que usa o Entity Framework Core para interagir com o banco de dados. Aqui estão as etapas para instalar as ferramentas necessárias e executar o projeto em sua máquina local.

[![Build and Test](https://github.com/ErickRock/PizzariaWebApp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/ErickRock/PizzariaWebApp/actions/workflows/dotnet.yml)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Perfil-blue)](https://www.linkedin.com/in/erickgarciagodoy/)
[![Instagram](https://img.shields.io/badge/Instagram-Perfil-red)](https://www.instagram.com/garciiaerick/)
[![Twitter](https://img.shields.io/badge/Twitter-Perfil-blue)](https://twitter.com/garciaeriickk)

## 📝 Sumário

- [📝 Sumário](#-sumário)
- [🚀 Pré-requisitos](#-pré-requisitos)
- [⚙️ Configuração do Ambiente](#️-configuração-do-ambiente)
  - [🖥️ Windows 11 (utilizando winget)](#️-windows-11-utilizando-winget)
  - [🐧 Linux (baseado no Debian)](#-linux-baseado-no-debian)
- [🔧 Passos para Executar o Projeto](#-passos-para-executar-o-projeto)

## 🚀 Pré-requisitos

1. 🌐 [.NET Core SDK](https://dotnet.microsoft.com/download)
2. 💻 [Visual Studio](https://visualstudio.microsoft.com/downloads/) ou [Visual Studio Code](https://code.visualstudio.com/download) (com a extensão C# instalada)
3. 🗄️ [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Opcional, se você planeja usar um banco de dados SQL Server local)

## ⚙️ Configuração do Ambiente

### 🖥️ Windows 11 (utilizando winget)

1. Instale o [Windows Package Manager (winget)](https://docs.microsoft.com/en-us/windows/package-manager/winget/)

2. Abra o Prompt de Comando ou o PowerShell e execute o seguinte comando para instalar o .NET Core SDK:

   ```pwsh
   winget install -e --id=Microsoft.DotNet.SDK.7
   ```

### 🐧 Linux (baseado no Debian)

1. Abra o Terminal e execute os seguintes comandos para instalar o .NET Core SDK:

   ```bash
   wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
   sudo dpkg -i packages-microsoft-prod.deb
   sudo apt-get update
   sudo apt-get install -y apt-transport-https
   sudo apt-get update
   sudo apt-get install -y dotnet-sdk-7.0
   ```

## 🔧 Passos para Executar o Projeto

1. **Clone o Repositório**: Clone o repositório do projeto em sua máquina local usando o comando git abaixo:

```
git clone https://github.com/ErickRock/PizzariaWebApp
```

2. **Abra o Projeto**: Abra o arquivo de solução (.sln) no Visual Studio ou abra a pasta do projeto no Visual Studio Code.

3. **Restaure os Pacotes NuGet**: No Visual Studio, você pode fazer isso clicando com o botão direito na solução e selecionando "Restaurar Pacotes NuGet". No Visual Studio Code, você pode usar o comando abaixo no terminal:

```
dotnet restore
```

4. **Atualize o Banco de Dados**: Se você fez alterações nos modelos e precisa atualizar o banco de dados, você pode fazer isso usando o comando de migração do Entity Framework. No terminal do Visual Studio ou do Visual Studio Code, digite:

```
dotnet ef database update
```

5. **Execute o Projeto**: No Visual Studio, você pode pressionar F5 para iniciar o projeto. No Visual Studio Code, você pode usar o comando abaixo no terminal:

```
dotnet run
```

Agora, o projeto deve estar em execução e você pode acessar a API através do navegador ou de um cliente HTTP como o Postman.

Lembre-se de verificar a string de conexão do banco de dados no arquivo `appsettings.json` e atualizá-la conforme necessário.
