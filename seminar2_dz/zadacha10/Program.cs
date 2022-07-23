// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Метод 1
Console.WriteLine("Введите трехзначное число");
string kolNumber = Console.ReadLine();
int number = Convert.ToInt32(kolNumber);
if (kolNumber.Length == 3)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($"Нашли вторую цифру - это {secondDigit}");
}else
{
    Console.WriteLine($"Это не трехзначное число {number} ");
}

 
// Метод 2
/*
Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
char result = number[1];
if (number.Length == 3)
{
    Console.WriteLine($"Нашли вторую цифру - это {result}");
}else
{
    Console.WriteLine($"Это не трехзначное число {number} ");
}
*/