# Teste de Programação

## Necessidade:
Desenvolver uma aplicação para catálogo de uma biblioteca, onde teremos que controlar os livros cadastrados.
As informações que deverão ser armazenadas são as seguintes:
 - Para os Livros:
    - Nome do Livro, Edição, Data de Lançamento, Editora e Autor.
- Para as Editoras:
  - CPNJ (com validação se é valido ou não) Nome, endereço completo.
- E para os Autores:
  - Nome, CPF (com validação se é valido ou não), celular, e-mail.

## Funcionalidades:
- Deverá ser criado um CRUD para Livros, Editoras e Autores;
- Todos os cadastros deverão ter uma lista onde consiga consultar pelos campos listados;
- Na lista dos objetos ter um botão para editar e excluir o item selecionado;
- Podem ser utilizados plugins para o frontend;

Esse projeto está em .Net Core 2.1 com EF Core 2.1 e o Banco de dados será o SQL Server,
realizar o migration para criação das tabelas no BD.
