// Задача 23
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
// {
//     System.Console.WriteLine(i*i*i);
// }
{
    System.Console.WriteLine(Math.Pow(i,3)); // способ Math.Pow(i,3)
}