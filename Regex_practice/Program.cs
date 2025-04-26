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
            //foreach (Match match in matches)
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

            // 6) Проверить, является ли введенная строка числом.
            //string p = "^\\d+$";
            //bool res = Regex.IsMatch(text, p);
            //    Console.WriteLine(res);

            // 7) Вставить "Ок" после каждой буквы "о" в тексте.
            //string pattern = "o";
            //string replacement = "oOk";

            //string result = Regex.Replace(text, pattern, replacement);

            //Console.WriteLine(result);

            // 8) Удалить все цифры из текста.
            //string pattern = @"\d";
            //string replacement = "";
            //string result = Regex.Replace(text, pattern, replacement);
            //Console.WriteLine(result);

            // 9) Проверить, содержит ли текст цифры.
            //string pattern = @"\d";
            //bool containsDigits = Regex.IsMatch(text, pattern);
            //Console.WriteLine("Does the text include digits? " + containsDigits);

            // 10) Определить, состоит ли строка только из букв или только из цифр.
            //bool onlyLetters = Regex.IsMatch(text, @"^[A-Za-z]+$");
            //bool onlyDigits = Regex.IsMatch(text, @"^\d+$");

            //if (onlyLetters)
            //    Console.WriteLine("Text includes only letters.");
            //else if (onlyDigits)
            //    Console.WriteLine("Text incudes only digits.");
            //else
            //    Console.WriteLine("Text includes letters, digits or other characters.");

            // 11) Заменить последовательности точек на одну точку.
            //string text2 = "This is a test... Wait.. Another one.... Done.";
            //string pattern = @"\.{2,}";
            //string replacement = ".";

            //string result = Regex.Replace(text2, pattern, replacement);

            //Console.WriteLine(result);

            // 12) Проверить надежность пароля (не менее 8 символов, минимум одна заглавная, одна строчная буква и одна цифра).
            //string password = "Secure123"; 
            //string password2 = "Password";
            //string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

            //bool isStrong = Regex.IsMatch(password, pattern);

            //Console.WriteLine("Is the password strong? " + isStrong);
            //bool isStrong2 = Regex.IsMatch(password2, pattern);

            //Console.WriteLine("Is the password strong? " + isStrong2);

            // 13) Удалить введенный символ из строки, независимо от регистра.
            //string text2 = "Example Text With Mixed CASE Letters.";
            //char toRemove = 'e'; // Character to remove (case-insensitive)

            //string pattern = Regex.Escape(toRemove.ToString());
            //string result = Regex.Replace(text2, pattern, "", RegexOptions.IgnoreCase);

            //Console.WriteLine(result);

            // 14) Извлечь из строки вещественное число с фиксированной точкой.
            //string text2 = "Mark bought 3 apples for 10$. Mike has 25.50$. Start 12345 End.";
            //string pattern = @"\d+\.\d+";

            //MatchCollection matches = Regex.Matches(text2, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine("Found float: " + match.Value);
            //}

            // 15) Заменить слово "fish" на "123", избегая изменения схожих слов.
            string text2 = "I saw a fish. Then I saw a fishing rod and a catfish.";
            string pattern = @"\bfish\b";
            string replacement = "123";

            string result = Regex.Replace(text2, pattern, replacement);

            Console.WriteLine(result);
        }
    }
}
