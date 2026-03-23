using System.Text;

class Program
{
    public static double ReadDouble(string message)
    {
        double value;

        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (double.TryParse(input, out value))
                return value;

            Console.WriteLine("\nВведіть коректне число.");
        }
    }

    public static int ReadInt(string message)
    {
        int value;

        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out value))
                return value;

            Console.WriteLine("\nПомилка! Введіть ціле число.");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Parallelogram p1 = new Parallelogram();
        Parallelogram p2 = new Parallelogram(6,3,60);

        int choice;

        while (true)
        {
            try
            {
                Console.WriteLine("\nМЕНЮ\n");
                Console.WriteLine("1. Показати P1 і P2");
                Console.WriteLine("2. Ввести дані для P1");
                Console.WriteLine("3. Ввести дані для P2");
                Console.WriteLine("0. Вихід");

                choice = ReadInt("Ваш вибір: ");

                switch (choice)
                {
                    case 1:
                        p1.PrintInfo("A");
                        p2.PrintInfo("B");
                        break;

                    case 2:
                        Console.WriteLine("\nВвід для P1:");
                        p1.SetA(ReadDouble("Сторона a: "));
                        p1.SetB(ReadDouble("Сторона b: "));
                        p1.SetAngle(ReadDouble("Кут: "));
                        break;

                    case 3:
                        Console.WriteLine("\nВвід для P2:");
                        p2.SetA(ReadDouble("Сторона a: "));
                        p2.SetB(ReadDouble("Сторона b: "));
                        p2.SetAngle(ReadDouble("Кут: "));
                        break;

                    case 0:
                        Console.WriteLine("Вихід");
                        return;

                    default:
                        Console.WriteLine("\nНевірний вибір!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nСталася помилка: " + ex.Message);
            }
        }
    }
}
