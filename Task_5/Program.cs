// Подсчитать сумму цифр в числе
Console.Write("Enter your number: ");
int a = int.Parse(Console.ReadLine()??"0");
int sum = 0;
while(a>0)
{
    sum=sum+a%10;
    a=a/10;
}
Console.Write($"The sum of digits of this number: {sum}");
