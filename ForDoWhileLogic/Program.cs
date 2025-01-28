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

*/

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

