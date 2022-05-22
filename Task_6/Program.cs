// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Enter your number: ");
int n = int.Parse(Console.ReadLine()??"0");
int a = 1;
while (a<=n)
{
    if (a%2==0)
    {
        Console.Write($"{a*a*a} ");
        a++;
    }
    else
    a++;    
}
