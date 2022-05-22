// Найти сумму чисел от 1 до a
Console.Write("Enter your number: ");
int a = int.Parse(Console.ReadLine()??"0");
int sum = 0;
for (int i=1;i<=a;i++)
{
    sum=sum+i;
}
Console.Write($"The sum of numbers from 1 to {a}: {sum}");
