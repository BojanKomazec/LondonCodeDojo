using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodoDojo34;

namespace CodeDojo3Tests
{   
    [TestFixture]
    public class Klondike_Tests
    {
        [Test]
        public void When_start_the_game_I_see_7_piles_of_cards()
        {
            // Arrange
            var game = new Game();

            // Act

            // Assert
            Assert.AreEqual(7, game.Piles.Count);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void When_start_the_game_Nth_pile_contains_N_cards(int n)
        {
            // Arrange
            var game = new Game();

            // Act

            // Assert
            Assert.AreEqual(n, game.Piles[n - 1].Count);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void When_start_the_game_first_card_in_Nth_pile_is_upturned(int n)
        {
            // Arrange
            var game = new Game();

            // Act

            // Assert
            Assert.IsTrue(game.Piles[n - 1][0].IsUpturned);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void When_start_the_game_all_cards_apart_from_the_first_card_in_Nth_pile_are_downturned(int n)
        {
            // Arrange
            var game = new Game();

            // Act

            // Assert
            var cards = game.Piles[n - 1];
            Assert.IsTrue(cards.Skip(1).All(card => !card.IsUpturned));
        }

        [Test]
        public void When_start_the_game_I_see_4_foundations()
        {
            // Arrange
            var game = new Game();

            // Act

            // Assert
            Assert.AreEqual(4, game.Foundations.Count);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void When_start_the_game_Nth_foundation_is_empty(int n)
        {
            // Arrange
            var game = new Game();

            // Act

            // Assert
            Assert.AreEqual(0, game.Foundations[n - 1].Count);
        }

        [Test]
        public void When_start_the_game_all_cards_in_the_reminder_are_downturned()
        {
            // Arrange
            var game = new Game();

            // Act

            // Assert
            Assert.IsTrue(game.Reminder.All(card => !card.IsUpturned));
        }

        [Test]
        public void When_start_the_game_remainder_contains_all_cards_which_are_not_in_piles()
        {
            // Arrange
            var game = new Game();
            int remainderCountExpected = 52 - 28;

            // Act

            // Assert
            Assert.AreEqual(remainderCountExpected, game.Reminder.Count);
        }
    }
}
