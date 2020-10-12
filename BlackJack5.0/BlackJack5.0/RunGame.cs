using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack5._0
{
    class RunGame
    {
        public List<Card> GameDeck { get; set; }
     
        public static List<Card> cardDeck = new List<Card>();
        

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
            //}
        }
        
        public void Meny()
        {
            int meny = 0;
            //Meny för switchen
            do
            {
                Console.WriteLine("Meny för Black Jack");
                Console.WriteLine("Meny val 1: \nDra ett kort. ");
                Console.WriteLine("Meny val 2: \nSpelresultat. ");
                Console.WriteLine("Meny val 3: \nAvsluta spel. ");
                Int32.TryParse(Console.ReadLine(),out meny);
                
                switch (meny)
                {
                    case 1: DrawCard();
                        break;
                    case 2: GameLogic();
                        break;
                    case 3: EndGame();
                        break;
                    default:
                        if (meny > 3)
                        {
                            Console.WriteLine("Vänligen ange ett korrekt meny val");
                        }
                        
                        break;
                }
                Console.WriteLine(RunGame.cardDeck.Count);
                //Console.Clear(); // Denna kanske måste förflyttas ifall inte spelet visas upp korrekt.
            } while (meny != 0);
           
        }

        public void GameResult()
        {

        }
        public void Shuffler()
        {

        }
        public void DrawCard()
        {
            for (int i = 0; i <=1; i++)
            {
                Console.WriteLine($"Du drog {cardDeck[i].Value}");
                cardDeck.Remove(cardDeck[i]);
            }
            

        }
        public void GameLogic()
        {

        }
        public void EndGame()
        {
            Environment.Exit(0);
        }
        



    }
}
