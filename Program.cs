while (true)
{
	Console.WriteLine("\n Select a task (1-5) or 0 to quit: ");
    Console.WriteLine("1. Personalized greeting \n2. User Permission Check \n3. Timezone Conversion \n4.IP validator \n5. Randomized fortune teller");
	string? selection = Console.ReadLine();

	if (selection == "0")
	{
		break;
	}

	switch (selection)
	{
		case "1":
				Task1.Run();
			break;
		case "2":
				Task2.Run();
			break;
		case "3":
				Task3.Run();
			break;
		case "4":
				Task4.Run();
			break;
		case "5":
				Task5.Run();
			break;
		default:
			Console.WriteLine("Invalid input. Enter a number from 1 to 5.");
			break;
	}
}

