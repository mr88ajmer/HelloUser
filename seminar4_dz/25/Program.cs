// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите натуральное число A: "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите натуральное число B: "); 
int numberB = Convert.ToInt32(Console.ReadLine()); 
int result = 1;
if (numberA >= 0 && numberB >= 0)
    {
        Console.WriteLine("Это натуральные числа");
        for (int i = 1; i <= numberB; i++)
        {
            result *= numberA;
        }
        //Console.WriteLine(result);
        Console.WriteLine("{0} ^ {1} = {2}", numberA, numberB, result);
    }
else
{
    Console.WriteLine("это не натуральные числа");
}

