// Напишите программу, в которой есть статический метод. Аргументом методу передается текстовое значение.
// Результатом метод возвращает текст, в котором, по сравнению с текстом-аргументом, между символами вставлены пробелы.

static string AddSpace(string txt)
{
    string newText = "";
    foreach(char i in txt)
    {
        newText += i + " ";
    }
    return newText.TrimEnd();
}

Console.WriteLine("Введите исходный текст:");
string text = Console.ReadLine();
string newText = AddSpace(text);
Console.WriteLine(newText);