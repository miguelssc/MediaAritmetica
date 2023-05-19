Console.WriteLine("digite a primeira nota");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite a segunda nota");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite a terceira nota");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());
decimal notafinal =(nota1 + nota2 + nota3);
decimal mediafinal =(notafinal / 3);
Console.WriteLine(mediafinal);