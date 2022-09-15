// See https://aka.ms/new-console-template for more information
Console.WriteLine("Good morning, and welcome to the buffet, all you can eat for $9.99 per guest. We are currently accepting parties of 6 or fewer. How many are in your party?");
string number = Console.ReadLine();

int party = int.Parse(number);
if (party > 6)
    Console.WriteLine("I'm sorry, we only seat parties of 6 or fewer. Please try Olive Garden instead.");
if (party <= 6)
    Console.WriteLine("Excellent! Table for " + party + " coming right up. Please have a seat. We serve pop or water. Pop is $3 and water is $1.");

do
{
    Console.WriteLine("Customer number " + 1 + " would you like pop or water?");
    string i = Console.ReadLine();

    char beverage = int.Parse(i);

    do
    {
        Console.WriteLine("Great! One " + beverage + " coming right up!");
    }
    while (beverage is "pop" or "water");


}
while (party <= 6);

Console.WriteLine("The total bill price is " + party * 9.99);	
		
		}
	}
