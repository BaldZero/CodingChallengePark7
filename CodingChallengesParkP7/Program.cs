using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
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
            "\n7. Number less than or greater than Zero \n8. Check if the sum of two numbers is greater than or less than 100 \n9. Check if two numbers are equal " +
            "\n10. Add the phrase 'something' to an argument \n11. Give the opposite of true or false. \n12. Convert hours into seconds. \n13. Take a polygon and return its sum of internal degrees." +
            "\n14. Take a string and add Edabit \n15. True and True. \n16. Find the amount of points a basketball player scored. \n17. Find the perimeter of a rectangle.\n18. Hello + Name\n19. Animal Legs" +
            "\n20. How many points?\n21. What Month? \n22. Min and Max \n23. Absolute Value Sum \n24. Exponents"  );
        
        var funcSelect = Console.ReadLine();
        Console.Clear();

        if (funcSelect == "1")
        {


            Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");


            var number1 = Console.ReadLine();
            float numberToUse1;
            while (!float.TryParse(number1, out numberToUse1))
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
        else if (funcSelect == "8")
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
        else if (funcSelect == "9")
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
                Console.WriteLine(equalOne + " and " + equalTwo + " are the same");
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
        else if (funcSelect == "11")
        {
            Console.WriteLine("Today you will be choosing true or false and we will give back the opposite of the function.");
            string trueOrFalse = Console.ReadLine();
            Console.WriteLine("The opposite of " + trueOrFalse + " is " + ReverseBool(trueOrFalse));

        }
        else if (funcSelect == "12")
        {
            Console.WriteLine("Today we shall convert hours into seconds. Please give me a number of hour(s)");
            var secHours = Console.ReadLine();
            float hourSecs;
            while (!float.TryParse(secHours, out hourSecs))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");
                secHours = Console.ReadLine();
            }
            if (hourSecs == 1)
            {
                Console.WriteLine(secHours + " hour is equal to " + HoursIntoSeconds(hourSecs));
            }
            else
            {
                Console.WriteLine(secHours + " hours is equal to " + HoursIntoSeconds(hourSecs));
            }


        }
        else if (funcSelect == "13")
        {
            Console.WriteLine("Give me a n sided polygon and I will return the sum of internal angles in degrees of the n sided polygon.");
            var nPolygon = Console.ReadLine();
            int nSides;
            while (!int.TryParse(nPolygon, out nSides))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");

                nPolygon = Console.ReadLine();
            }
            if (nSides > 2)
            {
                Console.WriteLine("A polygon with " + nSides + " sides has an internal angle sum of " + NSidedPolygonAngles(nSides));
            }
            else
            {
                Console.WriteLine("Please pick a number bigger than 2");

            }



        }
        else if (funcSelect == "14")
        {
            Console.WriteLine("Today we will be taking a sting and adding the word Edabit to it. Please give me a string");
            string passString = Console.ReadLine();
            var result = passString + "Edabit";
            Console.WriteLine(result);
        }
        else if (funcSelect == "15")
        {
            bool aTrue;
            bool bTrue;
            Console.WriteLine("Today I will be taking two vvalues and checking if they are both true. if they are I will return true.\nGive me true or false.");
            string trueA = Console.ReadLine();
            if (trueA == "true")
            {
                aTrue = true;
            }
            else
            {
                aTrue = false;
            }

            Console.WriteLine("Give me another value of true or false");
            string trueB = Console.ReadLine();
            if (trueB == "true")
            {
                bTrue = true;
            }
            else
            {
                bTrue = false;
            }

            Console.WriteLine("And(" + aTrue + ", " + bTrue + ") -> " + And(aTrue, bTrue));


        }
        else if (funcSelect == "16")
        {
            Console.WriteLine("Today we will calculate how many points a basketball player scored based on the number of 3-pointers dn 2-pointers they sccored.\nGive me the number of 3-pointers they scored.");
            var threePointers = Console.ReadLine();
            int threePoints;
            while (!int.TryParse(threePointers, out threePoints))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");

                threePointers = Console.ReadLine();
            }
            Console.WriteLine("Got it! Give me the amount of 2-pointers now please.");
            var twoPointers = Console.ReadLine();
            int twoPoints;
            while (!int.TryParse(twoPointers, out twoPoints))
            {
                Console.WriteLine("PICK AN INTEGER YOU FOOL");

                twoPointers = Console.ReadLine();
            }
            Console.WriteLine("points(" + threePointers + ", " + twoPointers + ") -> " + Points(threePoints, twoPoints));

        }
        else if (funcSelect == "17")
        {
            Console.WriteLine("Today we will find the perimeter of a rectangle.\nPlease give me a width.");
            var width = Console.ReadLine();
            float rectWidth;
            while (!float.TryParse(width, out rectWidth))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                width = Console.ReadLine();
            }
            Console.WriteLine("Got it, give me a length now.");
            var length = Console.ReadLine();
            float rectLength;
            while (!float.TryParse(length, out rectLength))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                length = Console.ReadLine();
            }
            Console.WriteLine("RectPerimeter(" + length +"," + width +") -> " + RectPerimeter(rectLength, rectWidth));

        }
        else if(funcSelect == "18")
        {
            Console.WriteLine("Yo, today we gonna be taking a name as a string and then saying hello.\nGive me someone's name.");
            string someonesName = Console.ReadLine();
            Console.WriteLine(HelloName(someonesName));
        }
        else if(funcSelect == "19")
        {
            Console.WriteLine("Yo, today you are going to tell us how many animals there are and we will tell you the number of legs.\nHow many chickens?");
            var chickens = Console.ReadLine();
            float chickenLegs;
            while (!float.TryParse(chickens, out chickenLegs))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                chickens = Console.ReadLine();
            }
            Console.WriteLine("Alright, now how many cows?");
            var cows = Console.ReadLine();
            float cowLegs;
            while (!float.TryParse(cows, out cowLegs))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                cows = Console.ReadLine();
            }
            Console.WriteLine("Alright, now give us the number of pigs");
            var pigs = Console.ReadLine();
            float pigLegs;
            while (!float.TryParse(pigs, out pigLegs))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                pigs = Console.ReadLine();
            }
            if (chickenLegs < 0)
            {

                Console.WriteLine("Please try again.");
                MainMenu();
                
            }
            else if (cowLegs < 0)
            {

                Console.WriteLine("Please try again.");
                MainMenu();
                
            }
            else if (pigLegs < 0)
            {

                Console.WriteLine("Please try again.");
                MainMenu();
                
            }
            Console.WriteLine("AnimalLegs(" + chickens + ", " + cows + ", " + pigs + ") -> " + AnimalLegs(chickenLegs, cowLegs, pigLegs));
        }
        else if(funcSelect == "20")
        {
            Console.WriteLine("Today we will get the number of wins, losses, and draws and calculate the number of points a football team has.\n How many wins?");
            var wins = Console.ReadLine();
            int winPoints;
            while (!int.TryParse(wins, out winPoints))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                wins = Console.ReadLine();
            }
            Console.WriteLine("Now how many draws?");
            var draws = Console.ReadLine();
            int drawsPoints;
            while (!int.TryParse(draws, out drawsPoints))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                draws = Console.ReadLine();
            }
            Console.WriteLine("Now how many losses?");
            var losses = Console.ReadLine();
            int lossesPoints;
            while (!int.TryParse(losses, out lossesPoints))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                losses = Console.ReadLine();
            }
            Console.WriteLine("FootballPoints(" + winPoints + ", " + drawsPoints + ", " + lossesPoints + ") -> " + FootBallPoints(winPoints, drawsPoints)); 
        }
        else if(funcSelect == "21")
        {
            Console.WriteLine("Today we are going to take a number that corresponds with a month.");
            var month = Console.ReadLine();
            int monthNum = int.Parse(month);
            while(monthNum > 12 || monthNum < 1)
            {
                Console.WriteLine("Please try again. There are only 12 months in a year.");
                monthNum = int.Parse(Console.ReadLine());
            }
            if (monthNum == 1)
            {
                Console.WriteLine("January");
            }
            else if (monthNum == 2)
            {
                Console.WriteLine("Febuary");
            }
            else if (monthNum == 3)
            {
                Console.WriteLine("March");
            }
            else if (monthNum == 4) 
            {
                Console.WriteLine("April");
            }
            else if(monthNum == 5)
            {
                Console.WriteLine("May");
            }
            else if(monthNum == 6)
            {
                Console.WriteLine("June");
            }
            else if (monthNum == 7)
            {
                Console.WriteLine("July");
            }
            else if( monthNum == 8)
            {
                Console.WriteLine("August");
            }
            else if(monthNum == 9)
            {
                Console.WriteLine("September");

            }
            else if (monthNum == 10)
            {
                Console.WriteLine("October");
            }
            else if(monthNum == 11)
            {
                Console.WriteLine("November");
            }
            else if(monthNum == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("There are only 12 months. Please try again.");

            }


        }
        else if(funcSelect == "22")
        {
            Console.WriteLine("Yo, give me an array of numbers and i'll give you the max and min of numbers. \nFirst give me how many numbers you want to input");
            int numberInput = int.Parse(Console.ReadLine());
            int[] numberArray = new int[numberInput];
            Console.WriteLine("Now enter all the numbers you want.");
            for (int i =0; i < numberInput; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the next number");
            }
            Console.WriteLine("The minimum and maximum for this array are [" + numberArray.Min() + ", " + numberArray.Max() + "]");
           

        }
        else if(funcSelect == "23")
        {
            Console.WriteLine("Today we will get an array of numbers and return the absolute value sum \nFirst give me how many numbers you want in the array");
            int arrayInput = int.Parse(Console.ReadLine());
            float[] absArray = new float[arrayInput];
            float absoluteSum = 0;
            Console.WriteLine("Now enter the numbers you want for the array.");
            for(int i = 0; i < arrayInput; i++)
            {
                absArray[i] = float.Parse(Console.ReadLine());
                
                
                Console.WriteLine("Enter the next number");
            }
            for (int i = 0;i < arrayInput; i++)
            {
                absoluteSum += MathF.Abs(absArray[i]);
            }
            Console.WriteLine("The sum of the absolute values of the numbers in the array is " + absoluteSum);

        }
        else if(funcSelect == "24")
        {
            Console.WriteLine("Today we will use exponents to make very big numbers.\nFirst give us the base number.");
            var baseNum = Console.ReadLine();
            float baseN;
            while (!float.TryParse(baseNum, out baseN))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                baseNum = Console.ReadLine();
            }
            Console.WriteLine("Ok, now give us the exponent for this equation.");
            var expoNum = Console.ReadLine();
            float expoN;
            while (!float.TryParse(expoNum, out expoN))
            {
                Console.WriteLine("PICK AN NUMBER YOU FOOL");

                expoNum = Console.ReadLine();
            }
            Console.WriteLine(baseN + " raised to the power of " + expoN + " is " + ExponentNumbers(baseN, expoN));

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
    public static string ReverseBool(string trueOrFalse)
    {
        
        string tryAgain;
        if (trueOrFalse == "true")
        {
            return "false" ;
        }
        else if (trueOrFalse == "false")
        {
            return "true" ;
        }
        else 
        {
            return "Pick true or false not whatever that is.";
        }
    }
    public static float HoursIntoSeconds(float secHours)
    {
        return secHours * 3600;
    }
    
    public static int NSidedPolygonAngles(int nPolygon)
    {
        return (nPolygon - 2) * 180;
    }

    public static bool And(bool aTrue, bool bTrue)
    {
        if(aTrue && bTrue)
        {
            return true ;
        }
        else
        {
            return false ;
        }
    }

    public static int Points(int threePointers, int twoPointers)
    {
        return (threePointers * 3) + (twoPointers * 2);
    }
    public static float RectPerimeter(float length, float width)
    {
        return (length * 2) + (width * 2);
    }

    public static string HelloName(string someonesName)
    {
        return "Hello " + someonesName + "!";
    }

    public static float AnimalLegs(float chickens, float cows, float pigs)
    {
        
            
            return (chickens * 2) + (cows * 4) + (pigs* 4);
    }
    public static int FootBallPoints(int wins, int draws)
    {
        if (wins < 0)
        {
            wins = 0;
        }
        if (draws < 0)
        {
            draws = 0;
        }
        return (wins * 3) + (draws);
    }

    public static float ExponentNumbers(float baseNum, float expoNum)
    {
        return MathF.Pow(baseNum, expoNum);
    }
    
    
}
