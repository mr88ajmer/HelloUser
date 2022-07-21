// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
string revers = string.Concat(number.Reverse());
if (number.Length == 5)
{
     if (number == revers)
     {
        Console.WriteLine("является ли оно палиндромом - да");
     }
     else
     {
        Console.WriteLine("является ли оно палиндромом - нет");
     } 
}
else
Console.WriteLine("ошибка, не является числом или не пятизначное число");
