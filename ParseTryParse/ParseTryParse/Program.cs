var valor1 = int.Parse("123");
var valor2 = bool.Parse("true");
var valor3 = DateTime.Parse("01/01/2001");


Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

var deuCerto = int.TryParse("8910", out var valor);
Console.WriteLine("\b");

Console.WriteLine("TryParse");
Console.WriteLine(deuCerto);
Console.WriteLine(valor);


Console.ReadLine();