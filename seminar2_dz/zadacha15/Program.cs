// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int denk = Convert.ToInt32(Console.ReadLine());
if (denk <= 7 && denk >= 1 )
{
    if (denk == 6)
    {
        Console.WriteLine("Да, суббота является выходным");
    }
    else if (denk == 7)
    {
        Console.WriteLine("Да, воскресенье является выходным");
    }
    else
    {
        Console.WriteLine($"Нет, {denk} день недели является рабочим днем" );
    }
}
else
{
    Console.WriteLine($"{denk}-го дня недели не существует");
}
