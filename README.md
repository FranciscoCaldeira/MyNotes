# NoteAPP
Projeto prático de DIS

O NoteApp permite guardar as tuas notas mais confidenciais.

# Problema

É detetado um problema constante no meu local de trabalho que é a falta de segurança nas notas que os colaboradores tiram para o seu bloco de notas físico. A confidencialidade destas notas é uma questão importante, e muita das vezes colocamos em risco este fator ao deixar o bloco de notas perto do computador ou até mesmo guardando numa gaveta que não tem chave para a trancar.
	De forma a contornar este problema, esta solução permite que o utilizador disponha das suas notas em qualquer momento e lugar, mas também que as suas notas possam ficar encriptadas, tornando difícil a sua leitura sem a desencriptação.

# Utilização da aplicação

A aplicação inicia com o formulário de login para o bloco de notas, aqui o visitante pode ver o separador Ajuda para obter informações da aplicação ou clicar no separador de Registo. Clicando no separador de Registo o visitante pode registar uma conta para aceder à aplicação. A conta registada não necessita de aceder ao email para ser validada, podendo iniciar logo a sessão na aplicação. 
Ao efetuar o login como utilizador registado é direcionado para um bloco de notas muito parecido ao do Windows. Aqui, um utilizador registado, pode utilizar as ferramentas  de edição do texto que um bloco de notas oferece e adicionalmente pode ir ao separador Encriptação, pode efetuar o pagamento de subscrição de serviço, enviar comentários, ver a ajuda e fazer Logout neste bloco de notas.
	Na primeira vez que o utilizador clicar na ferramenta de Encriptação é pedido para inserir uma nova password (esta password será a utilizada para encriptar e desencriptar). Após o bom sucesso, abre uma nova janela à parte do bloco de notas, podendo utilizar o bloco de notas e a janela de encriptação/desencriptação livremente.
  Para dar início às ações de encriptação/desencriptação, o utilizador precisa colocar a sua password no Login da janela, assim que iniciar sessão nesta área, pode encriptar/desencriptar pastas e ficheiros. Para alterar a password, basta ir ao separador de altera password, e inserir a sua password atual. Irá aparecer posteriormente um formulário para introduzir a nova password para a encriptação/desencriptação das pastas e ficheiros.

# Análise da Solução

Na implementação da proposta, era obrigatório desenvolver a solução utilizando o C#, mas também adotar os princípios de desenho, os padrões arquiteturais, os padrões de desenho estudados na UC e apresentar código com qualidade. 
	Inicialmente como a linguagem de C# era pouco utilizada no dia-a-dia, houve algumas dificuldades de adaptação à linguagem e até mesmo ao IDE Visual Studio 2019, devido à sua complexidade/extensão de botões e menus. Sendo assim, foi necessário ler a documentação da linguagem para ter noção da lógica aplicada, que mais tarde, depois de perceber, foi simples utilizar o drag-and-drop dos formulários do Windows Form App utilizando a framework .NET e de implementar as funções normais de um bloco de notas que até vinham por defeito na própria framework (ex: Undo(), Redo(), Cut(), Copy(), SelectAll() etc..).
	EsWindows ta aplicação apresenta um layout demasiado simples e muito repetitivo do Windows, devido ao layout por defeito do Windows Form sendo assim foi utilizado a biblioteca MetroModernUI que é relativamente simples de adicionar à Caixa de ferramentas (ou toolbox), dando outro realce à parte fulcral do trabalho. Esta biblioteca é compatível com todos os sistemas Windows, desde o Windows XP até ao Windows 10. 
	É utilizado também a biblioteca CyberCrypt 1.0.0 para encriptação/desencriptação das pastas e ficheiros. A password inserida inicialmente na ferramenta de encriptação/desencriptação não é registada na base de dados, mas sim na própria máquina local, no diretório “C:\ProgramData\NoteApp\”, onde é criado um ficheiro e inserido a password que depois é encriptado com uma password por defeito da aplicação. É da mesma forma a listagem das pastas que foram trancadas pelo utilizador.
  É utilizado o SQL Server 2014 para fazer a gestão dos utilizadores, mas também guardar quais os utilizadores que subscreveram ao serviço.
	Por fim, a solução apresentada cumpre com o que foi apresentado na apresentação inicial do projeto prático, apesar de haver falhas na complexidade querendo ainda implementar uma agenda/calendário para que eu (ex: apresentador de uma reunião) insira os participantes e automaticamente, apresente no calendário dos participantes sem que estes tivessem a necessidade de inserir manualmente o dia e hora, entre mais funcionalidades ao bloco de notas(traduções para as várias línguas).

<b>DIS NoteAPP - version 1.0.0 (beta) </b>
