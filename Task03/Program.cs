// Напишите программу со статическим методом для сравнения тексто­вых строк. Строки на предмет совпадения
// сравниваются посимвольно. Правило сравнения символов такое: два символа считаются одинаковы­ми,
// если их коды отличаются не больше, чем на единицу. Текстовые стро­ки совпадают, если у них совпадают символы
// (в указанном выше смысле).

static bool StringComparison(string firstTxt, string secondTxt)
{
    if (firstTxt.Length != secondTxt.Length) return false;
    for (int i = 0; i < firstTxt.Length; i++)
    {
        if ((int)firstTxt[i] < (int)secondTxt[i] - 1 || (int)firstTxt[i] > (int)secondTxt[i] + 1) return false;
    }
    return true;
}

string txt1 = "привет, мой дорогой";
string txt2 = "привет, лой дорогой";

if (StringComparison(txt1, txt2)) Console.WriteLine("Строки удовлетворяют требованиям сравнения.");
else Console.WriteLine("Строки НЕ удовлетворяют требованиям сравнения.");