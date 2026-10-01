class Task5
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