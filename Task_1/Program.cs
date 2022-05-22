// Показать таблицу квадратов чисел от 1 до n
Console.Write("Enter your number: ");
int n = int.Parse(Console.ReadLine()??"0");
for (int i=1;i<=n;i++)
{
    Console.Write($"{i*i} ");
}
