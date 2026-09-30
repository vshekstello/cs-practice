static class Task1
{
    /// <summary>Prompts for a user's name and age, then prints a personalized greeting.</summary>
    public static void Run()
    {
        Console.WriteLine("Personalized Greeting");
        Console.Write("What's your name?");
        string? name = Console.ReadLine();
        Console.Write("How old are you?");
        string? age = Console.ReadLine();
        Console.WriteLine($"Hey there. Your name is {name} and you are {age} years old");
    }
}

static class Task2
{
    /// <summary>Checks the entered level against the configured user permission rules.</summary>
    public static void Run()
    {
        Console.WriteLine("User Permission Check");
        Console.Write("What is your level? (don't lie) ");
        string permission = "Admin|Manager";
        int level = Convert.ToInt32(Console.ReadLine());

        if (permission.Contains("Admin"))
        {
            Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user");
        }
        else if (permission.Contains("Manager") && level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
}

static class Task3
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

static class Task4
{
    /// <summary>Validates and reports the configured IPv4 address examples.</summary>
    public static void Run()
    {
        Console.WriteLine("IP checker");
        string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };

        foreach (string ip in ipv4Input)
        {
            string[] address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
            bool validLength = address.Length == 4;
            bool validZeroes = address.All(number => number.Length <= 1 || !number.StartsWith("0"));
            bool validRange = address.All(number => int.TryParse(number, out int value) && value is >= 0 and <= 255);

            Console.WriteLine(validLength && validZeroes && validRange
                ? $"{ip} is a valid IPv4 address"
                : $"{ip} is an invalid IPv4 address");
        }
    }
}

static class Task5
{
    /// <summary>Selects and prints a randomized fortune.</summary>
    public static void Run()
    {
        Console.WriteLine("Randomized Fortune Teller");
        int luck = Random.Shared.Next(100);
        string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
        string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
        string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
        string[] fortune = luck > 75 ? good : luck < 25 ? bad : neutral;

        Console.WriteLine("A fortune teller whispers the following words:");
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write($"{text[i]} {fortune[i]} ");
        }
    }
}