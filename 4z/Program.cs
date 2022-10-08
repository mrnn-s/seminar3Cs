//Определить количество цифр в числе

Console.WriteLine("enter number");
int number = int.Parse(Console.ReadLine() ?? "0");
int index=0;
while (number>0)
{
    number= number/10;
    index++;
}
Console.WriteLine(index);