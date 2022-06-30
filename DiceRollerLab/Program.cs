//DICE ROLLING SIMULATOR

//Ask the user how many sides they want on the pair of dice
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("------------WELCOME TO THE DICE SIMULATOR--------------");
Console.WriteLine("Please choose the amount of sides you'd like the pair of dice...");
int value;

Console.WriteLine(diceResultSixSides(6,6));
Console.WriteLine(diceTotalSixSides(6,6));
Console.WriteLine(diceResultSixSides(2, 1));
Console.WriteLine(diceTotalSixSides(2, 1));
while (true)
{

    try
    {
        Console.WriteLine("How many sides should the dice have?");
        value = int.Parse(Console.ReadLine());
        if (value <= 0 || value > 20)
        {
            //out of range
            throw new Exception("Number of sides is not within range.");
        }
        else
        {
            //in range and a number
            break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Data must be a number");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

while (true)
{

    Console.WriteLine("Would you like to roll? (y/n)");
    if (Console.ReadLine().ToLower().Trim() == "y")
    {

        if (value == 6)
        {
            int roll1 = rollDice(value);
            int roll2 = rollDice(value);

            Console.WriteLine(diceResultSixSides(roll1,roll2));
            Console.WriteLine(diceTotalSixSides(roll1,roll2));
            
        }
        else
        {
            Console.WriteLine(diceResult(rollDice(value), rollDice(value)));
        }

    }
    else
    {
        break;
    }

    //Console.WriteLine("Would you like to roll again? (y/n)");
    //if (Console.ReadLine().ToLower().Trim() == "y")
    //{
    //    continue;
    //}
    //else
    //{
    //    break;
    //}
}




//method to create dice roll based on number of sides
static int rollDice(int sides)
{
    Random rnd = new Random();
    return rnd.Next(1, sides);
}

static string diceTotalSixSides(int roll, int roll2)
{
    if (roll + roll2 == 7 || roll + roll2 == 11)
    {
        return $"Win! You rolled a {roll} and a {roll2}.";
    }
    else if ((roll + roll2 == 2) || (roll + roll2 == 3) || (roll + roll2 == 12))
    {
        return "Craps!";
    }
    else
    {
        return "";
    } 
}


//gives the console results for a 
static string diceResultSixSides(int roll, int roll2)
{
    if (roll == 1 && roll2 == 1)
    {
        return $"Snake eyes! You rolled a {roll} and a {roll2}.";
    }
    else if ((roll == 1 && roll2 == 2) || (roll == 2 && roll2 == 1))
    {
        return $"Ace Deuce! You rolled a {roll} and a {roll2}.";

    }
    else if (roll == 6 && roll2 == 6)
    {
        return $"Box cars! You rolled a {roll} and a {roll2}.";
    }
    //else if (roll + roll2 == 7 || roll + roll2 == 11)
    //{
    //    return $"Win! You rolled a {roll} and a {roll2}.";
    //}
    //else if ((roll + roll2 == 2) || (roll + roll2 == 3) || (roll + roll2 == 12))
    //{
    //    return "Craps!";
    //}
    else
    {
        return $"You rolled a {roll} and a {roll2}.";
    }

}

static string diceResult(int roll, int roll2)
{
    return $"You rolled a {roll} and a {roll2}.";
}