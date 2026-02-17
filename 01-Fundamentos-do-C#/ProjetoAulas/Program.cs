using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu Primeiro Programa!");

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
        }

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
    }
}