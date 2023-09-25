// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int func (int N)
{
    if (N>1)
    {        
        int num = 2;
        while ((N>=num))
        {
         
            Console.Write(num);
            Console.Write(" ");
            num += 2;               
        }
    }

    if (N<=1)
    {
        Console.WriteLine("Таких значений в натуральных числах нет");
    }
    
    return 0;
}

int k = Int32.Parse(Console.ReadLine());
func(k);