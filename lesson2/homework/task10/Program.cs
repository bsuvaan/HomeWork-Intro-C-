//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
string input_text = Console.ReadLine();
if (input_text.Length == 3)
{
    Console.WriteLine("Второе в записи число: " + input_text[1]);
}
else Console.WriteLine("Число должно быть трехзначным");
