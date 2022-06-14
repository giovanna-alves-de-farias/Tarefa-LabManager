## LabManager

Aplicação para cadastro e leitura de computadores e laboratórios em um banco de dados.

## Funcionalidades

- Realiza o cadastro de computadores e laboratórios
- Exibe uma lista de computadores e laboratórios
- Mostra um computador por ID
- Eliminação de um computador
- Atualizar um computador

## Tecnologias 

- .NET 6.0
- C#

## Uso

Utilize o comando a seguir para baixar o repositório na sua máquina:

`git clone https://github.com/giovanna-alves-de-farias/Tarefa-LabManager.git`

Use os comandos a seguir para manipular a aplicação:

## Computadores

Troque os valores para adicionar novas tuplas na tabela:

`dotnet run -- Computer New id ram processor`

Para exibir a lista:

`dotnet run -- Computer List`

Acesse um determinado computador:

`dotnet run -- Computer Show id`

Para atualizar um determinado computador:

`dotnet run -- Computer Update id ram processador`

Excluir um determinado computador:

`dotnet run -- Computer Delete id`

## Laboratórios

Troque os valores para adicionar novas tuplas na tabela:

`dotnet run -- Lab New id number name block`

Para exibir a lista:

`dotnet run -- Lab List`
