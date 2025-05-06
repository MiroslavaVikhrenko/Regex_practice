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
16) Подсчитать количество слов в тексте.
17) Извлечь все цифры, находящиеся между словами "Start" и "End".
18) Извлечь все имена пользователей из текста (формат "@username").
19) Найти все цены в тексте, записанные в формате "число грн" или "число$".
20) Проверить корректность логина (2-10 символов, только буквы и цифры, цифра не может быть первой).
     
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
            //Console.WriteLine(res);

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
            //string text2 = "I saw a fish. Then I saw a fishing rod and a catfish.";
            //string pattern = @"\bfish\b";
            //string replacement = "123";

            //string result = Regex.Replace(text2, pattern, replacement);
            //Console.WriteLine(result);

            // 16) Подсчитать количество слов в тексте.

            //string text2 = "This is a sample text with several words!";
            //string pattern = @"\b\w+\b";

            //MatchCollection matches = Regex.Matches(text2, pattern);
            //Console.WriteLine("Number of words: " + matches.Count);

            // 17) Извлечь все цифры, находящиеся между словами "Start" и "End".

            //string text2 = "Mark bought 3 apples. Start 12345 End. Mike has 25.50$. Start 6789 End.";
            //string pattern = @"(?<=\bStart\b)(.*?)(?=\bEnd\b)";

            //MatchCollection matches = Regex.Matches(text2, pattern);

            //foreach (Match match in matches)
            //{
            //    // Extract digits from the matched string
            //    string digits = Regex.Replace(match.Value, @"\D", ""); // Remove non-digits
            //    if (!string.IsNullOrEmpty(digits))
            //    {
            //        Console.WriteLine("Found digits: " + digits);
            //    }
            //}

            // 18) Извлечь все имена пользователей из текста (формат "@username").
            //string text2 = "Hello @john, @mike, and @sarah! How are you doing, @alex?";
            //string pattern = @"@([a-zA-Z0-9_]+)";

            //MatchCollection matches = Regex.Matches(text2, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine("Found username: " + match.Value);
            //}

            // 19) Найти все цены в тексте, записанные в формате "number CAD" или "number$".
            //string text2 = "The price is 25 CAD, and another item costs 19.99$. Mike bought it for 100$. The discount is 5 CAD.";
            //string pattern = @"\d+(\.\d{1,2})?\s?(CAD|\$)";

            //MatchCollection matches = Regex.Matches(text2, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine("Found price: " + match.Value);
            //}

            // 20) Проверить корректность логина (2-10 символов, только буквы и цифры, цифра не может быть первой).

            //string username = "user123";
            //string pattern = @"^[A-Za-z][A-Za-z0-9]{1,9}$";

            //bool isValid = Regex.IsMatch(username, pattern);

            //if (isValid)
            //    Console.WriteLine("The username is valid.");
            //else
            //    Console.WriteLine("The username is invalid.");

            // 21. Вам нужно извлечь все даты из строки в формате "YYYY-MM-DD".
            //string input = "Today is 2023-02-21 and the meeting is on 2023-";

            //string pattern = @"\b\d{4}-\d{2}-\d{2}\b";

            //MatchCollection matches = Regex. Matches(input, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match);
            //}

            // 22. У вас есть список имен в строке, и вы хотите извлечь все имена,
            // которые начинаются с определенной буквы или последовательности букв.
            // Напишите программу на C#, которая использует регулярные выражения для извлечения
            // нужных имен из строки.

            //string names = "Makoto Yumi Yukiko Taro Sadoko Yuka Kenta Shinzo";

            ////char letter = 'Y';

            //string letters = "Yu";

            //string pattern = $@"\b{letters}[A-Za-z]*\b";
            //MatchCollection matches = Regex.Matches(names, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match);
            //}

            // 23. Дана строка, получить из нее все ip адреса.
            // Количество цифр в каждом может быть разным, но формат записи один – [].[].[].[].

            //string text2 = "fjmdfjh 1.2.3.4 vhghgj 999.999.999.999";

            //string pattern = @"\b\d{1,3}(\.\d{1,3}){3}\b";

            //MatchCollection matches = Regex.Matches(text2, pattern);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.ToString());
            //}

            //24.Дан текст, с перечисленными номерами регионов и их названиями:
            //02 - Винницкая, 25 - Черниговская, 18 - Сумская область и т.д.
            //Используя регулярное выражение, по вводу номера региона, достать название
            //региона из строки и вывести на экран. Если вводится не полный номер, например, цифра 2,
            //достать все регионы, начинающиеся на данную цифру.

            //string regions = "18-Sumska, 15-Odeska, 10-Kyivska, 04-Dniprovska, 14-Mykolaivska";

            //Console.WriteLine("Enter region number (or beginning of it):");
            //string input = Console.ReadLine();

            //// Regex pattern to match any region number starting with the input, and capture the region name
            //string pattern = $@"\b{Regex.Escape(input)}\d*-(\p{{L}}+)\b";

            //MatchCollection matches = Regex.Matches(regions, pattern);

            //if (matches.Count > 0)
            //{
            //    foreach (Match match in matches)
            //    {
            //        Console.WriteLine($"Region: {match.Groups[1].Value}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No matching region found.");
            //}

            // 25.  Создать регулярное выражение, для проверки строки.
            // Строка должна состоять из английских букв, без цифр и без двойных и более пробелов.

            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            //// Regex pattern:
            //// - ^ and $ to anchor the start and end
            //// - [A-Za-z]+ for one or more letters
            //// - ( [A-Za-z]+)* allows single spaces followed by more letters (no double spaces)
            //// - Entire pattern allows letters and single spaces between words only
            //string pattern = @"^[A-Za-z]+( [A-Za-z]+)*$";

            //if (Regex.IsMatch(input, pattern))
            //{
            //    Console.WriteLine("Valid string.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid string. Only English letters and single spaces are allowed. No digits or double spaces.");
            //}

            // 26. Используя регулярные выражения из строки - \\192.186.0.1\папка1\папка2\ ,
            // обрезать - \\192.186.0.1. Количество папок в пути, может быть неограниченным.

            //string input = @"\\192.186.0.1\folder1\folder2\";

            //// Regex pattern to match starting \\IP_ADDRESS\
            //string pattern = @"^\\\\[0-9]{1,3}(?:\.[0-9]{1,3}){3}\\";

            //// Replace the IP prefix with empty string
            //string result = Regex.Replace(input, pattern, "");

            //Console.WriteLine("Original: " + input);
            //Console.WriteLine("Modified: " + result);

            // 27. Есть строка "-n 98 -s 82 -b 9 -a 9". Необходимо прочитать и
            // записать в переменную число после "-s". Использовать регулярные выражения.

            //string input = "-n 98 -s 82 -b 9 -a 9";

            //// Regex to capture number after -s
            //string pattern = @"-s\s+(\d+)";

            //Match match = Regex.Match(input, pattern);

            //if (match.Success)
            //{
            //    string sValue = match.Groups[1].Value;
            //    Console.WriteLine("Value after -s: " + sValue);

            //    // Optionally convert to integer
            //    int sNumber = int.Parse(sValue);
            //    Console.WriteLine("As integer: " + sNumber);
            //}
            //else
            //{
            //    Console.WriteLine("No match found.");
            //}


            // 28. Вам дана строка, содержащая список кодов товаров.
            // Каждый код продукта имеет вид "XXX-1234-ABCD", где "XXX"
            // может быть любой из трех заглавных букв, а "1234" - четырехзначное число.
            // Ваша задача извлечь список кодов товаров из строки и сохранить их в списке.

            //string input = "Product codes: ABC-1234-XYZ, DEF-5678-ABCD, invalid-code, GHI-0000-ZZZ";

            //// Regex pattern for product code
            //string pattern = @"\b[A-Z]{3}-\d{4}-[A-Z]+\b";

            //MatchCollection matches = Regex.Matches(input, pattern);

            //List<string> productCodes = new List<string>();

            //foreach (Match match in matches)
            //{
            //    productCodes.Add(match.Value);
            //}

            //// Output the result
            //Console.WriteLine("Extracted product codes:");
            //foreach (var code in productCodes)
            //{
            //    Console.WriteLine(code);
            //}

            // 29. Время имеет формат: часы:минуты. И часы, и минуты имеют две цифры,
            // например, 09:00. Введите регулярное выражение, чтобы найти время в строке:
            // Завтрак в 09:00 в комнате 123:456.

            //string input = "Breakfast at 09:00 in room 123:456";

            //// Regex pattern to match time in hh:mm format
            //string pattern = @"\b\d{2}:\d{2}\b";

            //Match match = Regex.Match(input, pattern);

            //if (match.Success)
            //{
            //    string time = match.Value;
            //    Console.WriteLine("Found time: " + time);
            //}
            //else
            //{
            //    Console.WriteLine("No time found.");
            //}

            // 30. Дана строка содержащая и цифры и буквы. Достать все цифры из строки
            // и положить их в ячейки массива (если идет набор цифр 4578, сложить этот
            // набор в одну ячейку).

            string input = "abc123def4567gh8";

            // Regex pattern to match one or more consecutive digits
            string pattern = @"\d+";

            // Find all matches (sequences of digits)
            MatchCollection matches = Regex.Matches(input, pattern);

            // Create an array to store the digit sequences
            string[] digitsArray = new string[matches.Count];

            // Fill the array with matched digit sequences
            int i = 0;
            foreach (Match match in matches)
            {
                digitsArray[i++] = match.Value;
            }

            // Output the result
            Console.WriteLine("Extracted digit sequences:");
            foreach (var digit in digitsArray)
            {
                Console.WriteLine(digit);
            }
        }
    }
}
