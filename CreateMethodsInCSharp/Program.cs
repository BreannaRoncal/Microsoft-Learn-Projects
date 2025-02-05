/* Create a method to display random numbers 



displayRandomNumber();

void displayRandomNumber()
{
    Random randomNumber = new Random();
    int result = randomNumber.Next();
    Console.WriteLine(result);
}
*/

/* Create methods to perform the repeated tasks



using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

displayTime();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    // Adjust the times by adding the difference, keeping the value within 24 hours 
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    // Adjust the times by adding the difference, keeping the value within 24 hours 
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

Console.WriteLine("New Medicine Schedule:");

displayTime();

Console.WriteLine();


// Turn the foreach loops into a reusable method to display the time
void displayTime()
{
    // Format and display medicine times
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
}

*/

/* Use methods to structure code
    - Suppose you're a candidate in a coding interview. The interviewer wants you to write a program that checks whether 
        an IPv4 address is valid or invalid. You're given the following rules:
        - A valid IPv4 address consists of four numbers separated by dots
        - Each number must not contain leading zeroes
        - Each number must range from 0 to 255
        - 1.1.1.1 and 255.255.255.255 are examples of valid IP addresses.

    - The IPv4 address is provided as a string. You can assume that it only consists of digits and 
        dots (there are no letters in the string provided).

    Pseudocode:
        if ipAddress consists of 4 numbers
        and
        if each ipAddress number has no leading zeroes
        and
        if each ipAddress number is in range 0 - 255

        then ipAddress is valid

        else ipAddress is invalid



string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ipv4 in ipv4Input)
{
    address = ipv4.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ipv4} ip is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ipv4} ip is an invalid IPv4 address");
    }
}

void ValidateLength(){

    validLength = address.Length == 4;
}

void ValidateZeroes()
{

    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;
}

void ValidateRange()
{

    foreach (string number in address)
    {
        
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

// Console.WriteLine($"{validLength} {validZeroes} {validRange}");

*/

/* Code challenge: create a reusable method
    In the code that you start with, there's a generic text array, followed by good, bad, and neutral text arrays. 
    Depending on the value of luck, one of the arrays is selected and displayed alongside the generic text.

    Your challenge is to create a reusable method that prints a player's fortune at any time. 
    The method should contain the logic that is already present in the code provided.


Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }

}

*/

/* Variable Scope



string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

*/


/* In this exercise, you'll learn how to use both named and optional parameters.

    Create an RSVP application
    In this task, you'll create a brief application for guests to RSVP to an event. 
    The guests will provide their party size and any allergies. 
    You'll also add the option to restrict RSVPs to an invite-only guest list.



string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) 
{
    if (inviteOnly)
    {
        bool found = false;
        // search guestList before adding rsvp
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
            
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list.");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

*/


/*Display email addresses
    Your challenge is to create a method that displays the correct email address for both internal and external employees. 
    You're given lists of internal and external employee names. An employee's email address consists of their username and company domain name.

    The username format is the first two characters of the employee first name, followed by their last name. 
    For example, an employee named "Robert Bavin" would have the username "robavin". The domain for internal employees is "contoso.com".


    ~~~~~ Solution using methods with parameters ~~~~~

    string[,] corporate = 
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

	string[,] external = 
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

	string externalDomain = "hayworth.com";

	for (int i = 0; i < corporate.GetLength(0); i++) 
	{
		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
	}

	for (int i = 0; i < external.GetLength(0); i++) 
	{
		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
	}

	void DisplayEmail(string first, string last, string domain = "contoso.com") 
	{
		string email = first.Substring(0, 2) + last;
		email = email.ToLower();
		Console.WriteLine($"{email}@{domain}");
	}


    ~~~~~ Another Solution: ~~~~~

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";


void DisplayInternalEmails(){
    for (int i = 0; i < corporate.GetLength(0); i++) 
    {
        // display internal email addresses
        Console.WriteLine($"{corporate[i, 0].Substring(0, 2).ToLower()}{corporate[i, 1].ToLower()}@{internalDomain}");
    }

}


void DisplayExternalEmails()
{
    for (int i = 0; i < external.GetLength(0); i++) 
    {
        // display external email addresses
        Console.WriteLine($"{external[i, 0].Substring(0, 2).ToLower()}{external[i, 1].ToLower()}@{externalDomain}");
    }

}

DisplayInternalEmails();
DisplayExternalEmails();

*/

