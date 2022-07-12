//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа./
//456 -> 46
//782 -> 72
//18 -> 98

/*
int number = new Random().Next(100,1000);
System.Console.WriteLine(number);
int firstDigit = number /100;
int secondDigit = number % 10;
System.Console.WriteLine(firstDigit);
System.Console.WriteLine(secondDigit);
int result = firstDigit * 10 + secondDigit;
System.Console.WriteLine(result); */

//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int firstDigit = Convert.ToInt32(Console.ReadLine());
int secondDigit = Convert.ToInt32(Console.ReadLine());
if (firstDigit % secondDigit == 0)
{
    System.Console.WriteLine("число кратное");
}
else
{
    System.Console.WriteLine("Остаток " + firstDigit % secondDigit);
}