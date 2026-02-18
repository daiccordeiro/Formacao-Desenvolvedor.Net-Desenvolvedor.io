namespace Cadastro
{
    public record Curso(int Id, string Descricao);
    
    public class CursoTeste
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
    }
    
    /*public record Curso
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }

        
        //Record implementa basicamente tudo que está comentado abaixo...
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }

            return base.Equals(obj);
        }

        public static bool operator == (Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Curso a, Curso b)
        {
            return !(a == b);
        }
    }*/
}