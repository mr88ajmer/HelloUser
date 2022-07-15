/* Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). 
Задача 21: Напишите программу, которая принимает на формула

 A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 Задача 22: 
 Напишите программу, которая принимает на вход число (N) и 
 выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4 */

/*System.Console.WriteLine("Введите четверть");
int chetvert = Int32.Parse(Console.ReadLine());
if (chetvert == 1)
{
    System.Console.WriteLine("x >0 и y>0");
}
else if (chetvert == 2)
{
    System.Console.WriteLine("x < 0 и y > 0");
}
else if (chetvert == 3)
{
    System.Console.WriteLine("x < 0 и y < 0");
}
else if (chetvert == 4)
{
    System.Console.WriteLine("x > 0 и y < 0");
}
// else
System.Console.WriteLine("ошибка или нет такой четверти"); */
// l = √ (x 2 - x 1)^2+ (y 2 - y 1)^2 
//Задача 21: Напишите программу, которая принимает на формула
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 */

Console.WriteLine("Введите координату x1 A:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1 A");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2 B:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2 B");
int y2 = Convert.ToInt32(Console.ReadLine());
double resultAB =  Math.Sqrt(Math.Pow(x2 -x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(resultAB);