## LabManager

Aplicação para cadastro e leitura de computadores e laboratórios em um banco de dados.

## Funcionalidades

- Realiza o cadastro de computadores e laboratórios
- Exibe uma lista de computadores e laboratórios
- Mostra um computador por ID
- Eliminação de um computador
- Atualizar um computador

## Tecnologias 

.NET 6.0

## Uso

Utilize o comando a seguir para baixar o repositório na sua máquina:

git clone https://github.com/giovanna-alves-de-farias/LabManager.git`

Use os comandos a seguir para manipular a aplicação:

## Computadores

CREATE, Substitua os valores para inserir novas tuplas na tabela:

dotnet run -- Computer New id ram processador

READ, liste utilizando:

dotnet run -- Computer List
READ (single), obtenha um computador específico utilizando:

dotnet run -- Computer Show id
UPDATE, atualize um computador específico utilizando:

dotnet run -- Computer Update id ram processador
DELETE, remova um computador específico utilizando:

dotnet run -- Computer Delete id

## Laboratórios

CREATE, Substitua os valores para inserir novas tuplas na tabela:

dotnet run -- Lab New id number name block

READ, liste utilizando:

dotnet run -- Lab List