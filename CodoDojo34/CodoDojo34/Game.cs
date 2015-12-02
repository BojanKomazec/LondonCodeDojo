using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodoDojo34
{
    public class Game
    {
        private const int numberOfPiles = 7;
        public IList<IList<Card>> Piles { get; }
        public IList<IList<Card>> Foundations { get; set; }
        public IList<Card> Reminder { get; set; }

        public Game()
        {
            this.Piles = new List<IList<Card>>(numberOfPiles);
            for(int i = 0; i < numberOfPiles; i++)
            {
                var pile = Enumerable.Range(0, i + 1).Select(index => new Card(index == 0)).ToList();
                this.Piles.Add(pile);
            }
        
            this.Foundations = Enumerable.Repeat<IList<Card>>(new List<Card>(), 4).ToList();

            this.Reminder = Enumerable.Repeat<Card>(new Card(false), 52 - 28).ToList();
        }

    }
}
