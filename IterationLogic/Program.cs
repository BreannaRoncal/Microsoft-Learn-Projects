/* For loop counting up from 0 to 9

for (int i = 0; i < 10; i++){
    Console.WriteLine(i);
}
*/

/* FizzBuzz 

for (int i = 1; i <= 100; i++){
    string isFizzBuzz = "";
    if (i % 3 == 0 && i % 5 == 0)
        isFizzBuzz = " - FizzBuzz";
    else if (i % 3 == 0)
        isFizzBuzz = " - Fizz";
    else if (i % 5 == 0)
        isFizzBuzz = " - Buzz";

    Console.WriteLine($"{i}{isFizzBuzz}");
}
*/

/* Do-While 
    write random number until it prints out 7

Random randomNum = new Random();
int currentNum = 0;

do
{
    currentNum = randomNum.Next(1, 11);
    Console.WriteLine(currentNum);
}
while (currentNum != 7);
*/

/* While
    write random number as long as it's
    greater or equal to 3


Random randomNum = new Random();
int currentNum = randomNum.Next(1, 11);

while (currentNum >= 3)
{
    Console.WriteLine(currentNum);
    currentNum = randomNum.Next(1, 11);
}
Console.WriteLine($"Last random number: {currentNum}");
*/

/* Do-While
    Continue keyword skips over the rest of the do statements
    --> Values greater than or equal to 8 are not printed
    --> The continue keyword to step immediately to the Boolean expression.


Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) 
        continue;

    Console.WriteLine(current);
} while (current != 7);

*/

/* RPG Battle 
    In this challenge, we boil down that interaction to its essence. A hero and a monster start with the same health score. 
    During the hero's turn, they generate a random value that is subtracted from the monster's health. 
    If the monster's health is greater than zero, they take their turn and attack the hero. 
    As long as both the hero and the monster have health greater than zero, the battle resumes.

    Rules:
        1. The hero and the monster start with 10 health points.
        2. All attacks are a value between 1 and 10.
        3. The hero attacks first.
        4. Print the amount of health the monster lost and their remaining health.
        5. If the monster's health is greater than 0, it can attack the hero.
        6. Print the amount of health the hero lost and their remaining health.
        7. Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
        8. Print the winner.



int heroHP = 10;
int monsterHP = 10;
int heroATK = 0;
int monsterATK = 0;

Random randomNum = new Random();



while (heroHP > 0 && monsterHP > 0)
{
    // Hero's turn
    heroATK = randomNum.Next(1, 11);
    monsterHP -= heroATK;

    Console.WriteLine($"Hero's attack is: {heroATK}. The monster has {monsterHP} HP remaining.");

    // Monster's turn
    if (monsterHP > 0)
    {
        monsterATK = randomNum.Next(1, 11);
        heroHP -= monsterATK;

        Console.WriteLine($"Monster's attack is: {monsterATK}. The hero has {heroHP} HP remaining.");

    }
}

Console.WriteLine(heroHP > 0 ? "The Hero is the winner!" : "The Monster is the winner! :(");

*/

/* Do-While
    Use a do-while loop to prompt the user until they input a valid integer
    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

    Inside the iteration block:
        1. Your solution must use a Console.ReadLine() statement to obtain input from the user.
        2. Your solution must ensure that the input is a valid representation of an integer.
        3. If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() 
            statement to prompt the user for an integer value between 5 and 10.
        4. Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
        5. Below (after) the iteration code block: your solution must use a Console.WriteLine() statement 
            to inform the user that their input value has been accepted.



string? readResult;
int numericValue = 0;
bool validEntry = false;
Console.WriteLine("Enter an integer between 5 and 10 and then press Enter.");

do
{
    readResult = Console.ReadLine();
    int.TryParse(readResult, out numericValue);

    if (numericValue < 5 || numericValue > 10)
    {
        Console.WriteLine("Your number must be an integer between 5 and 10. Try again");
    }
    else{
        validEntry = true;

    }
} while (validEntry == false);

Console.WriteLine($"Your integer: {numericValue} has been accepted");

*/

