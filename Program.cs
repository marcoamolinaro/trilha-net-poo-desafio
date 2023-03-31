using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123","Nokia S plus", "0DA12H", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("987","Iphone 13 pro", "0ACD12", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");