using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
/*            Console.WriteLine("Meu Primeiro Programa!");

            //01-HandsOnCode
            //Variaveis.cs
            Console.WriteLine("Exemplo de variáveis:");
            Variaveis.ExibirVariaveis();

            //Constantes.cs
            Console.WriteLine("Exemplo de constantes:");
            Constantes.ExibirConstantes();

            //OpAritmeticos.cs
            Console.WriteLine("Exemplo de operadores aritméticos:");
            OpAritmeticos.ExibirOpAritmeticos();

            //OpRelacionais.cs
            Console.WriteLine("Exemplo de operadores relacionais:");
            OpRelacionais.ExibirOpRelacionais();

            //OpLogicos.cs
            Console.WriteLine("Exemplo de operadores lógicos:");
            OpLogicos.ExibirOpLogicos();

            //OpTernario.cs
            Console.WriteLine("Exemplo de operador ternário:");
            OpTernario.ExibirOpTernario();


            //02-Funções
            //funNomeCompleto.cs
            Console.WriteLine("Exemplo de Função:");
            FunNomeCompleto.ExibirFuncaoNomeCompleto();

            //funParametros.cs
            Console.WriteLine("Exemplo de Função com Parâmetros:");
            FunParametros.ExibirFuncaoParametros();


            //03-Estrutura de Dados
            //ArrayList.cs
            Console.WriteLine("Exemplo de ArrayList:");
            ExemploArrayList.ExibirArrayList();

            //ArrayTipado.cs
            Console.WriteLine("Exemplo de ArrayTipado:");
            ExemploArrayTipado.ExibirArrayTipado();

            //Lista.cs
            Console.WriteLine("Exemplo de Lista:");
            ExemploLista.ExibirLista();

            //Dicionario.cs
            Console.WriteLine("Exemplo de Dicionário:");
            ExemploDicionario.ExibirDicionario();

            //Fila.cs
            Console.WriteLine("Exemplo de Fila:");
            ExemploFila.ExibirFila();

            //Pilha.cs
            Console.WriteLine("Exemplo de Pilha:");
            ExemploPilha.ExibirPilha();


            //04-Estrutura de Controle
            //ExemploIFeElse.cs
            Console.WriteLine("Exemplo de IF e Else:");
            ExemploIFeElse.ExibirIFeElse();

            //ExemploSwitch.cs
            Console.WriteLine("Exemplo de Switch:");
            ExemploSwitch.ExibirSwitch();

            //ExemploFor.cs
            Console.WriteLine("Exemplo de FOR:");
            ExemploFor.ExibirFor();

            //ExemploForEach.cs
            Console.WriteLine("Exemplo de ForEach:");
            ExemploForEach.ExibirForEach();

            //ExemploWhile.cs
            Console.WriteLine("Exemplo de While:");
            ExemploWhile.ExibirWhile();

            //ExemploBreakeContinue.cs
            Console.WriteLine("Exemplo de Break e Continue:");
            ExemploBreakeContinue.ExibirBreakeContinue();


            //05-POO - Programação Orientada a Objetos
            //ExemploClasse.cs
            Console.WriteLine("Exemplo de Classes:");
            AulaClasses();
            AulaPropSomenteLeitura();

            //ExemploHeranca.cs
            Console.WriteLine("Exemplo de Herança:");
            AulaHeranca();

            //ExemploClasseSelada.cs
            Console.WriteLine("Exemplo de Classe Selada:");
            AulaClasseSelada();

            //ExemploClasseAbstrata.cs
            Console.WriteLine("Exemplo de Classe Abstrata:");
            AulaClasseAbstrata();

            //ExemploRecord.cs
            Console.WriteLine("Exemplo de Record:");
            AulaRecord();

            //ExemploInterface.cs
            Console.WriteLine("Exemplo de Interface:");
            AulaInterface();

        
            //06-ConversoresDeValor
            //ExemploConversores.cs
            Console.WriteLine("Exemplo de Conversores:");
            AulaConversores();    


            //07-TrabalhandoComStrings
            //ExemploStrings.cs
            Console.WriteLine("Exemplo de Strings:");
            AulaStrings();   


            //08-TrabalhandoComDatas
            //ExemploDatas.cs
            Console.WriteLine("Exemplo de Datas:");
            AulaDatas();          


            //09-TrabalhandoComExcecoes
            //ExemploExcecoes.cs
            Console.WriteLine("Exemplo de Exceções:");
            AulaExcecoes();


            //10-TrabalhandoComArquivos
            //ExemploArquivos.cs
            Console.WriteLine("Exemplo de Arquivos:");
            AulaArquivos();

*/
            //11-TrabalhandoComLINQ
            //ExemploLINQ.cs
            Console.WriteLine("Exemplo de LINQ:");
            AulaLINQ();
        }


