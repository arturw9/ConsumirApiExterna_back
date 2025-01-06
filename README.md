Guia de Uso do Projeto
Este projeto tem como objetivo consumir dados de uma API externa, armazená-los em um banco de dados, além de fornecer funcionalidades para listar e editar esses dados.

Tecnologias Utilizadas
Front-End
HTML 5
JavaScript
Bootstrap
Back-End
C# com Entity Framework
Arquitetura: Segue os padrões DDD, Microservices, e Clean Code.
Banco de Dados
PostgreSQL
Configuração do Projeto
Banco de Dados
Configure a conexão com o banco de dados na variável DefaultConnection, localizada no arquivo appsettings.json do projeto back-end. Altere conforme necessário para se adequar às suas credenciais e configurações.

Endpoints Disponíveis

/Usuarios/BuscarUsuariosApi
Consome os dados de uma API externa e os insere no banco de dados.
/Usuarios/Listar
Lista os usuários armazenados no banco de dados.
/Usuarios/Editar
Edita os dados de um usuário específico.
Execução do Projeto

Após clonar o repositório, abra o projeto no Visual Studio.
Certifique-se de realizar a migração inicial para criar e atualizar as tabelas no banco de dados.
Use o botão "Debug" no Visual Studio para iniciar o projeto.
População Inicial do Banco de Dados
Antes de rodar o projeto, utilize o endpoint /Usuarios/BuscarUsuariosApi através do Swagger para inserir os dados iniciais no banco de dados.

Observações Importantes
Migração do Banco de Dados
Antes de iniciar o projeto, execute as migrações necessárias para configurar as tabelas no banco de dados.

Inserção de Dados
Após configurar a conexão com o banco de dados, use o Swagger para consumir a API externa e preencher os dados no banco de dados, utilizando o endpoint /Usuarios/BuscarUsuariosApi.
