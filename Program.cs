using System;

public class TextAdventure
{
    public static void Main(string[] args)
    {
        Console.WriteLine("It's 3 a.m., you're in Kağıthane. You're surrounded by thieves and ballet dancers. You need to get home, but you have to go through dangerous streets.");
        Console.WriteLine("What's your name, Lion?");
        string playerName = Console.ReadLine();
        Console.WriteLine($"\nGood luck, {playerName}. I hope you make it home. ");

        Console.WriteLine("\nYou have two way in front of you. Which one do you choose?");
        Console.WriteLine("1. Dark and deserted street.");
        Console.WriteLine("2. Bright but deserted main street.");
        string choice1 = Console.ReadLine();

        if (choice1 == "1")
        {
            Console.WriteLine("\nIn the alley, a thief is looking for something in the rubbish. He spotted you! What are you doing?");
            Console.WriteLine("1. runn.");
            Console.WriteLine("2. get away from there.");
            string choice2 = Console.ReadLine();

            if (choice2 == "1")
            {
                Console.WriteLine("\nYou start to run, but the thief is chasing you. You turn into an alley. What do you do now?");
                Console.WriteLine(" you come across a ruined building.");
                Console.WriteLine("1. Try to go through the building.");
                Console.WriteLine("2. Go back, risking the thief catching you.");
                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {
                    Console.WriteLine("\nWhen you try to pass through the building, you trip over a stone and fall!");
                    Console.WriteLine("The thief catches you! He takes your wallet and your phone.");
                    Console.WriteLine($"{playerName}, Kagithane is dangerous at night. You're poor now, well done");
                }
                else
                {
                    Console.WriteLine("\nYou go back and confront the thief. You show the thief the knife in your pocket. ");
                    Console.WriteLine("The thief is surprised. He says, ‘Nothing. He apologises and runs away.");
                    Console.WriteLine("Confused but happy to be safe, you start to walk home.");
                    Console.WriteLine($"{playerName}, Welcome home, lion!");
                }
            }
            else
            {
                Console.WriteLine("\nThe thief finds a wallet and takes money out of it, but then");
                Console.WriteLine(". He notices you! He shouts, ‘What are you looking at? What are you doing?");
                Console.WriteLine("1. You apologize and quickly leave.");
                Console.WriteLine("2. You shout, I'm calling the police!");
                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {
                    Console.WriteLine("\nThe thief grumbles but doesn't touch you. You slowly back away.");
                    Console.WriteLine("and you come to a fork in the road. Which way do you go?");
                    Console.WriteLine("1. The road that goes uphill to the right.");
                    Console.WriteLine("2. The steep stairs that go down between the buildings on the left.");
                    string choice4 = Console.ReadLine();

                    if (choice4 == "1")
                    {
                        Console.WriteLine("\nYou trudge uphill and you can't believe your eyes... it's your house! You made it!");
                        Console.WriteLine($"{playerName}, That was a dangerous night, be thankful you're safe. Congratulations!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou see someone running towards you as you pass between the buildings!");
                        Console.WriteLine("You turn back in fear and come out onto the main road. You hail a taxi and head home.");
                        Console.WriteLine($"{playerName}, You arrive home with an empty wallet, but at least you're safe and sound!");
                    }

                }
                else
                {
                    Console.WriteLine("\nThe thief attacks you! You try to fight back, but you're no match for them.");
                    Console.WriteLine($"{playerName}, You got into trouble in Kağıthane, you idiot!  Don't be so careless again!");
                }
            }
        }
        else
        {
            Console.WriteLine("\nWhile you're walking down the main street, a group of baliciler starts harassing you. What do you do?");
            Console.WriteLine("1. You ignore them and keep walking.");
            Console.WriteLine("2. You answer them back.");
            string choice2 = Console.ReadLine();

            if (choice2 == "1")
            {
                Console.WriteLine("\nThe baliciler continue to mock you for a bit, but eventually get bored and move on to someone else.");
                Console.WriteLine("You breathe a sigh of relief and continue on your way. A little further on, you see a police car.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("1. You ask the police for help.");
                Console.WriteLine("2. You decide to keep going home on your own.");
                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {
                    Console.WriteLine("\nThe police give you a lift home. You arrive safe and sound... A bit cowardly though, haha!");
                    Console.WriteLine($"{playerName}, You got home safe thanks to the police.");
                }
                else
                {
                    Console.WriteLine("\nYou carry on and finally reach your home.");
                    Console.WriteLine($"{playerName}, You did it Lion Well done, you made it home safe and sound.");
                }

            }
            else
            {
                Console.WriteLine("\nThe baliciler get angry and look ready to attack! What do you do?");
                Console.WriteLine("1. You duck into a nearby shop.");
                Console.WriteLine("2. You try to run away.");
                string choice3 = Console.ReadLine();

                if (choice3 == "1")
                {
                    Console.WriteLine("\nYou quickly dive into a small grocery store. The troublemakers bang on the door, but they can't get in.");
                    Console.WriteLine("The shopkeeper helps you escape through the back door. The streets are like a maze! Which way do you go?");
                    Console.WriteLine("1.You turn right.");
                    Console.WriteLine("2. You turn left.");
                    string choice4 = Console.ReadLine();

                    if (choice4 == "1")
                    {
                        Console.WriteLine("\nYou turn right and find yourself back on the main street. You hail a taxi and head home.");
                        Console.WriteLine($"{playerName},It cost you all your money to get home, but at least you'll get there safely!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou turn left and find yourself in even more dangerous streets!");
                        Console.WriteLine("Baliciler they're backing you into a corner anddd");
                        Console.WriteLine($"{playerName}, You got beaten up in the streets of Kağıthane! Don't be so brave next time, you idiot.");
                    }
                }
                else
                {
                    Console.WriteLine("\nYou try to run, but the troublemakers catch you and beat you up..");
                    Console.WriteLine($"{playerName}, You got beaten up in the streets of Kağıthane!  Don't be so brave next time.");
                }
            }
        }

        Console.ReadKey();
    }
}