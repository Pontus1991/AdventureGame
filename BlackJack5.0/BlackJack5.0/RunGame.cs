using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack5._0
{
    class RunGame
    {
        public List<Card> GameDeck { get; set; }
     
        public static List<Card> cardDeck = new List<Card>();
        Card card = new Card(2);

        public void Game()
        {
           
        }

        public void CreateCardDeck()
        {
            for (int i = 0; i < 4; i++) // Skapa 4 kort.
            {
                for (int j = 2; j <= 14; j++)
                {
                    if (j <= 10) // Skapar oklädda kort upp till 10 i if-satsen.
                    {
                        Card card = new Card(j, j.ToString()); // Skapa objektet.  j, krävs från konstruktorn.
                        cardDeck.Add(card); // Om j är mindre eller lika med 10 komemr den skapa oklädda kort 
                    }
                    else if (j == 11) // Är j 11 kommer en knekt skapas. (Type) är klädda kort 
                    {
                        Card card = new Card(10, "Knekt");
                        cardDeck.Add(card);
                    }
                    else if (j == 12)
                    {
                        Card card = new Card(10, "Dam"); // Hårdkodar värdet 10
                        cardDeck.Add(card);
                    }
                    else if (j == 13)
                    {
                        Card card = new Card(10, "Kung");
                        cardDeck.Add(card);
                    }
                    else
                    {
                        Card card = new Card(11, "Äss");
                        cardDeck.Add(card);
                    }
                }
            }
            //foreach (var item in cardDeck)
            //{
            //    Console.WriteLine(item.Value);
            //    Console.WriteLine(item.Type);
            //}
        }
        
        public void Meny()
        {

        }
        public void Shuffler()
        {

        }

        public void GameLogic()
        {

        }

        



    }
}
