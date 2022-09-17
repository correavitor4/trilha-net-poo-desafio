using DesafioPOO.Helpers;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, int memoria) : base(numero, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Iniciando instalação do aplicativo no dispositivo iPhone...");
            Task.Delay(2000);
            Console.WriteLine("Aplicativo instalado com sucesso!");
        }
    }
}