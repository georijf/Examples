#region 1я группа методов
// 1-я группа методов (НИЧЕГО ВО ВОЗВРАЩАЮТ И НИЧЕГО НЕ ПРИНИМАЮТ)

/* void Method1() // идентификация метода
{
    Console.WriteLine("Автор....");
}
// Method1(); // вызов метода */
#endregion

#region 2я группа методов
// 2я группа методов (НИЧЕГО НЕ ВОЗВРАЩАЮТ, НО ПРИНИМАЮТ КАКИЕ-ТО АРГУМЕНТЫ)

/* void Method2(string msg) // выводит вводимый текст
{
    Console.WriteLine(msg);
} */
// Method2("Текст сообщения");

void Method21(string msg, int count) // вывщдит вводимый текст int количество раз
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4); // принимает значения метода по порядку
//Method21(count: 4, msg: "Текст"); // явно указывает тип аргумента, можно писать не по порядку
#endregion

#region 3я группа методов
// 3я группа методов (ЧТО-ТО ВОЗВРАЩАЮТ, НО НИЧЕГО НЕ ПРИНИМАЕТ)

/* int Method3()
{
    return DateTime.Now.Year;
} */
/* int year = Method3(); */
//Console.WriteLine(year);
#endregion

#region 4я группа методов
/* //4я группа методов (ЧТО-ТО ПРИНИМАЮ И ЧТО-ТО ВОЗВРАЩАЮТ)

/* string Method4(int count, string text) 
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "текст");
Console.WriteLine(res); */

/* string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
} */
//string res = Method4(10, "текст");
//Console.WriteLine(res); */
#endregion

#region цикл for (таблица умножения)
/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} x {j} = {i * j}");
    }
    //Console.WriteLine();
} */
#endregion

#region метод замены символо    в в тексте
/* Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”. */

/* string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы"
            + "дадите мне чаю?";

// string s = "qwerty"
//             01234
//s[3]   r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); */
#endregion

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArry(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArry(arr);
SelectionSort(arr);

PrintArry(arr);