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
        //É possível que outros contrutores sejam criado, mas passando uma quantidade diferente de parêmtros. Cada smartphone tem os seus (ou não os tem)
        public Smartphone(string numero, int memoria, string imei)
        {
            Numero = numero;
            IMEI = imei;
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
