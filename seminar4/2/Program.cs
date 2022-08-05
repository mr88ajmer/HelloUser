// void SalarySpealist (int number)
// {
//     number = 4 * number;
//     //return number;
//     System.Console.WriteLine(number);
// }
// SalarySpealist(5);

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i < number; i++)
// {
//     sum = sum + i;
// }
// System.Console.WriteLine("Сумма элементов от 1 до " + number + " = " + sum);
// Console.WriteLine($"Сумма элементов от 1 до {number} = {sum}");// Интерполяция 

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5 


// int number = Convert.ToInt32(Console.ReadLine());
// string numstr = Convert.ToString(number);

// System.Console.WriteLine(numstr.Length);

// Задача 28: Напишите программу, которая п
// ринимает на вход число N и выдаёт произведение чисел от 1 до N. 4 -> 24 5 -> 120 


// int fact = Convert.ToInt32(Console.ReadLine());
// int result =1;
// for (int i = 1; i <= fact; i++)
// {
//     result = result * i;
// }
// System.Console.WriteLine(result);

// Console.Write("Введите число: "); 
// int number = Convert.ToInt32(Console.ReadLine()); 
// int countPositive = 0; 
// while (number != 0)

// { 
//     number /= 10;
//      number = number / 10 ;
//      countPositive++; // Инкремент 
//      // countPositive +=1; 
//      // countPositive = countPositive + 1 
//      // countPositive = countPositive - 1 - это countPositive-- - декремент 
//      } 
// Console.WriteLine($"Количество чисел: {countPositive}"); 


// Console.Write("Введите число: "); 
// int inputNumber = Convert.ToInt32(Console.ReadLine()); 
// int result = 1;
// int start = 1;

// while (start <= inputNumber)
// {
// 
// start++;
// }
// System.Console.WriteLine(result);


// Console.Write("Введите число: "); 
// int inputNumber = Convert.ToInt32(Console.ReadLine()); 
// int result = 1;
// for (int start = 1; start <= inputNumber; start++)
// {
//     result *= start;
// }
// System.Console.WriteLine(result);

int[] array = GetBinary(8);
int[]  GetBinary(int size)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}
System.Console.WriteLine($"[{String.Join(",", array)}]");