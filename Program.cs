// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше, либо равно три символа. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. 

Console.Clear();

string[] string1 = new string[4] { "hello", "2", "word", ":-)" };
string[] string2 = new string[4] { "1234", "1567", "-2", "computer science" };
string[] string3 = new string[3] { "Russia", "Denmark", "Kazan" };

void PrintArray(string[] str1, string[] str2, string[] str3)
{
    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i].Length <= 3) Console.Write($"{str1[i]} ");
    }
    Console.WriteLine(" ");
    for (int i = 0; i < str2.Length; i++)
    {
        if (str2[i].Length <= 3) Console.WriteLine(str2[i]);
    }
    Console.WriteLine(" ");
     for (int i = 0; i < str3.Length; i++)
    {
        if (str3[i].Length <= 3) Console.WriteLine(str3[i]);
    }
}

PrintArray(string1, string2, string3);