/* Create a method to reverse words in a sentence
    Suppose your interviewer asks you a follow up question. 
    They want you to reverse each word in a given sentence, maintaining the original position of each word. 
    You can assume each word is separated by a space. 
        For example, "string return type" would become "gnirts nruter epyt". 



string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string result = "";

    string[] words = input.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();

}

string ReverseWord(string word)
{
    string result = "";
    
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}

*/

/* Check if a word is a palindrome


string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while ( start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}

*/


/* Dice mini-game challenge
    Your challenge is to design a mini-game. The game should select a target number that is a random number between one and five (inclusive). 
    The player must roll a six-sided dice. To win, the player must roll a number greater than the target number. 
    At the end of each round, the player should be asked if they would like to play again, and the game should continue or terminate accordingly.



Random randomNum = new Random();
string? readResult;

Console.WriteLine("Would you like to play? (y/n)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    bool wantsToPlay = true;
    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            readResult.ToLower().Trim();
            if (readResult == "y")
            {
                wantsToPlay = true;
                //Console.WriteLine(wantsToPlay);
                return true;
            }
            else if (readResult == "n")
            {
                wantsToPlay = false;
                //Console.WriteLine(wantsToPlay);
                return false;
            }
            else
            {
                Console.WriteLine("Please choose (y/n)");
            }
        }
    } while (wantsToPlay);
    return wantsToPlay;
}

void PlayGame()
{
    //Console.WriteLine("Inside PlayGame()");
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (y/n)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return randomNum.Next(1, 6);
}

int RollDice()
{
    return randomNum.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    return roll > target ? "You win!" : "You lose :("; 
}


*/

/* Project overview
    You're developing an application for the Contoso Petting Zoo that coordinates school visits. 
    The Contoso Petting Zoo is home to 18 different species of animals. At the zoo, visiting students are assigned to groups, 
    and each group has a set of animals assigned to it. After visiting their set of animals, the students will rotate groups 
    until they've seen all the animals at the petting zoo.

    By default, the students are divided into 6 groups. However, there are some classes that have a small or large number of students, 
    so the number of groups must be adjusted accordingly. The animals should also be randomly assigned to each group, 
    so as to keep the experience unique.

    The design specification for the Contoso Petting Zoo application is as follows:

    There are currently three visiting schools
        - School A has six visiting groups (the default number)
        - School B has three visiting groups
        - School C has two visiting groups

    For each visiting school, perform the following tasks
        - Randomize the animals
        - Assign the animals to the correct number of groups
        - Print the school name
        - Print the animal groups



using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);


// Plan School Visits
void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroups(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

// Randomize the animals
void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int randomIndex = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[randomIndex];
        pettingZoo[randomIndex] = temp;
    }
}


// Assign the animals to the correct number of groups
string[,] AssignGroups(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}


// Print the animal groups
void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

*/


/* Suppose you want to create your own game. You might not be ready to develop a fully featured game, so you decide to start as small as possible. 
    - You want to move a character across the screen and make it consume an object. 
    - The object consume can affect the state of the player. 
    - To keep the game going, you wanted to regenerate the object in a new location once it has been consumed. 
    - You decide that you'll need to use methods to keep your game code organized.

    In this module, you'll develop the following features of a mini-game application:
        - A feature to determine if the player consumed the food
        - A feature that updates player status depending on the food consumed
        - A feature that pauses movement speed depending on the food consumed
        - A feature to regenerate food in a new location
        - An option to terminate the game if an unsupported character is pressed
        - A feature to terminate the game if the Terminal window was resized

*/


using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    if (TerminalResized()) 
    {
        Console.Clear();
        Console.Write("Console was resized. Program exiting.");
        shouldExit = true;
    } 
    else 
    {
        if (PlayerIsFaster()) 
        {
            Move(1, false);
        } 
        else if (PlayerIsSick()) 
        {
            FreezePlayer();
        } else 
        {
            Move(otherKeysExit: false);
        }
        if (GotFood())
        {
            ChangePlayer();
            ShowFood();
        }
    }
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Returns true if the player location matches the food location
bool GotFood() 
{
    return playerY == foodY && playerX == foodX;
}

// Returns true if the player appearance represents a sick state
bool PlayerIsSick() 
{
    return player.Equals(states[2]);
}

// Returns true if the player appearance represents a fast state
bool PlayerIsFaster() 
{
    return player.Equals(states[1]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(int speed = 1, bool otherKeysExit = false) 
{
    int lastX = playerX;
    int lastY = playerY;
    
    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX--; 
            break;
		case ConsoleKey.RightArrow: 
            playerX++; 
            break;
		case ConsoleKey.Escape:     
            shouldExit = otherKeysExit;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}