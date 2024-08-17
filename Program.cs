using DesafioPOO.Models;
Console.WriteLine("Smartphones");


Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("123456789", "Iphone 12", "123456789", 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Github");
Console.WriteLine();

Smartphone nokia = new Nokia("987654321", "Nokia 3310", "987654321", 32);
Console.WriteLine("Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
Console.WriteLine();
