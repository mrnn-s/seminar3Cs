//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("enter number");
int number = int.Parse(Console.ReadLine() ?? "0");
int index=1;
while (index<=number)
{
    Console.WriteLine(index+"^2="+Math.Pow(index,2));
    index++;
}

