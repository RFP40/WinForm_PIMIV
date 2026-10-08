# PIM IV — Sistema de Cadastro de Alunos

Sistema desenvolvido como parte do **Projeto Integrado Multidisciplinar (PIM IV)** da **UNIP — Universidade Paulista**.

O projeto consiste no desenvolvimento de uma aplicação desktop utilizando **C# e Windows Forms**, integrada a um banco de dados **SQL Server**, com o objetivo de realizar o cadastro e a consulta de alunos.

## 📋 Sobre o Projeto

O sistema foi desenvolvido para facilitar o gerenciamento dos dados dos alunos, permitindo que o usuário realize novos cadastros e verifique se determinado aluno já está registrado no banco de dados.

A aplicação possui uma interface gráfica desenvolvida com **Windows Forms**, enquanto o armazenamento e a consulta das informações são realizados por meio de um banco de dados **SQL Server**.

## 🎯 Objetivos

* Desenvolver uma aplicação desktop utilizando C#;
* Criar uma interface gráfica utilizando Windows Forms;
* Realizar o cadastro de alunos;
* Verificar se um aluno já está cadastrado;
* Armazenar os dados dos alunos em um banco de dados SQL Server;
* Realizar consultas ao banco de dados;
* Aplicar conceitos de programação e integração com banco de dados.

## ⚙️ Funcionalidades

### Cadastro de Alunos

O sistema permite inserir os dados necessários para realizar o cadastro de um novo aluno.

Antes de realizar o cadastro, o sistema verifica se o aluno já possui um registro no banco de dados, evitando duplicidade.

### Verificação de Cadastro

O usuário poderá consultar se determinado aluno já está cadastrado no sistema.

Caso o aluno já esteja registrado, o sistema deverá informar que o cadastro existe.

Caso não esteja, o sistema poderá indicar que o aluno ainda não possui cadastro.

### Banco de Dados

Os dados são armazenados em um banco de dados **SQL Server**, permitindo que as informações permaneçam salvas mesmo após o encerramento da aplicação.

A comunicação entre a aplicação C# e o banco de dados será realizada por meio de uma conexão com o SQL Server.

## 🛠️ Tecnologias Utilizadas

* **C#**
* **.NET**
* **Windows Forms**
* **SQL Server**
* **SQL**
* **Visual Studio**
* **Git e GitHub**

## 🗄️ Banco de Dados

O projeto utiliza o **SQL Server** para armazenamento dos dados.

A estrutura do banco será responsável por armazenar as informações dos alunos e permitir operações de consulta e cadastro.

Exemplo de estrutura inicial:

| Campo  | Tipo    | Descrição                   |
| ------ | ------- | --------------------------- |
| `id`   | INT     | Identificador do aluno      |
| `nome` | VARCHAR | Nome do aluno               |
| `ra`   | VARCHAR | Registro Acadêmico do aluno |

> A estrutura da tabela poderá ser alterada conforme os requisitos definidos durante o desenvolvimento do PIM IV.

## 🖥️ Interface

A interface da aplicação será desenvolvida utilizando **Windows Forms**, proporcionando uma aplicação desktop simples e intuitiva.

Entre os elementos previstos estão:

* Campos para inserção dos dados do aluno;
* Botão para realizar o cadastro;
* Botão para consultar/verificar cadastro;
* Mensagens de confirmação ou alerta;
* Área para exibição dos resultados da consulta.

## 🔄 Funcionamento Básico

O fluxo principal do sistema será:

```text
┌──────────────────────┐
│      Iniciar         │
│      Sistema         │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ Inserir dados do     │
│      aluno           │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ Consultar SQL Server │
│   para verificar     │
│ cadastro existente   │
└──────────┬───────────┘
           │
       ┌───┴────┐
       │        │
      SIM      NÃO
       │        │
       ▼        ▼
┌───────────┐ ┌──────────────┐
│ Informar   │ │ Realizar o   │
│ cadastro   │ │ cadastro     │
│ existente  │ │ do aluno     │
└───────────┘ └──────────────┘
```

## 📁 Estrutura do Projeto

A estrutura poderá seguir uma organização semelhante a:

```text
PIM-IV/
│
├── BancoDeDados/
│   └── Scripts.sql
│
├── Forms/
│   └── FormCadastro.cs
│
├── Models/
│   └── Aluno.cs
│
├── Data/
│   └── Conexao.cs
│
├── Program.cs
│
└── README.md
```

A organização dos arquivos poderá ser modificada conforme a evolução do projeto.

## 🚀 Como Executar o Projeto

### 1. Pré-requisitos

Para executar o projeto, será necessário ter instalado:

* Visual Studio;
* .NET compatível com o projeto;
* SQL Server;
* SQL Server Management Studio (SSMS), caso seja necessário administrar o banco.

### 2. Banco de Dados

Primeiramente, execute o script SQL disponibilizado no projeto para criar o banco de dados e suas respectivas tabelas.

Depois, configure a string de conexão utilizada pela aplicação C# para acessar o SQL Server.

### 3. Executar a Aplicação

Abra o arquivo da solução (`.sln`) no Visual Studio.

Em seguida:

1. Verifique a configuração da conexão com o SQL Server;
2. Certifique-se de que o banco de dados está disponível;
3. Compile o projeto;
4. Execute a aplicação.

## 🔐 Validação de Cadastro

Um dos principais objetivos do sistema é evitar que um mesmo aluno seja cadastrado mais de uma vez.

Para isso, antes de inserir um novo registro, a aplicação realizará uma consulta no banco de dados para verificar a existência do aluno.

A validação poderá utilizar, por exemplo, o **RA (Registro Acadêmico)** como identificador único.

## 📚 Conceitos Aplicados

Durante o desenvolvimento serão aplicados conceitos estudados ao longo do curso, como:

* Programação Orientada a Objetos;
* Classes e objetos;
* Encapsulamento;
* Métodos;
* Variáveis e tipos de dados;
* Estruturas condicionais;
* Manipulação de eventos;
* Windows Forms;
* Comandos SQL;
* Conexão entre C# e SQL Server;
* Operações de consulta e inserção de dados;
* Validação de informações.

## 👨‍💻 Desenvolvimento

Projeto desenvolvido para fins acadêmicos como parte do **PIM IV — Projeto Integrado Multidisciplinar** da **UNIP**.

---

**PIM IV — Sistema de Cadastro de Alunos**

*C# • Windows Forms • SQL Server*
