namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, int memoria) : base(numero, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo no dispositivo Nokia");
            Task.Delay(3000);
            Console.WriteLine("O aplicativo foi verificado e instalado com sucesso!");
        }
    }
}