// Напишите программу, которая принимает на вход число (N) выдает таблицу кубов
// чисел от 1 до N
// 3 и 5

void Thr(int n)
{
   for (int i = 1; i <= n; i++)
   {  
       Console.Write($"{i*i*i}");
       if (i != n)
       {
           Console.Write(", ");
       }

   }
}
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Thr(N);