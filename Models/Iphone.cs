using DesafioPOO.Helpers;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        

        public override async Task InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iniciando instalação do aplicativo '{nomeApp}' no dispositivo iPhone...");
            await Task.Delay(4000);
            Console.WriteLine("Aplicativo instalado com sucesso!");
        }

        public Iphone(string numero, int memoria, string modelo) : base(numero, memoria, modelo)
        {
        }
    }
}