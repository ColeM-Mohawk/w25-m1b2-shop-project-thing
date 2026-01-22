// Step 1: Ask player for name and remember it
using System.ComponentModel.Design;

Console.WriteLine("Hello fair traveller.");
Console.WriteLine("Welcome to my humble shop.");
Console.WriteLine("You got a name don't you?");
string playername = Console.ReadLine();
Console.WriteLine($"Ah pleasure to meet ya {playername}.");

// Step 2: Ask player for sum olf held gold
Console.WriteLine("I see your looking to buy, how much gold are you carrying?");
int heldgold = int.Parse(Console.ReadLine());

//Step 3+: Tell player about sword, do they wish to purchase?
Console.WriteLine("Well I have a fine nice 'bronze sword' for sale, only 15 gold.");
Console.WriteLine("Do you wish to purchase it?");
string dopurchasesword = Console.ReadLine();

if (dopurchasesword == "yes")
{
    if (heldgold >= 15)
    {
        Console.WriteLine($"{playername} purchased 'bronze sword'.");
        heldgold -= 15;
        Console.WriteLine($"{playername} balance is now {heldgold}.");
    }
    else
    {
        Console.WriteLine("Sorry but you don't have enough coin, come back when you do.");
    }

}

else
{
    Console.WriteLine($"Thats a shame, stay safe on your journy {playername}");
}