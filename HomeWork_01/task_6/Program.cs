// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string func(double a)
{
    string status = "5";
    if (a%2 == 0) status = "yes";
    if (a%2 != 0) status = "no";
    return status;
}


Console.WriteLine("Введите ваше число: ");
double k = Convert.ToDouble(Console.ReadLine());
Console.Write(func(k));
