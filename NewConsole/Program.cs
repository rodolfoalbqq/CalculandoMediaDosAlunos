double a = 0;
double b = 0;
double c = 0;
double d = 0;
double e = 0;

Console.WriteLine("Informe a 1° nota");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a 2° nota");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a 3° nota");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a 4° nota");
d = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a 5° nota");
e = Convert.ToDouble(Console.ReadLine());

double media = (a + b + c + d + e) / 5;
Console.WriteLine("A média de nota é " + media);
