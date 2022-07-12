// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа. 
// 78 -> 8 
//12-> 2 
//85 -> 8 

int number = new Random().Next(100,1000);
System.Console.WriteLine(number);
int firstDigit = number /100;
int secondDigit = number % 10;
System.Console.WriteLine(firstDigit);
System.Console.WriteLine(secondDigit);
if (firstDigit > secondDigit) 
{ 
    Console.WriteLine($"Первое число {firstDigit} больше"); 
    } 
else if (firstDigit < secondDigit)
{
    Console.WriteLine($"Второе число {secondDigit} больше"); 
} 
else
{
    System.Console.WriteLine("числа равны");
}