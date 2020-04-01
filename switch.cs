using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 create generator engine for random numbers (only once)
            // Random [name-i-give-to-engine] = new Random();
            Random rnd_generator = new Random(); // chinese

            // 2 to generate a number use Next
            // [name-i-give-to-engine].Next(maxValue);
            // [name-i-give-to-engine].Next(minValue, maxValue);
            int random_number1 = rnd_generator.Next(1, 100);

            int player_score = 0;
            int computer_score = 0;

            while (true)
            {
                // I pull random card + print card
                int card_user = rnd_generator.Next(2, 15);

                // option 1
                if (card_user < 11)
                {
                    Console.WriteLine($"Player card : {card_user}");
                }
                else if (card_user == 11)
                {
                    Console.WriteLine("Player card :{J");
                }
                else if (card_user == 12)
                {
                    Console.WriteLine("Player card : Q");
                }
                else if (card_user == 13)
                {
                    Console.WriteLine("Player card : K");
                }
                else if (card_user == 14)
                {
                    Console.WriteLine("Player card : A");
                }

                // option 2
                switch (card_user)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine($"Player card : {card_user}");
                        break;
                    case 11:
                        Console.WriteLine("Player card :J");
                        break;
                    case 12:
                        Console.WriteLine("Player card :Q");
                        break;
                    case 13:
                        Console.WriteLine("Player card :K");
                        break;
                    default: // else
                        Console.WriteLine("Player card :K");
                        break;
                }

                // option 3
                if (card_user < 11)
                {
                    Console.WriteLine($"Player card : {card_user}");
                }
                else
                {
                    switch (card_user)
                    {
                        case 11:
                            Console.WriteLine("Player card :J");
                            break;
                        case 12:
                            Console.WriteLine("Player card :Q");
                            break;
                        case 13:
                            Console.WriteLine("Player card :K");
                            break;
                        default: // else
                            Console.WriteLine("Player card :K");
                            break;
                    }
                }

                // computer pull random card + print card
                int computer_card = rnd_generator.Next(2, 15);
                if (computer_card < 11)
                {
                    Console.WriteLine($"Computer card : {computer_card}");
                }
                else if (computer_card == 11)
                {
                    Console.WriteLine("Computer card :J");
                }
                else if (computer_card == 12)
                {
                    Console.WriteLine("Computer card : Q");
                }
                else if (computer_card == 13)
                {
                    Console.WriteLine("Computer card : K");
                }
                else if (computer_card == 14)
                {
                    Console.WriteLine("Computer card : A");
                }

                // print who won this round
                if (card_user == computer_card)
                {
                    Console.WriteLine("Draw ....");
                }
                else if (card_user > computer_card)
                {
                    player_score++;
                    Console.WriteLine("Player won!");
                }
                else
                {
                    computer_score++;
                    Console.WriteLine("Computer won!");
                }

                // print score!
                Console.WriteLine($"Player score {player_score}");
                Console.WriteLine($"Computer score {computer_score}");
                Console.WriteLine("*********************************");
                Console.WriteLine();

                if (Math.Abs(player_score - computer_score) >= 3)
                    break;

                // wait for readline
                Console.ReadLine();

            }
            // 2 3 4 5 6 7 8 9 10 J Q K A

            if (player_score > computer_score)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Computer won!");
            }

            // wait for readline
            Console.ReadLine();

        }
    }
}
