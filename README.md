# Executando o Projeto PizzariaWebApp

Este projeto é uma aplicação ASP.NET Core que usa o Entity Framework Core para interagir com o banco de dados. Aqui estão as etapas para instalar as ferramentas necessárias e executar o projeto em sua máquina local.

## Pré-requisitos

1. [.NET Core SDK](https://dotnet.microsoft.com/download)
2. [Visual Studio](https://visualstudio.microsoft.com/downloads/) ou [Visual Studio Code](https://code.visualstudio.com/download) (com a extensão C# instalada)
3. [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Opcional, se você planeja usar um banco de dados SQL Server local)

## Passos para Executar o Projeto

1. **Clone o Repositório**: Clone o repositório do projeto em sua máquina local usando o comando git abaixo:
\`\`\`
git clone https://github.com/ErickRock/PizzariaWebApp
\`\`\`

1. **Abra o Projeto**: Abra o arquivo de solução (.sln) no Visual Studio ou abra a pasta do projeto no Visual Studio Code.

2. **Restaure os Pacotes NuGet**: No Visual Studio, você pode fazer isso clicando com o botão direito na solução e selecionando "Restaurar Pacotes NuGet". No Visual Studio Code, você pode usar o comando abaixo no terminal:
\`\`\`
dotnet restore
\`\`\`

1. **Atualize o Banco de Dados**: Se você fez alterações nos modelos e precisa atualizar o banco de dados, você pode fazer isso usando o comando de migração do Entity Framework. No terminal do Visual Studio ou do Visual Studio Code, digite:
\`\`\`
dotnet ef database update
\`\`\`

1. **Execute o Projeto**: No Visual Studio, você pode pressionar F5 para iniciar o projeto. No Visual Studio Code, você pode usar o comando abaixo no terminal:
\`\`\`
dotnet run
\`\`\`

Agora, o projeto deve estar em execução e você pode acessar a API através do navegador ou de um cliente HTTP como o Postman.

Lembre-se de verificar a string de conexão do banco de dados no arquivo `appsettings.json` e atualizá-la conforme necessário.