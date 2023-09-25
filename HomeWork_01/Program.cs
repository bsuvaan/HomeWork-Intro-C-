// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

double func (double x, double y)
{
    double max = 0;
    if (x>y) max = x;
    if (x<y) max = y;
    if (x==y) max = y;
    return max;

}


    Console.WriteLine("Введите первое число: ");
    double a1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double a2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Максимальное из двух: ");
    Console.WriteLine(func(a1, a2));
    return 0;
