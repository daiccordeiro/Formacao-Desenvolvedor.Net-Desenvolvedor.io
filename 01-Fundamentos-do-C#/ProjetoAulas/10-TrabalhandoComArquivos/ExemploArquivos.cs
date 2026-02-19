namespace Arquivos;

public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivo()
    {   
        Console.Write("Criando Arquivos: \n");

        var escrever = new StreamWriter("10-TrabalhandoComArquivos/Cadastro.txt", true);
        Console.Write("Informe um nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("----------------------");
        escrever.Close();
    }

    public void AulaLendoArquivo()
    {   
        Console.Write("Lendo Arquivos: \n");

        //var conteudo = File.ReadAllText("Cadastro.txt");
        //Console.WriteLine(conteudo);

        var ler = new StreamReader("10-TrabalhandoComArquivos/Cadastro.txt");
        while(!ler.EndOfStream)
        {
            var linha = ler.ReadLine();
            Console.WriteLine(linha);
        }
        ler.Close();
    }

    public void AulaExcluindoArquivo()
    {   
        Console.Write("Excluindo Arquivos: \n");

        if(File.Exists("10-TrabalhandoComArquivos/Cadastro.txt"))
        {
            File.Delete("10-TrabalhandoComArquivos/Cadastro.txt");
        }
    }
}