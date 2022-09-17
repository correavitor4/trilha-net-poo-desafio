using DesafioPOO.Helpers;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        //Contrutor que gera aleatoriamente um IMEI
        public Smartphone(string numero, int memoria, string modelo)
        {
            Numero = numero;
            IMEI = AttributesHelper.GenerateIMEI();
            Memoria = memoria;
            Modelo = modelo;
        }
        
        public async Task Ligar()
        {
            Console.WriteLine("Ligando...");
            await Task.Delay(2000);
            Console.WriteLine("Ele não atendeu");
        }

        public async Task ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            await Task.Delay(2300);
            Console.WriteLine("Ligação não atendida");
        }

        public abstract Task InstalarAplicativo(string nomeApp);
    }
}
