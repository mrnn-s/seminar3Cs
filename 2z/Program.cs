//Найти сумму чисел от 1 до A
Console.WriteLine("enter number");
int number = int.Parse(Console.ReadLine() ?? "0");
int count=1;
int sum=0;
while (count <= number)
{
    sum=sum+count;
    count++;
    Console.WriteLine(sum);
}