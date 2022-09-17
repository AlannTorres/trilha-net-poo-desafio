using DesafioPOO.Models;

Nokia S1 = new Nokia(numero: "8879238747", modelo: "S42", imei: "1823ASDF213", memoria: 2);
Console.WriteLine("Smartphone Nokia, Numero: " + S1.Numero);
S1.Ligar();
S1.ReceberLigacao();
S1.InstalarAplicativo("Play Store");

Console.WriteLine("\n");

Iphone S2 = new Iphone(numero: "87996371982", modelo: "13", imei: "23827ASNC34", memoria: 4);
Console.WriteLine("Smartphone Iphone, Numero: " + S2.Numero);
S2.Ligar();
S2.ReceberLigacao();
S2.InstalarAplicativo("ITunes");

