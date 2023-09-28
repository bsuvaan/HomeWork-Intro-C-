// Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”

string Replase(string origin_text, char Changed_Symbol, char Changing_Symbol)
{
    string Result = String.Empty;
    int l = origin_text.Length; 
    for (int i=1; i < l; i++)
    {
        if (origin_text[i] == Changed_Symbol) Result = Result + $"{Changing_Symbol}";
        else Result = Result + $"{origin_text[i]}";
    }

    return Result;
}

void Write(string outp)
{
    Console.WriteLine(outp);
    Console.WriteLine();
}

string text = "— Я думаю, — сказал князь, улыбаясь, — что, " +
            "ежели бы вас послали вместо нашего милого " + 
            "Винценгероде, вы бы взяли приступом согласие " +
            "прусского короля. Вы так красноречивы. Вы " +            
            "дадите мне чаю?";

Write(text);
string new_text = Replase(text, ' ', '|');
Write(new_text);
new_text = Replase(new_text, 'к', 'К');
Write(new_text);
new_text = Replase(new_text, 'с', 'С');
Write(new_text);


