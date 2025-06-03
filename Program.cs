using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("");

Console.WriteLine("Testando iPhone:");
Smartphone iphone = new Iphone("123456", "Modelo 1", "111111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");