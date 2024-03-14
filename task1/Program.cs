//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
//  промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите начальное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

        
    PeriodNumbers(m,n);

    static void PeriodNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PeriodNumbers(m + 1, n);
        }
        Console.WriteLine();
    }




    


