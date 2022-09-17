using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var iPhone = new Iphone(numero: "62991170993" ,memoria: 64, "iPhone 13");
var nokia = new Nokia(numero: "62991170993", memoria: 128, "Nokia Lumia 630");

Console.WriteLine("Iniciaremos os testes no iPhone");
await Task.Delay(1000);

await iPhone.Ligar();
await iPhone.ReceberLigacao();
await iPhone.InstalarAplicativo("Angry Birds");

Console.WriteLine("\nAgora iniciaremos os testes no Nokia");
await Task.Delay(2000);

await nokia.Ligar();
await nokia.ReceberLigacao();
await nokia.InstalarAplicativo("Subway Surfers");

Console.WriteLine("O programa encerarrá em 10 segundos");
await Task.Delay(10000);