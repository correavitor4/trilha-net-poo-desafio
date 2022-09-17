namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, int memoria, string imei) : base(numero, memoria, imei)
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