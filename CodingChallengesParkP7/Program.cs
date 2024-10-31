using System;
using System.Runtime.InteropServices;

class Challenges
{



    public static void Main(string[] args)
    {
        //Welcome the user to the program
        
        MainMenu();
        










    }
    
    public static void MainMenu()
    {
        Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use. \nPlease pick one.");
        Console.WriteLine("\n1. Add two numbers \n2. Convert minuttes to seconds \n3. Add one to a number \n4. Find the circuit power \n5. Convert years to days \n6. Find the area of a triangle " +
            "\n7. Number less than or greater than Zero \n8. Check if the sum of two numbers is greater tthan or less than 100 \n9. Check if two numbers are equal \n10. Add the phrase 'something' to an argument.");
        
        var funcSelect = Console.ReadLine();
        Console.Clear();

        if (funcSelect == "1")
        {


            Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");


            var number1 = Console.ReadLine();
            float numberToUse1;
            while(!float.TryParse(number1, out numberToUse1))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                number1 = Console.ReadLine();
            }
            Console.WriteLine("Got it, give me another. \n");

            var number2 = Console.ReadLine();
            float numberToUse2 = float.Parse(number2);
            while (!float.TryParse(number2, out numberToUse2))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                number2 = Console.ReadLine();
            }

            Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));

        }
        else if (funcSelect == "2")
        {
            Console.WriteLine("We are going to use the minute-seconds converter today called converter. Please give me a number of minute(s).");

            var minutes = Console.ReadLine();
            int seconds = 60;
            float minutesToUse1;
            while (!float.TryParse(minutes, out minutesToUse1))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                minutes = Console.ReadLine();
            }

            Console.WriteLine(minutes + " minute(s) is equal to " + Converter(minutesToUse1, seconds) + " seconds.");

        }
        else if (funcSelect == "3")
        {
            Console.WriteLine("We are going to use a tool to add one to a number. Please give me a number.");

            var numberOne = Console.ReadLine();
            float numToUse = float.Parse(numberOne);

            Console.WriteLine(numberOne + " + 1 is equal to: " + AddOne(numToUse));
        }
        else if (funcSelect == "4")
        {
            Console.WriteLine("We are going to find the circuit power by using CircuitPower. \nFirst give me a voltage. ");
            var voltage = Console.ReadLine();
            float voltageToUse = float.Parse(voltage);

            Console.WriteLine("Got it, now give me the current.");

            var current = Console.ReadLine();
            float currentToUse = float.Parse(current);

            Console.WriteLine("A voltage of: " + voltage + " and a current of: " + current + " gives a power of: " + CircuitPower(voltageToUse, currentToUse));
        }
        else if (funcSelect == "5")
        {
            Console.WriteLine("Yo, today we're gonna use a function that converts the amount of years to days. \nGive me a number of years");
            var age = Console.ReadLine();
            float ageToUse = float.Parse(age);
            float daysInYear = 365;

            Console.WriteLine(age + " Year(s) is " + AgeConverter(ageToUse, daysInYear) + " days");
        }
        else if (funcSelect == "6")
        {
            Console.WriteLine("We are going to find the area of a triangle by using its base and height. \nFirst give me the base of the triangle.");
            var triBase = Console.ReadLine();
            float baseToUse = float.Parse(triBase);
            Console.WriteLine("Got it, now give me the height of the triangle.");
            var triHeight = Console.ReadLine();
            float heightToUse = float.Parse(triHeight);
            Console.WriteLine("A base of " + triBase + " and a height of " + triHeight + "\ngives a triangle with an area of: " + TriangleArea(baseToUse, heightToUse));
        }
        else if (funcSelect == "7")
        {
            Console.WriteLine("Today we will see if a number is less than or equal to zero. \nGive me a number and if it is less than or equal to zero I will say true, otherwise I will say false.");
            var zeroLess = Console.ReadLine();
            float numberZero = float.Parse(zeroLess);
            Console.WriteLine(LessThanZero(numberZero));
        }
        else if(funcSelect == "8")
        {
            Console.WriteLine("Today we will see if the sum of a number is less than 100. \nIf it is we will say true and if it isn't we will say false.");
            var firstNumber = Console.ReadLine();
            float firstNumberToUse;
            while (!float.TryParse(firstNumber, out firstNumberToUse))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                firstNumber = Console.ReadLine();
            }
            Console.WriteLine("Aight, give me another.");

            var secondNumber = Console.ReadLine();
            float secondNumberToUse;
            while (!float.TryParse(secondNumber, out secondNumberToUse))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                secondNumber = Console.ReadLine();
            }
            Console.WriteLine(IsOneHundred(firstNumberToUse, secondNumberToUse));

        }
        else if(funcSelect == "9")
        {
            Console.WriteLine("Today we will see if two numbers are the same. \nIf they are the same we will say true and not we will say false. \nPlease give me a number.");
            var equalOne = Console.ReadLine();
            float firstEqual;
            while (!float.TryParse(equalOne, out firstEqual))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                equalOne = Console.ReadLine();
            }
            Console.WriteLine("Give me another number.");
            var equalTwo = Console.ReadLine();
            float secondEqual;
            while (!float.TryParse(equalTwo, out secondEqual))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                equalTwo = Console.ReadLine();
            }
            if (IsEqual(firstEqual, secondEqual) == true)
            {
                Console.WriteLine(equalOne + " and " + equalTwo + " are the same" );
            }
            else
            {
                Console.WriteLine(equalOne + " and " + equalTwo + " are not the same");
            }

        }
        else if (funcSelect == "10")
        {
            Console.WriteLine("Today we will join the phrase'Something' with another argument.");
            string somethingArgument = Console.ReadLine();
            Console.WriteLine("Something " + somethingArgument);
        }
        else
        {
            Console.WriteLine("Please pick again, the function you are trying to access does not exist yet.");
            Console.WriteLine("Press any buttton to go back to the main menu");
            var clearConsole2 = Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
        

        Console.WriteLine("Press any buttton to go back to the main menu");
        var clearConsole = Console.ReadLine();
        Console.Clear();
        MainMenu();
    }

    public static float Sum(float number1, float number2)
    {
        return number1 + number2;
    }

    public static float Converter(float minutes, int seconds)
    {
        return minutes * seconds;
    }

    public static float AddOne(float numberOne)
    {
        return numberOne += 1;
    }

    public static float CircuitPower(float voltage, float current)
    {
        return voltage * current;
    }

    public static float AgeConverter(float age, float daysInYear)
    {
        return age * daysInYear;
    } 

    public static float TriangleArea(float triBase, float triHeight)
    {
        return (triBase * triHeight) / 2;
    }

    public static bool LessThanZero(float zeroLess)
    {
        if (zeroLess <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public static bool IsOneHundred(float firstNumber, float secondNumber)
    {
        if((firstNumber + secondNumber < 100))
        {
            return true ;
        } 
        else
        {
            return false;
        }
    }

    public static bool IsEqual(float equalOne, float equalTwo)
    {
        if (equalOne == equalTwo)
        {
            return true ;
        }
        else
        {
            return false;
        }
    }

    

}
