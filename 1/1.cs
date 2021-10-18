using System;

namespace TSK1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }
}