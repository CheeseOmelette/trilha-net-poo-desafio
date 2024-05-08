using DesafioPOO.Models;



Console.WriteLine("Este é o Iphone");
Smartphone iphone = new Iphone(numero: "999999", modelo: "15 Pro", imei: "13914120", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Netflix");

Console.WriteLine("\n");

Console.WriteLine("Este é o Nokia");
Smartphone nokia = new Nokia(numero: "666666", modelo: "Modelo 1", imei: "2141512", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");



// TODO: Realizar os testes com as classes Nokia e Iphone