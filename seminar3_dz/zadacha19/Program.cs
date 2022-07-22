// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
// string number = Console.ReadLine();
 // Метод 1: С помощью функции number.Reverse()
// string revers = string.Concat(number.Reverse());
// if (number.Length == 5)
// {
//      if (number == revers)
//      {
//         Console.WriteLine($"является ли {number} палиндромом - да");
//      }
//      else
//      {
//         Console.WriteLine($"является ли {number} палиндромом - нет");
//      } 
// }
// else
// Console.WriteLine("ошибка, не является числом или не пятизначное число");

// Метод 2: С помощью разрядов как вы просили
string lenNumber = Console.ReadLine();
int number = Convert.ToInt32(lenNumber);
int reverse_number = 0;
int n = number;
int rem = 0;
if (lenNumber.Length == 5)
{
    while (n != 0)
    {
        rem = n % 10;
        reverse_number = reverse_number * 10 + rem;
        n = n / 10;      
    }
    if (number == reverse_number)
    {
        Console.WriteLine($"является ли {number} палиндромом - да");
    }
    else
    {
        Console.WriteLine($"является ли {number} палиндромом - нет");
    }
}
else
{
    Console.WriteLine("ошибка, не является числом или не пятизначное число");
}

