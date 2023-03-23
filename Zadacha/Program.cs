// Написать программу, из имеющего массива строк
// формирует массив из строк, длина которых меньше либо 
// равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться
// коллекциями, лучше исключительно обойтись массивами.

// ["hello","2", "world", ":-)"] -> ["2", ":-)"]
// ["1234","1567", "-2","computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

//string myText = "Hello people age 40, be happy in 2023 :-)";
//string characters = "ghbtni kj";
//Console.WriteLine(characters.Length); 

string myText = "Hello people age 40, be happy in 2023 :-)";
string[] words = myText.Split(new char[] { ' ' });

PrintArray(words, "Массив текста: ");

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
