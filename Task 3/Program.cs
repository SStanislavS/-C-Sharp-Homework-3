// Программа принимает на входе число (N) и помещает в массив таблицу кубов чисел от 1 до N.
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// 
// {
//     for (int i = 1; i <= N; i++)
//     Console.Write($"{Math.Pow(i, 3)}, ");
// }
// Console.WriteLine("Cube: " + N);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int[] array = new int [N];

Console.Write("[");

for (int i = 1; i <= N; i++)
{
    Console.Write(i * i * i + ",");
}
Console.Write("]");