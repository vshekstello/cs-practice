class Task2
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