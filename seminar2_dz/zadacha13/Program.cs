// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число");
string number = Console.ReadLine();
if (number.Length > 2)
{
    char result = number[2];
    Console.WriteLine($"Нашли третью цифру - это {result}");
}else
{
    Console.WriteLine($"{number} - тут третьей цифры нет");
}