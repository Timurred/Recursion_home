//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
//  промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите начальное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

        
    RecursiveNumbers(m,n);

    static void RecursiveNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            RecursiveNumbers(m + 1, n);
        }
        Console.WriteLine();
    }




    


