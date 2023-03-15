// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello everybody");

Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine();
Console.WriteLine("Hello " + name);*/




/*Exercise2 CH2
Console.WriteLine("What is your name? ");
string name = Console.ReadLine();
Console.WriteLine("How old are you? (in years) ");
string age = Console.ReadLine();

Console.WriteLine("Your name is " + name + " and you're " + age + " years old");*/


/*Exercise1 CH2
Console.WriteLine(" What is your name? ");
string name = Console.ReadLine();
Console.WriteLine("From which city do you come from? ");
string city = Console.ReadLine();
Console.WriteLine("Where were you born? ");
string country = Console.ReadLine();

//Console.WriteLine("Hello " + name + " you are born in " + country + " and youre from the City of " + city); */


//Exercise 1 CH3 application data storage and output as string
/* Console.WriteLine("What is your name? ");
string name = Console.ReadLine();
Console.WriteLine("How tall are you? (in cm) ");
string height = Console.ReadLine();
Console.WriteLine("How old are you? (in years)");
string age = Console.ReadLine();
Console.WriteLine("Your name is " + name + " and you're " +age+" years old" + height + " and you're cm tall");*/

//Exercise 2 CH3 concatenating strings 
/*string movie = "Interstellar";
string name = "Felix";
Console.WriteLine("Your name is " + name + " and your favorite Movie is " + movie);*/

//Exercise 3 CH3 if statement

/*Console.WriteLine("Enter your number here please : ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
    Console.WriteLine("True");
else
    Console.WriteLine("False");*/

/*int number = 23;
bool a = number == 23;
Console.WriteLine("Number is 23: " + a);

bool b = number >= 23;
Console.WriteLine("Number is greater than 23: " + b);

bool c = (number >= 18) && (number <= 76);
Console.WriteLine("Number is between 18 and 76: " + c);

int number1 = 16;
int number2 = 80;

bool d = (number1 >= 23) && (number2 <= 76);
Console.WriteLine("Number1 is greater than 18 AND number2 is less than 76: " + d);
bool e = (number1 >= 23) || (number2 <= 76);
Console.WriteLine("Number1 is greater than 23 OR number2 is less than 76: " + e);*/

//Exercise4 CH3 date type 

/*DateTime newDate = new DateTime(2022,3, 28, 14, 30, 0);
Console.WriteLine(newDate);

DateTime nextDate = new DateTime(2025, 12, 11);

DateTime weekdayDate = new DateTime(2025, 12, 20);
*/


/*using System;
class GiveMeDayOfWeek
{
    static void Main(string[] args)
    {
        Console.Write("Enter a date (mm/dd/yyyy): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        string dayOfWeek = date.DayOfWeek.ToString();
        Console.WriteLine("The day of the week is {0}.", dayOfWeek);
        Console.ReadKey();
    }
}*/

//Exercise 5 CH3 Difference explicit and implicit typing
/*using System;

class DifferenceImplExpl
{
    static void Main(string[] args)
    {
        // Implicit Typing
        var number1 = 42;           // implicitly typed as int
        var message1 = "Hello!";    // implicitly typed as string

        // Explicit Typing
        int number2 = 42;           // explicitly typed as int
        string message2 = "Hello!"; // explicitly typed as string

    }
}
*/

//Exercise 6 CH3 Perform math operations
/*using System;

class MathStuff
{
    public static void Main(String[] args)
    {
        int a = 23;
        int b = 44;
        int c = (2*a) + (2*b);
        Console.WriteLine("c = "+c);
    }
}
*/


//Exercise 7 CH3 character into ASCII

/*using System;

class AsciiProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        char c = Console.ReadKey().KeyChar;

        int asciiValue = c;

        Console.WriteLine($"\nASCII value of {c} is {asciiValue}.");
    }
}
*/