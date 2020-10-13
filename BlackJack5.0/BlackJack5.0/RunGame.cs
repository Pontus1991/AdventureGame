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

        public static Random r = new Random();
        public static List<Card> cardDeck = new List<Card>();
        public static List<Card> summering = new List<Card>();


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
                Int32.TryParse(Console.ReadLine(), out meny);

                switch (meny)
                {

                    case 1:
                        DrawCard();//!!!!Skall logiken knytas här eller någon annanstans angående spelarens hand om den är "tjock" eller ej.
                        break;
                    case 2:
                        GameResult(meny);//!!!!Denna metod, skall räkna ut resultaten.
                        break;
                    case 3:
                        EndGame(); //!!!! I anropet, fixa lite stats, finns mer detaljer i metoden.
                        break;
                    default:
                        if (meny > 3)
                        {
                            Console.WriteLine("Vänligen ange ett korrekt meny val");
                        }
                        break;
                }
               
            } while (meny != 0);
            
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
                        Card card = new Card(11, "Ess");
                        cardDeck.Add(card);
                    }
                }
            }
        }
        
        public void GameResult(int menySvar)//Visar spelets "resultat" och kör igång "husets" spel.
        {
            
            int result = summering.Sum(x => x.Value);

            if (result > 21)
            {
                Console.WriteLine("Du fick " + result + "poäng. Du förlorade.");
                // Behöver inte calculatebank här eftersom man redan har förlorat. 
                summering.Clear();
                Console.ReadLine();
                Console.Clear(); //!! Denna kanske måste förflyttas ifall inte spelet visas upp korrekt.
            }
            else if (menySvar == 2)
            {
                Console.WriteLine("Du fick " + result + "poäng. du vann????.");
                CalculateBank();
                summering.Clear();
                Console.ReadLine();
                Console.Clear(); //!! Denna kanske måste förflyttas ifall inte spelet visas upp korrekt.

            }
        }
        public void CalculateBank()
        {
            int result = summering.Sum(x => x.Value);

            while (result < 17) // Banken drar alltid ett kort när den är mindre än 17. Sedan stannaer den.
            {
                DrawCard();
                if (result > 21)
                {
                    Console.WriteLine("You won!");
                    summering.Clear();
                    Console.ReadLine();
                    Console.Clear(); //!! Denna kanske måste förflyttas ifall inte spelet visas upp korrekt.
                    Meny();
                }
                else if (result == 21)
                {
                    Console.WriteLine("You Lost!");
                    summering.Clear();
                    Console.ReadLine();
                    Console.Clear(); //!! Denna kanske måste förflyttas ifall inte spelet visas upp korrekt.
                    Meny();
                }

            }
        }
        public void Shuffler()
        {           
            for (int i = 0; i < cardDeck.Count - 1; i++)
            {
                int k = r.Next(i + 1);
                int temp = cardDeck[i].Value;
                cardDeck[i].Value = cardDeck[k].Value;
                cardDeck[k].Value = temp;
            }
        }
        public void DrawCard()
        {
            if (cardDeck.Count() <= 0)
            {
                CreateCardDeck();
                Shuffler();
            }

            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine($"Du fick {cardDeck[i].Value}");
                if (cardDeck[i].Value == 11)
                {
                    try
                    {
                        Console.WriteLine("Tryck 1 för att omvandla esset till en etta! Annars tryck enter! ");
                        string answer = Console.ReadLine();
                        if (answer == "1")
                        {
                            cardDeck[i].Value = 1;
                            Console.WriteLine("Hej hej det funkar");
                        }
                        else 
                        {
                            cardDeck[i].Value = 11;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                }
                summering.Add(cardDeck[i]);
                Console.WriteLine("Handen: " + summering.Sum(x => x.Value));
                cardDeck.Remove(cardDeck[i]);
            }

            int Tjock = summering.Sum(x => x.Value);

            if (Tjock > 21)
            {
                Console.WriteLine("You lost! ");
                summering.Clear();
                Console.ReadLine();
                Console.Clear(); //!! Denna kanske måste förflyttas ifall inte spelet visas upp korrekt.
                Meny();
            }
            
        }
        public void GameLogic()//Kör igång spelet efter att RunGame har skapats i Main.
        {
            CreateCardDeck();//Vi skapar en kortlek.
            Shuffler(); //Vi blandar den.
            Meny();//Anropar vår meny, som i sin tur har ett val som avslutar spelar, inte optimalt.
            //foreach (var item in cardDeck)
            //{
            //    Console.WriteLine(item.Value);
            //}
        }
        public void EndGame()
        {
            //!!!!Lägga in antal vunna rundor, hur många kort man har dragit samt den senaste handen. Och vilka värden man har haft.
            Environment.Exit(0);
        }
        



    }
}
