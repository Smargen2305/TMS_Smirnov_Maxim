using System.Text;

namespace HomeWorkStrings
    {
    internal class Program
        {

        static void Main(string[] args)
            {
            PrintToConsole("Введите текст:");
            string userInput = ReadStringFromConsole();

            PrintToConsole($"Вы ввели: {userInput}");
            string[] splitUserText = SplitText(userInput);

            // 1. Найти слова, содержащие максимальное количество цифр.
            List<string> result = NumbersInText(splitUserText);
            PrintToConsole(string.Join(" ", result));

            // 2. Найти самое длинное слово и определить, сколько раз оно встретилось в тексте
            List<string> result2 = LongestWord(splitUserText);
            List<int> result3 = CountLongestWord(result2, splitUserText);

            PrintToConsole(string.Join(" ", result2));
            for (int i = 0; i < result2.Count; i++)
                {
                PrintToConsole($"{result2[i]} встречается {result3[i]} раз(a)");
                }

            // 3. Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».

            List<string> result4 = ReplaceNumbersOnWords(splitUserText);
            PrintToConsole (string.Join(" ", result4));

            // 4. Вывести на экран только предложения, не содержащие запятых

            List<string> result5 = SentencesWithoutCommas(userInput);
            PrintToConsole (string.Join (" ", result5));

            static string ReadStringFromConsole()
                {
                try
                    {
                    return Console.ReadLine();
                    }
                catch
                    {
                    return "Ошибка ввода";
                    }
                }

            static void PrintToConsole(string message)
                {
                Console.WriteLine(message);
                }

            static string[] SplitText(string userInput)
                {
                string[] words = userInput.Split(new char[] {' ',',','/','|','.','!','?' }, StringSplitOptions.RemoveEmptyEntries);
                return words;
                }

            static List<string> NumbersInText(string[] splitUserText)
                {
                List<string> wordsWithMaxDigits = new List<string>();
                int maxDigitCount = 0; // Максимальное количество цифр в словах
                PrintToConsole("Слово(а) с Макс. кол-вом цифр: ");
                foreach (var word in splitUserText)
                    {
                    int digitCount = 0; // Счетчик цифр в текущем слове
                    foreach (var ch in word)
                        {
                        if (char.IsDigit(ch))
                            {
                            digitCount++;
                            }
                        }
                    // Сравниваем количество цифр в текущем слове с максимальным
                    if (digitCount > maxDigitCount)
                        {
                        // Если цифр в текущем слове больше, чем в максимальном, обновляем максимальное количество и начинаем новый список
                        maxDigitCount = digitCount;
                        wordsWithMaxDigits.Clear(); // Очищаем список, чтобы добавить новое слово
                        wordsWithMaxDigits.Add(word);
                        }
                    else if (digitCount == maxDigitCount)
                        {
                        // Если количество цифр в слове равно максимальному, добавляем это слово в список
                        wordsWithMaxDigits.Add(word);
                        }
                    }
                // Возвращаем список слов с максимальным количеством цифр
                return wordsWithMaxDigits;
                }

            static List<string> LongestWord(string[] splitUserText)
                {
                List<string> longestWordWithMaxLetter = new List<string>();
                int maxLetterCount = 0;
                PrintToConsole("Самое длинное слово(а):");
                foreach (var word in splitUserText)
                    {
                    if (word.Length > maxLetterCount)
                        {
                        maxLetterCount = word.Length;
                        longestWordWithMaxLetter.Clear(); // Очищаем список, чтобы добавить новое слово
                        longestWordWithMaxLetter.Add(word);
                        }
                    else if (word.Length == maxLetterCount)
                        {

                        longestWordWithMaxLetter.Add(word);
                        }
                    }

                return longestWordWithMaxLetter;
                }

            static List<int> CountLongestWord(List<string> LongestWord, string[] splitUserText)
                {
                List<int> CountTheLongestWordInText = new List<int>();

                foreach (var word in LongestWord)
                    {
                    int count1 = 0;
                    foreach (var word2 in splitUserText)
                        {
                        if (word2 == word)
                            {
                            count1++;
                            }
                        }

                    CountTheLongestWordInText.Add(count1);
                    }
                return CountTheLongestWordInText;
                }

            static List<string> ReplaceNumbersOnWords(string[] splitUserText)
                {

                StringBuilder stringBuilder = new StringBuilder();

                var changes = new Dictionary<int, string>()
                    {
                       { 0, "ноль"},
                       { 1, "один"},
                       { 2, "два"},
                       { 3, "три"},
                       { 4, "четыре"},
                       { 5, "пять"},
                       { 6, "шесть"},
                       { 7, "семь"},
                       { 8, "восемь"},
                       { 9, "девять"}
                    };

                List<string> NumberOnLetters = new List<string>();

                foreach (var word in splitUserText) 
                    { 
                    foreach(var ch2 in word)
                        {
                        if (char.IsDigit(ch2))
                            {
                            var a = int.Parse(ch2.ToString());
                            var wordFromDictionary = changes[a];
                            stringBuilder.Append(wordFromDictionary);
                            }
                        else
                            {
                            stringBuilder.Append(ch2.ToString());
                            }
                        }
                    NumberOnLetters.Add(stringBuilder.ToString());
                    stringBuilder.Clear();
                    }
                return NumberOnLetters;
                }

            static List<string> SentencesWithoutCommas(string userInput)
                {
                List<string> sentencesNoCommas = new List<string>();
                string[] sentences = userInput.Split(new char[] { '.', '!', '?'});
                    foreach (var sentence in sentences)
                    {
                        if (!sentence.Contains(','))
                        {
                        sentencesNoCommas.Add(sentence);
                        }
                    }
                return sentencesNoCommas;
                }

            }
        }
    }



