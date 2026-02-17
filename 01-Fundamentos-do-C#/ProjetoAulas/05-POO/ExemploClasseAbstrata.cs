  namespace Cadastro
{
  public abstract class Animal
  {
    public string Nome {get;set;}

    public abstract string GetInformacoes();

    public virtual void ImprimirDados()
    {
      Console.WriteLine("Nome animal: " + Nome);
      Console.WriteLine("Informacoes: " + GetInformacoes());
    }
  }

  public class Cachorro : Animal
  {
    public override string GetInformacoes()
    {
      return "Cachorro é um bom amigo";
    }

    public override void ImprimirDados()
    {
      base.ImprimirDados();
      Console.WriteLine("Metodo chamando dentro da classe cachorro");
    } 
  }   
}