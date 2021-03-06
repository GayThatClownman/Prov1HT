using System;

namespace Prov1HT
{
    public class Book
    {
        //Uppsättning av alla olika variabler enligt klassdiagram.
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator;

        //Konstruktoren för klassen "Book", som slumpar variablerna som efterfrågades i uppgiften.
        public Book()
        {
            //Vid tester är det vissa problem med denna metod som jag själv inte kan tolka.
            actualValue = generator.Next(20, 150);
            rarity = generator.Next(10);

            int cursedChance = generator.Next(10);
            if (cursedChance <= 3)
            {
                cursed = true;
            }

            else
            {
                cursed = false;
            }



        }   

        //Skriver ut information om boken.
        public void PrintInfo()
        {
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Rarity: " + rarity);
            System.Console.WriteLine("Category: " + category);
            System.Console.WriteLine("Price: " + price);

        }

        //Beräknar värdet utifrån de olika kriterier uppgiften frågar efter. Gör ett slumpat procenttal som multipliceras med värdet.
        public int Evaluate()
        {
            int correctPrice;
            
            correctPrice = actualValue * rarity;

            int percentage = generator.Next(50, 150);

            percentage = percentage / 100;
            correctPrice = percentage * correctPrice;

            return correctPrice;
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsCursed()
        { 
            bool isCursed = false;

            return isCursed;

        }
    }
}
