// Программа принимает на входе пятизначное число и проверяет, является ли число палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit, sum = 0;
int temp = num;
while (num > 0)
{
    digit = num % 10;
    sum = (sum * 10) + digit;
    num = num / 10;
}
if (temp == sum)
{
    Console.WriteLine($"Число {temp} - является Палиндромом");
}
else
{
    Console.WriteLine($"Число {temp} - не является Палиндромом");
}
