// Возвести число a в натуральную степень b, используя цикл
Console.Write("Enter your number: ");
int a = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter the desired power of number: ");
int b = int.Parse(Console.ReadLine()??"0");
int result = 1;
for (int i=1;i<=b;i++)
{
    result=result*a;
}
Console.Write($"The result of raising to the power: {result}");
