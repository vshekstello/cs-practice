//  TASK 1 // 
// Console.Write("What's your name?");
// string name = Console.ReadLine();

// Console.Write("How old are you?");
// string age = Console.ReadLine();

// Console.WriteLine($"Hey there. Your name is {name} and you are {age} years old");




// TASK 2 //

// string permission = "Admin|Manager";
// int level = 52;

// if (permission.Contains("Admin")) {
//     if (level > 55) {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else {
//         Console.WriteLine("Welcome, Admin user");
//     }
// }
// else if (permission.Contains("Manager")) {
//     if (level >= 20) {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else {
//     Console.WriteLine("You do not have sufficient privileges.");
// }



// TASK 3 //

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");
// DisplayTime();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     AdjustTime();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     AdjustTime();
// }

// Console.WriteLine("New Medicine Schedule:");
// DisplayTime();

// void DisplayTime()
// {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3) {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2) {
//             time = time.Insert(0, "0:");
//         }
//         else {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
//     Console.WriteLine();
// }

// void AdjustTime() 
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }



// TASK 4 //

// string[] ipInputs = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;

// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipInputs) {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) {
//         Console.WriteLine($"{ip} is valid");
//     } 
//     else {
//         Console.WriteLine($"{ip} is not valid");
//     }
// }


// void ValidateRange() 
// {
//     foreach (string number in address) {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// };

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) {
//         if (number.Length > 1 && number.StartsWith("0")) {
//             validZeroes = false;
//             return;
//         }
//     }
//     validZeroes = true;
// };



// TASK 5 //

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// TellFortune();

// void TellFortune() 
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }