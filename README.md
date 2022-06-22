## LabManager

Aplicação para cadastro e leitura de computadores e laboratórios em um banco de dados.

## Funcionalidades

- Realiza o cadastro de computadores e laboratórios
- Exibe uma lista de computadores e laboratórios
- Exibe um computador e um laboratório por ID
- Eliminação de um computador e um laboratório
- Atualiza um computador e um laboratório

## Tecnologias 

- .NET 6.0.3
- C#
- Dapper 2.0.123
- Sqlite

## Uso

Utilize o comando a seguir para baixar o repositório na sua máquina:

`git clone https://github.com/giovanna-alves-de-farias/Tarefa-LabManager.git`

Use os comandos a seguir para manipular a aplicação:

## Computadores

Para trocar os valores para adicionar novas tuplas na tabela:

`dotnet run -- Computer New id ram processor`

Para exibir a lista de computadores:

`dotnet run -- Computer List`

Para acessar um determinado computador:

`dotnet run -- Computer Show id`

Para atualizar um determinado computador:

`dotnet run -- Computer Update id ram processador`

Para excluir um determinado computador:

`dotnet run -- Computer Delete id`

## Laboratórios

Para trocar os valores para adicionar novas tuplas na tabela:

`dotnet run -- Lab New id number name block`

Para exibir a lista de laboratórios:

`dotnet run -- Lab List`

Para acessar um determinado laboratório:

`dotnet run -- Lab Show id`

Para atualizar um determinado laboratório:

`dotnet run -- Lab Update id ram processador`

Para excluir um determinado laboratório:

`dotnet run -- Lab Delete id`