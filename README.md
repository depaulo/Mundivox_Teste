# Mundivox_Teste
Programa feito utilizando AspNet Core em ambiente Linux para o teste de desenvolvedor back end para Mundivox.

Caso voce apague o banco de dados, lembre-se de esvrever utilizar os comandos:
1)dotnet ef migrations add InitialCreate
2)dotnet ef database update

Programa Usa o banco de dados, mas o banco de dados esta sendo criado e novos valores sao inseridos a cada inicializacao do programa, precisa colocar restricoes no nome, para que aceite cada pais apenas uma vez. (Inicialmente eu tive problemas com a criacao do banco de dados e fiz o programa sem, a logica precisa ser melhor ajustada para utilizar as funcionalidades do banco de dados)
