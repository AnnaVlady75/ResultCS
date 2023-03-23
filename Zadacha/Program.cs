// Написать программу, из имеющего массива строк
// формирует массив из строк, длина которых меньше либо 
// равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться
// коллекциями, лучше исключительно обойтись массивами.

// ["hello","2", "world", ":-)"] -> ["2", ":-)"]
// ["1234","1567", "-2","computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] words, string myText)
{
    Console.Write(myText);
    for (int i = 0; i < words.Length; i++)
    {
        if (i == 0) Console.Write("[");
        Console.Write(words[i]);
        if (i != words.Length - 1) Console.Write(", ");
        if (i == words.Length - 1) Console.Write("]");
    }
    Console.WriteLine();
}

string[] ArrayWordsLessThree(string[] text)
{
    int arrayLength = text.Length;
    int charactersSymbols = 3;
    int count = 0;
    string[] findSymbols = { string.Empty };
    for (int i = 0; i < arrayLength; i++)
    {
        if (text[i].Length <= charactersSymbols)
        {
            count++;
        }
    }
    if (count > 0)
    {
        string[] newArray = new string[count];
        count = 0;
        for (int i = 0; i < newArray.Length; i++)
        {
            if (text[i].Length <= charactersSymbols)
            {
                newArray[count] = text[i];
                count++;
            }
        }
        return newArray;
    }
    else
    {
        return findSymbols;
    }
}

string myText = "Hello people age 40, be happy in 2023 :-)";
string[] words = myText.Split(new char[] { ' ' });
PrintArray(words, "Массив текста: ");
string[] findArray = ArrayWordsLessThree(words);
PrintArray(findArray, " Массив из строк, длина которых меньше либо равна 3 символам: ");
