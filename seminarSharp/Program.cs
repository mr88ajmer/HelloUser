/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя). 
Например: 
4 -> 16 
-3 -> 9 
-7 -> 49 
*/

// 1. Создать переменную и проиницилиазировать

//int number = Convert.ToInt32(Console.ReadLine());

//int squareNumber = number * number; // camelCase

//Console.WriteLine(squareNumber);
/*
Console.Write("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2ое число");
int squareNumber = Convert.ToInt32(Console.ReadLine());
if (squareNumber == number * number)
{
    Console.WriteLine("Число" + squareNumber + " является квадратом");
}
else 
{ 
    Console.WriteLine("Число " + squareNumber + " НЕ является квадратом " + number); 
} 
*/

/*
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber>=1 && dayNumber <=7);
{
    if (dayNumber == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (dayNumber == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (dayNumber == )
    {
        Console.WriteLine("Понедельник");
    }
    if (dayNumber == 2)
    {
        Console.WriteLine("Вторник");
    }
}
*/

int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);

while (negativeN <= N )
{
    Console.WriteLine(negativeN);
    negativeN = negativeN + 1;
}