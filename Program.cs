using DesafioPOO.Models;

// Implementado - Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"12341", modelo:"iPhone 4", imei:"121212121", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"67896", modelo:"Nokia Lumia 800", imei:"343434343", memoria:64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");