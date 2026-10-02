class Task1 {
    public static void Run() {
    Console.Write("What's your name? ");
    string? name = Console.ReadLine();
    Console.Write("how old are you? ");
    string? age = Console.ReadLine();

    Console.WriteLine($"Your name is {name} and you are {age} years old!");

    }
}