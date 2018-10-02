using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; } //property
        public Deck Deck { get; set; } //property
        public int Balance { get; set; } //property

        public void Deal(List<Card> Hand) //method
        {
            Hand.Add(Deck.Cards.First()); //Taking the top (first) card in the deck and putting in dealers hand.
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
           using (StreamWriter file = new StreamWriter(@"C:\User\Student\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
