class Task3
{
    /// <summary>Converts the medicine schedule between the entered GMT offsets.</summary>
    public static void Run()
    {
        Console.WriteLine("Time Conversion");
        int[] times = { 800, 1200, 1600, 2000 };

        Console.WriteLine("Enter current GMT");
        int currentGMT = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Current Medicine Schedule:");
        DisplayTime(times);
        Console.WriteLine("Enter new GMT");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else
        {
            int diff = newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0
                ? 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT))
                : 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

            for (int i = 0; i < times.Length; i++)
            {
                times[i] = (times[i] + diff) % 2400;
            }
        }

        Console.WriteLine("New Medicine Schedule:");
        DisplayTime(times);
    }

    /// <summary>Prints each schedule time in hour-and-minute format.</summary>
    private static void DisplayTime(int[] times)
    {
        foreach (int value in times)
        {
            string time = value.ToString();
            int length = time.Length;
            if (length >= 3)
            {
                time = time.Insert(length - 2, ":");
            }
            else if (length == 2)
            {
                time = time.Insert(0, "0:");
            }
            else
            {
                time = time.Insert(0, "0:0");
            }
            Console.Write($"{time} ");
        }
        Console.WriteLine();
    }
}