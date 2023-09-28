// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

bool Is_It_Day_Out (char day)
{
    bool flag = false;
    string weekend = "67";
    for (int i=0; i<weekend.Length; i++)
    {
        if (day == weekend[i]) 
        {
            flag = true;
            break;
        }
    }
    return flag;
}



Console.Write("Введите номер дня: ");
string Day = Console.ReadLine();
if (Is_It_Day_Out(Day[0])) Console.WriteLine("Да");
else Console.WriteLine("Нет");


