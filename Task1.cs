class Task1
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