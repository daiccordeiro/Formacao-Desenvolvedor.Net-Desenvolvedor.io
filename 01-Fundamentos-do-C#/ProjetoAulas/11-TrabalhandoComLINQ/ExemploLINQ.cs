namespace Linq;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        Console.Write("Filtro WHERE: \n");

        string nomeCompleto = "DAIANE CRISTINA";        
        
        Func<char, bool> filtro = c => c == 'A';        
        
        // Sintaxe de Método
            //var resultado = nomeCompleto.Where(p => p == 'A');
            //var resultado = nomeCompleto.Where(filtro);        

        //  Sintaxe de Consulta
        var resultado = from c in nomeCompleto where c == 'I' select c;

        foreach(var letra in resultado)
        {
            Console.WriteLine(letra);
        }

        Console.Write("Filtro WHERE com Números: \n");

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var resultadoN = numeros.Where(p => p >= 10);
        foreach(var numero in resultadoN)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaOrdenacao()
    {   
        Console.Write("Filtro ORDER BY: \n");

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var resultado = numeros.OrderByDescending(p => p);
        //var resultado = numeros.OrderBy(p => p);
        
        var nomes = new string[] { "Daiane", "Cristina", "Cordeiro"};
        //var resultado = nomes.OrderByDescending(p => p);        

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaTake()
    {   
        Console.Write("Filtro TAKE: \n");

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};        
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    {
        Console.Write("Filtro COUNT: \n");

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};        
        var resultado = numeros.Count(p => p > 10);

        Console.WriteLine(resultado);
    }
    
    public void AulaFirstEFirstOrDefault()
    {   
        Console.Write("Filtro First e FirstOrDefault: \n");

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};        
        //var resultado = numeros.First();
        //var resultado = numeros.First(p => p > 100);
        var resultado = numeros.FirstOrDefault(p => p > 100, -99);
 
        Console.WriteLine(resultado);
    }
}