namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {


        public override async Task InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no dispositivo Nokia");
            await Task.Delay(5000);
            Console.WriteLine("O aplicativo foi verificado e instalado com sucesso!");
        }

        public Nokia(string numero, int memoria, string modelo) : base(numero, memoria, modelo)
        {
        }
        
    }
}