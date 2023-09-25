// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
double func (double x, double y, double z)
{
    double max = -100000;
    if (x>max) max = x;
    if (y>max) max = y;
    if (z>max) max = z;
    return max;

}


    Console.WriteLine("Введите первое число: ");
    double a1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double a2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    double a3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Максимальное из трех: ");
    Console.WriteLine(func(a1, a2, a3));
    return 0;

