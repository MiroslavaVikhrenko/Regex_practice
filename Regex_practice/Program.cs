using System.Text.RegularExpressions;

namespace Regex_practice
{
    /*
     У вас есть строка, используя ее, выполните следующий набор задач:
string text = "Mark bought 3 apples for 10$. Mike has 25.50$. Start 12345 End. @john, @mike are here. Цены начинаются от 20 грн и заканчиваются 150 грн.";

1) Извлечь все слова длиной ровно 4 символа.
2) Найти все слова, начинающиеся с большой буквы "М".
3) Вывести все слова длиной более 4 символов.
4) Разбить строку по словам и вывести каждое слово на новой строке.
5) Извлечь все цифры из текста.
6) Проверить, является ли введенная строка числом.
7) Вставить "Ок" после каждой буквы "о" в тексте.
8) Удалить все цифры из текста.
9) Проверить, содержит ли текст цифры.
10) Определить, состоит ли строка только из букв или только из цифр.
11) Заменить последовательности точек на одну точку.
12) Проверить надежность пароля (не менее 8 символов, минимум одна заглавная, одна строчная буква и одна цифра).
13) Удалить введенный символ из строки, независимо от регистра.
14) Извлечь из строки вещественное число с фиксированной точкой.
15) Заменить слово "рыба" на "123", избегая изменения схожих слов.
     
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Mark bought 3 apples for 10$. Mike has 25.50$. Start 12345 End. @john, @mike are here.";

            // 1) Извлечь все слова длиной ровно 4 символа.
            //string p = @"\b\w{4}\b";
            //MatchCollection matches = Regex.Matches(text, p);
            //foreach (Match match in  matches ) 
            //{
            //    Console.WriteLine(match.ToString());
            //}

            // 2) Найти все слова, начинающиеся с большой буквы "М".
            //string p = @"M\w+";
            //MatchCollection matches = Regex.Matches(text, p);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.ToString());
            //}

            // 3) Вывести все слова длиной более 4 символов.
            //string p = "\\b\\w{5,}\\b";
            //MatchCollection matches = Regex.Matches(text, p);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.ToString());
            //}

            // 4) Разбить строку по словам и вывести каждое слово на новой строке.
            //string p = "\\b\\w+\\b";
            //MatchCollection matches = Regex.Matches(text, p);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.ToString());
            //}

            // 5) Извлечь все цифры из текста.
            //string p = "\\b\\d+\\b";
            //MatchCollection matches = Regex.Matches(text, p);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.ToString());
            //}

            //6) Проверить, является ли введенная строка числом.
            string p = "^\\d+$";
            bool res = Regex.IsMatch(text, p);
                Console.WriteLine(res);


        }
    }
}
