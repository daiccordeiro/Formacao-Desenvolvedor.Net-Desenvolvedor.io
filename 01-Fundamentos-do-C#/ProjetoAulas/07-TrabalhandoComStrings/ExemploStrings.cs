namespace Strings;

public class TrabalhandoComStrings
{
    //ToLower
    public void AulaToLower()
    {
        Console.Write("- ToLower: \n");

        Console.Write("Digite seu nome em letras Maiúsculas: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }

    //ToUpper
    public void AulaToUpper()
    {
        Console.Write("- ToUpper: \n");

        Console.Write("Digite seu nome em letras Minúsculas: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

    //Substring
    public void AulaSubstring()
    {
        Console.Write("- Substring: \n");

        Console.Write("Digite seu Nome Completo: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(6));
    }

    //Range [..]
    public void AulaRange()
    {
        Console.Write("- Range: \n");

        string nomeArquivo = "2026_02_17_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);

        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }

    //Contains
    public void AulaContains()
    {   
        Console.Write("- Contains: \n");

        string nomeArquivo = "2026_02_17_backup.bak"; 
        
        if(nomeArquivo.Contains("backup_teste"))
        {
            Console.WriteLine("Palavra encontrada");
        } else {
            Console.WriteLine("Palavra nao encontrada");
        }
        //Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));
    }

    //Trim
    public void AulaTrim()
    {
        Console.Write("- Trim: \n");

        string teste = "**DAIANE CORDEIRO**"; 
        
        Console.WriteLine("TOTAL: " + teste.Trim('*'));
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));
        Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
    }

    //StartsWith e EndsWith
    public void AulaStartWithEndsWith()
    {
        Console.Write("- StartsWith e EndsWith: \n");

        string teste = "Curso Csharp"; 
        
        Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
        Console.WriteLine("FINAL: " + teste.EndsWith("Csharp2026"));
    }

    //Replace
    public void AulaReplace()
    {
        Console.Write("- Replace: \n");

        string teste = "Curso Csharp";  
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Csharp", "C#"));
    }

    //Length
    public void AulaLength()
    {
        Console.Write("- Length: \n");

        Console.Write("Digite seu Nome Completo: ");
        string teste = Console.ReadLine(); 
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);
    }
}