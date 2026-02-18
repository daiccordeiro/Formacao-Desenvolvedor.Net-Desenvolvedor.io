namespace Cadastro
{
    public interface INotificacao
    {
        string Descricao {get;set;}
        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando Cliente");
        }

         public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando Funcionario");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificando Outros");
        }
    }
}