/* Write code to validate a string input
    - Your solution must include either a do-while or while iteration.
    - Before the iteration block: your solution must use a Console.WriteLine() statement to 
        prompt the user for one of three role names: Administrator, Manager, or User.

    - Inside the iteration block:
        1. Your solution must use a Console.ReadLine() statement to obtain input from the user.
        2. Your solution must ensure that the value entered matches one of the three role options.
        3. Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
        4. Your solution should use the ToLower() method on the input value to ignore case.
        5. If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() 
            statement to prompt the user for a valid entry.

    - Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user 
        that their input value has been accepted.



string? readResult;
bool validEntry = false;
string[] validInputs = ["administrator", "manager", "user"];

Console.WriteLine("Are you an Administrator, Manager, or User?");

do
{
    readResult = Console.ReadLine().Trim().ToLower();
    
    if (validInputs.Contains(readResult)){
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"Your input of \"{readResult}\" is incorrect. Please input Administrator, Manager, or User");
    }
} while (validEntry == false);

Console.WriteLine($"Welcome {readResult}. Input accepted.");

*/

/* Guided Project: Develop conditional branching and looping structures

    - Store application data in a multidimensional string array named ourAnimals.

    - The ourAnimals array includes the following "pet characteristics" for each animal:
        - Pet ID #.
        - Pet species (cat or dog).
        - Pet age (years).
        - A description of the pet's physical condition/characteristics.
        - A description of the pet's personality.
        - The pet's nickname.
    
    - Implement a sample dataset that represents dogs and cats currently in your care.

    - Display menu options to access the main features of the application.

    - The main features enable the following tasks:
        - List the pet information for all animals in the ourAnimals array.
        - Add new animals to the ourAnimals array. The following conditions apply:
            - The pet species (dog or cat) must be entered when a new animal is added to the ourAnimals array.
            - A pet ID must be programmatically generated when a new animal is added to the ourAnimals array.
            - Some physical characteristics for a pet may be unknown until a veterinarian's examination. For example: age, breed, and neutered/spayed status.
            - An animal's nickname and personality may be unknown when a pet first arrives.

    - Ensure animal ages and physical descriptions are complete. This may be required after a veterinarian's examination.
    - Ensure animal nicknames and personality descriptions are complete (this action can occur after the team gets to know a pet).
    - Edit an animal’s age (if a pet's birth date is known and the pet has a birthday while in our care).
    - Edit an animal’s personality description (a pet may behave differently after spending more time in our care).
    - Display all cats that meet user specified physical characteristics.
    - Display all dogs that meet user specified physical characteristics.

    - The code displays the following main menu options for user selection:
        - List all of our current pet information.
        - Assign values to the ourAnimals array fields.
        - Ensure animal ages and physical descriptions are complete.
        - Ensure animal nicknames and personality descriptions are complete.
        - Edit an animal’s age.
        - Edit an animal’s personality description.
        - Display all cats with a specified characteristic.
        - Display all dogs with a specified characteristic.
        - Enter menu item selection or type "Exit" to exit the program

    - The code reads the user's menu item selection and displays a message echoing their selection.

    - Your goal is to develop the features that implement the first two menu options. To achieve this goal, you'll complete the following tasks:
        - Update the code that's used to create the sample data for the app.
        - Construct a loop around the main menu and create a selection statement that establishes a code branch for each menu option.
        - Write the code to display all ourAnimals array data (menu option 1).
        - Build a loop for entering new ourAnimals array data (menu option 2 - part 1).
        - Write code to read and save new ourAnimals array data (menu option 2 - part 2).

*/

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
int petCount = 0;
string anotherPet = "y";
bool validEntry = false;
int petAge = 0;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        
        case 4:
            animalSpecies = "cat";
            animalID = "c5";
            animalAge = "123";
            animalPhysicalDescription = "Black and white";
            animalPersonalityDescription = "observant";
            animalNickname = "meow meow";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;


    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");

    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower().Trim();
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine();

    switch (menuSelection)
    {
        // List all of our current pet information
        case "1":
            //Console.WriteLine("In switch statement~~~~~~~~~~~~~~~~~");
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                        Console.WriteLine(ourAnimals[i, j]);
                }
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        // Add a new animal friend to the ourAnimals array
        case "2":

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pet(s) that need homes. We can manage {maxPets - petCount} more.");
            }

            

            while (anotherPet == "y" && petCount < maxPets)
            {
                // Check if animal species is a valid entry
                // Read and Validate the pet's species (cat or dog)
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower().Trim();

                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            Console.WriteLine($"{animalSpecies} is not valid. Please enter 'dog' or 'cat'.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }

                } while (validEntry == false);

                // Generate animalID value
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // Get valid pet age, can be ? as initial value
                //validEntry = false;
                do
                {
                    

                    Console.WriteLine("Enter the pet's age, can be '?' if unknown.");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                            validEntry = int.TryParse(animalAge, out petAge);
                        else
                            validEntry = true;
                    }


                } while (validEntry == false);

                // Read and validate the pet's physical description
                do
                {
                    Console.WriteLine("Enter the physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower().Trim();
                        if (animalPhysicalDescription == "")
                            animalPhysicalDescription = "tbd";
                    }


                } while (animalPhysicalDescription == "");

                // Read and validate the pet's personality description
                do
                {
                    Console.WriteLine("Enter the personality description of the pet (likes or dislikes, tricks, energy levels)");
                    readResult = Console.ReadLine();

                    if (readResult != null){
                        animalPersonalityDescription = readResult.ToLower().Trim();
                        if (animalPersonalityDescription == "")
                            animalPersonalityDescription = "tbd";
                    }
                } while (animalPersonalityDescription == "");

                // Read and validate the pet's nickname
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower().Trim();
                        if (animalNickname == "")
                            animalNickname = "tbd";
                    }
                } while (animalNickname == "");

                // Save new pet to ourAnimals list
                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;


                Console.WriteLine($"~~~~~~~~~~~ {petCount}{animalSpecies} {animalID} {animalPhysicalDescription} {animalPersonalityDescription} {animalNickname}");

                petCount += 1;
                
                if (petCount < maxPets)
                {
                    Console.WriteLine("Do you want to enter info for another pet? (y/n)");

                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower().Trim();
                        }
                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }
            
            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached the limit on the number of pets we can manage");
                Console.WriteLine("\n\rPress the Enter key to continue");
                readResult = Console.ReadLine();
            }

            break;

        // Ensure animal ages and physical descriptions are complete
        case "3":
            for (int i = 0; i < maxPets; i++)
            {
                // Ensure animal ages are complete
                if (ourAnimals[i, 2] == "Age: ?" && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalAge = readResult;
                            validEntry = int.TryParse(animalAge, out petAge);

                        }
                    } while (validEntry == false);
                    ourAnimals[i, 2] = "Age: " + animalAge.ToString();
                }

                // Ensure animal physical description is complete
                if (ourAnimals[i, 4] == "Physical description: " && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter the physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalPhysicalDescription = readResult.ToLower().Trim();
                            if (animalPhysicalDescription == "")
                            {
                                Console.WriteLine($"Please enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;

                            }
                        }
                    } while (validEntry == false);

                    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                }
            }

            Console.WriteLine("\n\rAge and physical description fields are complete for all our furry friends!");
            Console.WriteLine("Press Enter key to continue");
            readResult = Console.ReadLine();
            break;

        // Ensure animal nicknames and personality descriptions are complete
        case "4":
            for (int i = 0; i < maxPets; i++){
                // Ensure nicknames are complete
                if (ourAnimals[i, 3] == "Nickname: " && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalNickname = readResult.ToLower().Trim();
                            if (animalNickname == "")
                            {
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);
                    ourAnimals[i, 3] = "Nickname: " + animalNickname;
                }

                // Ensure personality descriptions are complete
                if (ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 0] != "ID #: ")
                {
                    do
                    {
                        Console.WriteLine($"Enter the personality description of the {ourAnimals[i, 0]} (likes or dislikes, tricks, energy levels)");
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            animalPersonalityDescription = readResult.ToLower().Trim();

                            if (animalPersonalityDescription == ""){
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);
                    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                }
            }

            Console.WriteLine("\n\rNickname and personality description are complete for all our furry friends!");
            Console.WriteLine("Press Enter key to continue");
            readResult = Console.ReadLine();
            break;


        
        // Exit program
        case "exit":
            continue;
            break;

        default:
            Console.WriteLine("Not a valid selection. Choose between 1 to 8");
            break;

    }

} while (menuSelection != "exit");
