// Work with variable data

/* Challenge: 
    Combine string array values as strings and as integers

    - Rule 1: If the value is alphabetical, concatenate it to form a message.
    - Rule 2: If the value is numeric, add it to the total.
    - Rule 3: The result should match the following output:

    Output

        Message: ABCDEF
        Total: 68.3
 

 string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0.0m;
decimal current = 0.0m;

 foreach (string val in values)
 {
    if (decimal.TryParse(val, out current))
    {
        total += current;
    }
    else
    {
        message += val;
    }
 }

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total {total}");

*/


/* Join() and Split() 

string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);

// Reverse string with no spaces
// string result = new string(valueArray);

// Reverse string with ',' between characters
string result = string.Join(",", valueArray);

Console.WriteLine(result);

// Split result on ','
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

*/

/* challenge to reverse words in a sentence 

string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");
string[] reversedWords = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    reversedWords[i] = new string(letters);
}

string result = string.Join(" ", reversedWords);

Console.WriteLine(result);

*/

/* Complete a challenge to parse a string of orders, sort the orders and tag possible errors

    Output:
        A345
        B123
        B177
        B179
        C15     - Error
        C234
        C235
        G3003   - Error


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(",");
Array.Sort(orderArray);
foreach (var order in orderArray)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"{order}\t- Error");
    }
    else
    {
        Console.WriteLine(order);
    }
}

*/

/* Formatting currency

decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (Save: {discount:C})");

*/

/* Formatting numbers to a set precision

    Output:
        Measurement: 123,456.79 units

    N4 determines the precision value

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

*/

/* Display the invoice number using string interpolation

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number:\t{invoiceNumber}");

// Display shares to the 3rd decimal place
Console.WriteLine($"    Shares:\t{productShares:N3} Product");

// Display the subtotal that you charge the customer formatted as currency
Console.WriteLine($"    Sub Total:\t{subtotal:C}");

// Display the tax charged on the sale formatted as a percentage
Console.WriteLine($"    Tax:\t{taxPercentage:P2}");

// Finalize the receipt with the total amount due formatted as currency
Console.WriteLine($"    Total:\t{total:C}");

*/

/* Working with padded strings


string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string payeeAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += payeeAmount.PadRight(10);

// Since it's difficult to count the exact columns where each data element appears, you add a line directly above the output that helps you count the columns.
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

*/

/* Complete a challenge to apply string interpolation to a form letter
    Output:

    Dear Ms. Barros,
    As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

    Currently, you own 2,975,000.00 shares at a return of 12.75%.

    Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

    Here's a quick comparison:

    Magic Yield         12.75%   $55,000,000.00      
    Glorious Future     13.13%   $63,000,000.00


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current Volume, your potential profit would be {newProfit:C2}\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
// currentProduct
comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C2}\n", currentProfit);

// newProduct
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C2}\n", newProfit);

Console.WriteLine(comparisonMessage);

*/

/* Use the string's IndexOf() and Substring() helper methods
    - Add const to keep track of the substring you want to find in order to avoid "magic numbers" or hard coded numbers to make code cleaner.



string message = "Find what is <span>inside the parentheses</span>";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

// Console.WriteLine($"Opening Position: {openingPosition}\nClosing Position: {closingPosition}");
// Get string inside of the parentheses
openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

*/

/* Retrieve all instances of substrings inside parentheses



string message = "(What if) there are (more than) one (set of parentheses)?";

while (true)
{
    int openingPosition = message.IndexOf("(");
    
    if (openingPosition == -1){
        break;
    }
    
    openingPosition += 1;
    int closingPosition = message.IndexOf(")");
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);

}

*/

/* Work with different types of symbol sets with IndexOfAny()



string message = "Help (find) the {opening symbols} in the secret [archives]";
Console.WriteLine($"Search THIS message: {message}");

char[] openSymbols = ['(', '{', '['];

int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");


openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

*/

/* Complete a challenge to extract, replace, and remove data from an input string

*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Extract quantity from string
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;

quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Replace "&trade" with "&reg"
const string tradeSymbol = "&trade";
const string regSymbol = "&reg";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag         
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divEnd = output.IndexOf(closeDiv);
output = output.Remove(divEnd, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

