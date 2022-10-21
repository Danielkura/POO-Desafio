using DesafioPOO.Models;

Console.WriteLine("Nokia");
Nokia n = new Nokia("11111-1111", "a1", "1111", 64);
Console.WriteLine($"Numero {n.Numero}");
n.Ligar();
n.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone i = new Iphone("22222-2222", "b2", "2222", 128);
Console.WriteLine($"Numero {i.Numero}");
i.ReceberLigacao();
i.InstalarAplicativo("Facebook");