namespace Datas;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        Console.Write("- DateTime: \n");

        var date1 = new DateTime(2026, 02, 18, 21, 30, 23);
        var date2 = DateTime.Parse("2026/02/18 21:30:23");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        //Formantando Datas
        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);
        //DateTimeOffset.UtcNow
    }

    public void AulaSubtraindoDatas()
    {
        Console.Write("- Subtraindo Datas: \n");

        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2026-01-01");

        //var diff = date1 - date2;
        var diff = date1.Subtract(date2);
        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine((int)diff.TotalHours);
    }

    public void AulaAdicionandoDiasMesAno()
    {
        Console.Write("- Adicionando Dias, Mes e Ano: \n");

        var date1 = DateTime.Now; 
        Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddYears(2).ToString("dd-MM-yyyy HH:mm:ss"));
    }

    public void AulaAdicionandoHoraMinutoSegundos()
    {
        Console.Write("- Adicionando Hora, Minuto e Segundos: \n");

        var date1 = DateTime.Now; 
        Console.WriteLine(date1.ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));
    }

    public void AulaDiaDaSemana()
    {
        Console.Write("- Dia da Semana: \n");

        var date1 = DateTime.Now;  
        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        Console.Write("- DateOnly: \n");

        //var somenteData = new DateOnly(2026,02,18);
        var somenteData =  DateOnly.Parse("2026-02-18");        
        Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
    }
    
    public void AulaTimeOnly()
    {   Console.Write("- TimeOnly: \n");

        //var outraVariavel = new TimeOnly(21,50,25,0);
        var somenteHora =  TimeOnly.Parse("21:50:23");        
        Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
    }
}