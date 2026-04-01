PIM

Projeto Integrado Multidisciplinar realizado no curso de Análise e Desenvolvimento de Sistemas da Universidade Paulista.

Desenvolvedor
Pedro Henrique Matias Cansanção Alves

Documentação do Software

Propósito:
O software desenvolvido no Projeto Integrado Multidisciplinar (PIM) tem como objetivo oferecer uma solução funcional para o gerenciamento de uma biblioteca. O sistema permite cadastrar livros e usuários, consultar livros e usuários cadastrados, realizar empréstimos, registrar devoluções, listar empréstimos e visualizar empréstimos pendentes, além de apresentar indicadores no menu principal com totais atualizados.

Documentação do Projeto:
O sistema foi desenvolvido para ser simples, prático e intuitivo, facilitando o uso por parte do bibliotecário. A interface foi construída em Windows Forms, com telas organizadas por funcionalidade, proporcionando melhor experiência de uso e navegação.

Para a instalação do software, é disponibilizado um arquivo com extensão ".exe", permitindo sua execução diretamente em ambiente Windows. Ao clicar duas vezes sobre o arquivo, o sistema é iniciado.

Sobre o Código:
O software foi desenvolvido na linguagem C#, utilizando Windows Forms para a criação da interface gráfica. O projeto foi estruturado com base em conceitos de orientação a objetos, separando as classes de dados das telas do sistema.

Foram utilizadas bibliotecas da linguagem C#, entre elas:

- System: responsável por funcionalidades básicas da linguagem.
- System.Linq: utilizada para buscas e filtragens nas listas de livros, usuários e empréstimos.
- System.Windows.Forms: utilizada para criação das telas, controles e interação com o usuário.
- System.Drawing: utilizada na personalização visual da interface.
- System.Globalization: utilizada em validações de datas, especialmente para o controle de atrasos.

Estrutura do Sistema:
Para organizar os dados, foram utilizadas classes específicas:

- Livro: armazena nome, autor, gênero, ano, ISBN e status.
- Usuario: armazena nome e CPF.
- Emprestimo: relaciona usuário e livro, armazenando também a data de devolução e o status de devolvido.
- Banco: classe estática responsável por armazenar em memória as listas de livros, usuários e empréstimos.

Tela de Login:
O sistema possui uma tela de login para controle de acesso. Nela, o usuário informa login e senha para acessar o software. Caso os dados estejam corretos, o menu principal é exibido; caso contrário, uma mensagem de erro é apresentada.

Funcionalidade de Cadastro de Livros:
No cadastro de livros, o sistema solicita o preenchimento dos campos nome, autor, gênero, ano e ISBN. Após a validação dos dados, um novo objeto do tipo Livro é criado e adicionado à lista Banco.Livros. O livro é cadastrado com status disponível.

Funcionalidade de Cadastro de Usuários:
No cadastro de usuários, o sistema solicita informações como nome e CPF. Após a validação dos dados, um novo objeto do tipo Usuario é criado e adicionado à lista Banco.Usuarios.

Funcionalidade de Consulta de Livros:
A consulta de livros exibe todos os livros cadastrados em uma tabela (DataGridView), mostrando nome, autor, ano, ISBN, gênero e status de disponibilidade. O sistema também utiliza indicadores visuais para facilitar a identificação dos livros disponíveis ou indisponíveis.

Funcionalidade de Consulta de Usuários:
A consulta de usuários exibe os usuários cadastrados em uma tabela, apresentando informações como nome e CPF.

Funcionalidade de Realização de Empréstimo:
Para realizar um empréstimo, o sistema solicita o CPF do usuário, o ISBN do livro e a data de devolução. O sistema valida a existência do usuário, localiza o livro cadastrado e verifica se ele está disponível. Quando o empréstimo é realizado com sucesso, um novo objeto do tipo Emprestimo é criado, adicionado à lista Banco.Emprestimos, e o status do livro é alterado para indisponível.

Funcionalidade de Registro de Devolução:
Na devolução, o sistema solicita o CPF do usuário e o ISBN do livro. Após localizar o empréstimo pendente correspondente, o sistema marca o empréstimo como devolvido e altera o status do livro para disponível novamente.

Funcionalidade de Empréstimos Pendentes:
A tela de empréstimos pendentes apresenta todos os empréstimos que ainda não foram devolvidos, permitindo ao usuário acompanhar os registros em aberto.

Atualização do Dashboard:
O menu principal do sistema exibe indicadores com total de livros, total de usuários, livros emprestados e atrasados. Esses valores são atualizados automaticamente sempre que ocorre uma operação de cadastro, empréstimo ou devolução.

Função Principal:
A execução do sistema inicia pela tela de login. Após a validação do acesso, o usuário é direcionado ao menu principal, que centraliza o acesso às demais funcionalidades do software.
