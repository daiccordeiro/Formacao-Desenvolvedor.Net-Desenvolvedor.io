## Fundamentos do C#
<br>
Este repositório reúne os projetos introdutórios desenvolvidos durante o curso **Fundamentos do C#**, com foco na compreensão da linguagem e seus principais recursos.

---

## O que foi estudado
> Durante o curso foram abordados os seguintes tópicos:

- ProjetoAulas:
	- **01 – Hands On Code:**
		- Variáveis
		- Constantes
		- Operadores Aritméticos
		- Operadores Relacionais
		- Operadores Lógicos
		- Operador Ternário
	- **02 - Funções:**
		- Métodos com e sem retorno
		- Métodos com parâmetros
		- Organização de responsabilidades
	- **03 – Estrutura de Dados:**
		- `ArrayList`
		- Arrays tipados
		- `List`
		- `Dictionary`
		- `Queue`
		- `Stack`
	- **04 – Estrutura de Controle:**
		- `if / else`
		- `switch`
		- `for`
		- `foreach`
		- `while`
		- `break / continue`
	- **05 – Programação Orientada a Objetos:**
		- Classes
		- Classe Selada
		- Classe Abstrata
		- Herança	
		- Interface
		- Record 
	- **06 – Conversores de Valor:**
		- `Convert`
		- `Parse`
		- `TryParse`
	- **07 – Strings:**
		- `ToLower`
		- `ToUpper` 
		- `Substring` 
		- `Range` 
		- `Contains`
		- `StartsWith e EndsWith`
		- `Trim`
		- `Replace`
		- `Length`
	- **08 – Datas:**
		- `DateTime`
		- `DateOnly`
		- `TimeOnly`
	- **09 – Exceções:**
		- `try`
		- `catch`
	- **10 – Arquivos:**
		- Criação
		- Leitura
		- Exclusão
	- **11 – LINQ:**
		- `Where`
		- `Order By`
		- `Take`
		- `Count`
		- `First`
		- `FirstOrDefault`

- AppClientes:	
	- `Cliente.cs`->> Classe que representa a entidade Cliente.	
		- Id
		- Nome
		- DataNascimento, etc		
	- `ClienteRepositorio.cs`->> Classe responsável pela regra de negócio e persistência.
		- CRUD:
			- Cadastrar cliente
			- Listar clientes
			- Editar cliente
			- Excluir cliente		
	- `cliente.txt`->>	Arquivo para salvar os dados persistidos
		- Serializar a lista de clientes em JSON
		- Salvar os dados no arquivo txt	
	- `Program.cs` ->> Centraliza a execução dos exemplos, chamando métodos específicos para cada módulo
		- Contém menu interativo:
			```
			Cadastro de Clientes
			--------------------
			1 - Cadastrar Cliente
			2 - Exibir Clientes
			3 - Editar Cliente
			4 - Excluir Cliente
			5 - Sair
			--------------------
			```
---

## Estrutura do projeto

- ProjetoAulas:	
	```
	ProjetoAulas
	│── ProjetoAulas.csproj
	|── Program.cs	
	├── 01-HandsOnCode
	├── 02-Funções
	├── 03-EstruturaDeDados
	├── 04-EstruturaDeControle
	├── 05-POO
	├── 06-ConversoresDeValor
	├── 07-TrabalhandoComStrings
	├── 08-TrabalhandoComDatas
	├── 09-TrabalhandoComExcecoes
	├── 10-TrabalhandoComArquivos
	└── 11-TrabalhandoComLINQ
	```

- AppClientes:
	```
	AppClientes	│
	├── AppClientes.csproj 
	├── AppClientes.sln 
	├── Cliente.cs 
	├── ClienteRepositorio.cs
	├── clientes.txt
	└── Program.cs 	
	```	
---

## Tecnologias
- C#
- .NET 9
- Console Application
- Serialização JSON
- LINQ
- Programação Orientada a Objetos

---

## Como executar

```
# Pré-requisitos:
.NET 9 SDK instalado

# Executar ProjetoAulas
dotnet run --project ProjetoAulas

# Executar AppClientes
dotnet run --project AppClientes
```