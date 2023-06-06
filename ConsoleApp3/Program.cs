using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Task27();
            Task34();
        }

        public static void Task34()
        {
            string postalCode = "308000";
            string postalCode2 = "308A00";

            string pattern = @"^\d{6}$";

            bool isMatch = Regex.IsMatch(postalCode, pattern);
            bool isMatch2 = Regex.IsMatch(postalCode2, pattern);

            if (isMatch)
            {
                Console.WriteLine($"{postalCode} - Почтовый индекс действителен.");
            }
            else
            {
                Console.WriteLine($"{postalCode2} - Неверный формат почтового индекса.");
            }

            if (isMatch2)
            {
                Console.WriteLine($"{postalCode2} - Почтовый индекс действителен.");
            }
            else
            {
                Console.WriteLine($"{postalCode2} - Неверный формат почтового индекса.");
            }
        }

        public static void Task27()
        {
            string input1 = "aabcdd";
            string input2 = "012121213";

            // Проверка для L1 с регулярным выражением R1 = aa*b*cdd*
            Regex regex1 = new Regex("^aa*b*cdd*$");
            bool isMatch1 = regex1.IsMatch(input1);

            // Проверка для L2 с регулярным выражением R2 = 012(12)*3*
            Regex regex2 = new Regex("^012(12)*3*$");
            bool isMatch2 = regex2.IsMatch(input2);

            Console.WriteLine("Для L1:");
            Console.WriteLine($"Входная строка: {input1}");
            Console.WriteLine($"Результат: {(isMatch1 ? "Принадлежит L1" : "Не принадлежит L1")}");

            Console.WriteLine();

            Console.WriteLine("Для L2:");
            Console.WriteLine($"Входная строка: {input2}");
            Console.WriteLine($"Результат: {(isMatch2 ? "Принадлежит L2" : "Не принадлежит L2")}\n");

        }
    }
}