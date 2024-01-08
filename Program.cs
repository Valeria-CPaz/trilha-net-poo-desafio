using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone(numero:"98761234", modelo:"Iphone 4S", imei:"111222333", memoria:128);
Console.WriteLine("Smartphone Iphone:");
iphone.Ligar();
iphone.InstalarAplicativo("Kindle");

Console.WriteLine("\n");

Smartphone nokia = new Nokia(numero:"55556666", modelo:"Nokia B2", imei:"33332222", memoria:256);
Console.WriteLine("Smartphone Nokia:");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Candy Crush");
