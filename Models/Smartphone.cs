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
        public Smartphone(string numero, int memoria)
        {
            Numero = numero;
            IMEI = AttributesHelper.GenerateIMEI();
            Memoria = memoria;
        }
        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
