//Возведите число А в натуральную степень B используя цикл надо через while
Console.WriteLine("enter A");
double A= int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter B");
double B = int.Parse(Console.ReadLine() ?? "0");
double stepen=Math.Pow(A,B);
Console.WriteLine("A v stepeni B");
Console.WriteLine(stepen);
