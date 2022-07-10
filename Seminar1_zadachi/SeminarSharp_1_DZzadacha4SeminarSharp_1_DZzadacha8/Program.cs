
int n = 1;
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = n; 
     i <= N; 
     i++)
    {
        if (i % 2 == 0) 
        {
                Console.Write(i + " ");
        }
     }