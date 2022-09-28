using DesafioPOO.Models;


Smartphone n1 = new Nokia(numero: "222",modelo: "Lumia 930",imei: "111",memoria: 256);
Console.WriteLine($"Usando {n1.Modelo}");
n1.Ligar();
n1.InstalarAplicativo("ZapZap");
n1.ReceberLigacao();
Console.WriteLine("\n");

Smartphone i1 = new Iphone(numero: "444",modelo: "Iphone X",imei: "333",memoria: 128);
Console.WriteLine($"Usando {i1.Modelo}");
i1.Ligar();
i1.InstalarAplicativo("OneDrive");
i1.ReceberLigacao();
