// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string input_text = Console.ReadLine();
if (input_text.Length >= 3)
{
    Console.WriteLine("Третье в записи число: " + input_text[2]);
}
else Console.WriteLine("У введенного числа нет третьей цифры");