/* ---------------------------------------------------------------- */
/* ---------------------------------------------------------------- */

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2,3);
            Console.WriteLine(resultado);
            
            var produto = new Cadastro.Produto();
            produto.SetId(1);   
            

            produto.Descricao = "Teclado";
            produto.ImprimirDescricao();
            //Console.WriteLine(produto.GetId());            
        }

        private static void AulaPropSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            //produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);
            

            produto.Descricao = "Mouse";            
            produto.ImprimirDescricao();                        
        }

        private static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Endereço Teste";
            pessoaFisica.Cidade = "Cidade Teste";
            pessoaFisica.Cep = "12345612";
            pessoaFisica.CPF = "12345678910";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
        }

        private static void AulaClasseSelada()
        {
            /*var configuracao = new Cadastro.Configuracao();
            configuracao.Host = "localhost";
            */

            var configuracao = new Cadastro.Configuracao
               {
                  Host = "localhost"
               };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro(); 
             cachorro.Nome = "Dog"; 
             cachorro.ImprimirDados();
        }

        private static void AulaRecord()
        {
            //var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};
            //var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};                    

            var curso1 = new Cadastro.Curso (1,"Curso");
            //var curso2 = new Cadastro.Curso (1,"Curso");
            var curso2 = curso1 with { Descricao = "Teste Novo"};

            //var curso1 = new Cadastro.CursoTeste  { Id = 1, Descricao = "Curso"};            
            //var curso2 = curso1;
            //curso2.Descricao = "TESTE TESTE";
            //var curso2 = new Cadastro.CursoTeste();             
            //curso2.Id = curso1.Id;
            //curso2.Descricao = "Nova descricao";
             

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);
            //Console.WriteLine(curso1.Equals(curso2));
            //Console.WriteLine(curso1 == curso2);            
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
        }

        private static void AulaConversores()
        {
           var conversores = new Conversores.Conversor();
           //conversores.ConvertAndParse();
           conversores.AulaTryParse();
        }

        private static void AulaStrings()
        {
            var trabalhandoComStrings = new Strings.TrabalhandoComStrings();
            trabalhandoComStrings.AulaToLower();            
            trabalhandoComStrings.AulaToUpper();          
            trabalhandoComStrings.AulaSubstring();            
            trabalhandoComStrings.AulaRange();     
            trabalhandoComStrings.AulaContains();
            trabalhandoComStrings.AulaTrim();            
            trabalhandoComStrings.AulaStartWithEndsWith();
            trabalhandoComStrings.AulaReplace();
            trabalhandoComStrings.AulaLength();      
        }

        private static void AulaDatas()
        {
            var trabalhandoComDatas = new Datas.TrabalhandoComDatas();
            trabalhandoComDatas.AulaDateTime();
            trabalhandoComDatas.AulaSubtraindoDatas();
            trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundos();
            trabalhandoComDatas.AulaDiaDaSemana();
            trabalhandoComDatas.AulaDateOnly();
            trabalhandoComDatas.AulaTimeOnly();
        }

        private static void AulaExcecoes()
        {
                var trabalhandoComExcecoes = new Excecoes.TrabalhandoComExcecoes();
                //trabalhandoComExcecoes.AulaGerandoException();
                trabalhandoComExcecoes.AulaTratandoException();
        }

        private static void AulaArquivos()
        {
                var trabalhandoComArquivos = new Arquivos.TrabalhandoComArquivos();
                trabalhandoComArquivos.AulaCriandoArquivo();
                //trabalhandoComArquivos.AulaLendoArquivo();
                //trabalhandoComArquivos.AulaExcluindoArquivo();
        }

        private static void AulaLINQ()
        {
            var trabalhandoComLinq = new Linq.TrabalhandoComLinq();
                trabalhandoComLinq.AulaWhere();
                trabalhandoComLinq.AulaOrdenacao();
                trabalhandoComLinq.AulaTake();
                trabalhandoComLinq.AulaCount();
                trabalhandoComLinq.AulaFirstEFirstOrDefault();
        }
    }
}