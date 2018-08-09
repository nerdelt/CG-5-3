using System;

namespace DiceRollGame
{
    class Program
    {
        private static Random diceRoll = new Random();

        static void Main(string[] args)
        {

            //Informs user about game. 
            Console.WriteLine("Let's play a dice rolling game with two 6-sided dice.");
            Console.WriteLine("You roll first, then the computer will roll.");
            Console.WriteLine("The first one to get to 20 points wins.");
            Console.WriteLine("Now let's begin!\n");

            //counters for the computer and user scores 
            int sum2 = 0;
            int sum4 = 0;


            //A loop that allows the user to iniate both their roll and computer's roll by 
            //typing in roll. 
            do
            {
                Console.Write("Please type 'roll': ");
                string roll = Console.ReadLine();

                //this is the user's roll
                int score1 = RollDice();
                int score2 = RollDice();

                //the user's score for the current roll
                int sum = score1 + score2;

                //the user's score counter 
                sum2 += score1 + score2;

                //prints the user's current dice roll sum, and their current score
                Console.WriteLine($"\n{score1} + {score2} = {sum}");
                Console.WriteLine($"Your dice roll sum is : {sum}");
                Console.WriteLine($"Your current score is : {sum2}\n");

                //stops games if user's score goes above 20
                if (sum2 >= 20)
                {
                    Console.WriteLine("You Win!");
                    break;
                }
                
                //this is the computer's roll
                int score3 = RollDice();
                int score4 = RollDice();

                //the computer's score for current roll
                int sum3 = score3 + score4;

                //the computer's score counter
                sum4 += score3 + score4;
                  
                //prints computer's current dice roll sum as well as current score
                Console.WriteLine($"{score4} + {score3} = {sum3}");
                Console.WriteLine($"The computer's dice roll sum is : {sum3}");
                Console.WriteLine($"The computer's current score is : {sum4}" + Environment.NewLine);

                //stops the game if computer's score is over 20 and 
                //let's user know they lost
                if (sum4 >= 20)
                {
                    Console.WriteLine("The computer wins. You loose.");
                    break;
                }
            //this keeps the do looping going while either score is under 20
            } while (sum2 < 20 || sum4 < 20);
           
              Console.ReadLine();
            
        }
        /// <summary>
        /// This method rolls one 6 sided die, i.e. picks a random number from 1-6 based on 
        /// random created outside of main method.
        /// </summary>
        /// <returns> the result of the random roll</returns>
        private static int RollDice()
        {

            int roll = diceRoll.Next(1, 7);   
            return roll;
        }

        }
    }

