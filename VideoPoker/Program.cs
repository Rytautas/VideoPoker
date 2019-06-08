using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace VideoPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Regex regex = new Regex(@"^[1-5]\s?([1-5]\s*)*$");
            Console.WriteLine("Welcome to video poker!");
            while(true)
            {
                Console.WriteLine("Start new game? (y/n)");
                string response = Console.ReadLine();

                if (response == "y")
                {
                    Deck.newDeck();
                    List<Card> hand = Deck.dealHand(new List<Card>());
                    int i = 0;

                    Console.WriteLine("You have been dealt the following cards:");
                    foreach (Card card in hand)
                    {
                        Console.WriteLine(++i + ") " + card.value + " of " + card.suit);
                    }
                    Console.WriteLine("Do you want to change any cards? (y/n)");
                    Console.WriteLine("(This action can only be done once per game and cannot be undone)");

                    response = Console.ReadLine();
                    if(response == "y")
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the indices (separated by a space) of the cards you want to discard");
                            List<int> indexes;
                            response = Console.ReadLine();
                            try
                            {
                                if (regex.IsMatch(response))
                                {
                                    string[] values = response.Split(new char[0]);
                                    indexes = Array.ConvertAll(values, s => int.Parse(s)).ToList();
                                    hand = Deck.changeCards(hand, indexes);
                                    Console.WriteLine("You have the following cards:");
                                    i = 0;
                                    foreach (Card card in hand)
                                    {
                                        Console.WriteLine(++i + ") " + card.value + " of " + card.suit);
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, try again");
                                }
                            }
                            catch(FormatException e)
                            {
                                Console.WriteLine("Invalid input, try again");
                            }
                        }
                    }

                    Console.WriteLine(evaluator.evaluateHand(hand));
                }
                else
                    break;
            }
        }
    }
}
