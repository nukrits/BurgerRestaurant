using System.ComponentModel.Design;

int orderMode;
Console.WriteLine("Select the order mode:  1. Ready Burgers   2.  Build A Burgers");
orderMode = int.Parse(Console.ReadLine());


switch (orderMode)
{ 
    case 1:

Console.WriteLine("Choose a burger  :  Cheesburger, Hamburger,Brandburger");
string _ = Console.ReadLine();
if (_ == "Cheesburger")
{
    Console.WriteLine("You Order  'Cheesburger'  :  Bun, melted cheese, lettuce, pickles, hot sauce");
}
else if (_ =="Hamburger")
{
    Console.WriteLine("You Order 'Hamburger'  :  Bun, lettuce, pickles, beef meat, sweet sauce");
}
else if (_ == "Brandburger")
{
    Console.WriteLine("You Order 'Brandburger'  :  Bun, lettuce, pickles, chicken meat, signature sauce");
}
else
{
    Console.WriteLine("Other burgers are not ready");
}
        break;

        case 2:
        string Sauce;
        string Cheese;
        string Meat;
        string Cucumber;


        Console.WriteLine("Add cheese?");
        Console.WriteLine("1 - Yes  || 2  - No" );

        int result = int.Parse(Console.ReadLine());

        
        if (result ==1)
        {
            Cheese = "cheese";
        }
        else  
        {
            Cheese = "";
        }
        
       


        Console.WriteLine("Add meat?");
        Console.WriteLine("1 - chicken meet || 2 - beef meet || 3  -  No");

        int result1 = int.Parse(Console.ReadLine());
        
        if (result1 ==1)
        {
            Meat = "chicken meat";
        }
        else if (result1 ==2) 
        {
            Meat = "bif meat";
        }
        else
        {
            Meat = "";
        }

        Console.WriteLine("Add cucumber?");
        Console.WriteLine("1 - Yes || 2 - No");
        int result2 = int.Parse(Console.ReadLine());
        if (result2 ==1)
        {
            Cucumber = "cucumber";
        }
        else
        {
            Cucumber = "";
        }
        

        Console.WriteLine("Add sauce?(Spicy, sweet, signature, none)");
        Console.WriteLine("1 - spicy  ||  2 - sweet  ||  3 - signature  ||  4 - none");
        int result3 = int.Parse(Console.ReadLine());
        if (result3 == 1)
        {
            Sauce = "spicy";
        }
        else if (result3 == 2)
        {
            Sauce = "sweet";
        }
        else if(result3 == 3)
        {
            Sauce = "signature";
        }
        else
        {
            Sauce = "";
        }


        Console.WriteLine("You Order Personal Burger");
        Console.WriteLine($"The ingredients for your burger are:   Bun, lettuce, + {Cheese} + {Meat} + {Cucumber} + {Sauce}");


        break;
}