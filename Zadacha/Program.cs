// Написать программу, из имеющего массива строк
// формирует массив из строк, длина которых меньше либо 
// равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться
// коллекциями, лучше исключительно обойтись массивами.

// ["hello","2", "world", ":-)"] -> ["2", ":-)"]
// ["1234","1567", "-2","computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


void PrintArray(string[] words, string text)
{
    Console.Write(text);
    for (int i = 0; i < words.Length; i++)
    {
        if (i == 0) Console.Write("[\"");
        Console.Write(words[i]);
        if (i != words.Length - 1) Console.Write("\", \"");
        if (i == words.Length - 1) Console.Write("\"]");
    }
    Console.WriteLine();
}

string[] ArrayWordsLessThree(string[] text)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            count++;
        }
    }
    if (count == 0)
    {
        string[] result = new string[1];
        int j = 0;
        result[j] = "В заданном массиве нет элементов из 3 и менее символов.";
        return result;
    }
    else
    {
        string[] result = new string[count];
        int j = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length <= 3)
            {
                result[j] = text[i];
                j++;
            }
        }
        return result;
    }
}

string myText = "Hello people age 40, be happy in 2023 :-)";
string[] wordsArray = myText.Split(new char[] { ' ' });
PrintArray(wordsArray, "Массив текста: ");
string[] findArray = ArrayWordsLessThree(wordsArray);
PrintArray(findArray, " -> ");


