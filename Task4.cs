class Task4
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