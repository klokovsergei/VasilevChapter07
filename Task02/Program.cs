// Напишите программу, в которой есть статический метод, возвращаю­щий результатом текстовое значение
// и получающий аргументом текст. Результат метода - это переданный аргументом текст, в котором слова следуют
// в обратном порядке. Словами считать блоки текста, разделен­ные пробелами.

static string ReversText(string txt)
{
    string[] textArray = txt.Split(" ");
    string newText = "";
    foreach(string t in textArray)
    {
        newText = t + " " + newText;
    }
    return newText;
}

string txt = "один два три четыре";
Console.WriteLine(ReversText(txt));