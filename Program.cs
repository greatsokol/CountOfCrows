namespace CountOfCrows
{
    internal class Program
    {
        private static string GetCrowsWordInRightCase(int count)
        {
            count = count >= 0 && count <= 20 ? count : count % 10;
            return count switch
            {
                1 => "ворона",
                2 or 3 or 4 => "вороны",
                0 or _ => "ворон",
            };
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число ворон на ветке:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine($"На ветке {count} {GetCrowsWordInRightCase(count)}");
            }
        }
    }
}
