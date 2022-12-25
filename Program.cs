// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Write("Enter the number of how much words you'll write: ");
int n = int.Parse(Console.ReadLine());
string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Enter something: ");
    string? s = Console.ReadLine();
    if (s.Length <= 3)
    {
        string[] newResult = new string[words.Length + 1];
        Array.Copy(words, newResult, words.Length);

        newResult[words.Length] = s;
        words = newResult;
    }
}

foreach (string s in words)
{
    Console.WriteLine(s);
}