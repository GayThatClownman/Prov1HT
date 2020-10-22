using System.Collections.Generic;
using System;

namespace Prov1HT
{
    public class Customer
    {
        //En customers pengar som bestämmer om den har råd med boken. Satt som public då Main kan behöva ha tillgång till den.
        public int money;

        //Customers har namn, men det är en private variabel då man inte kommer kunna påverka det i Main.
        private string name;
        
        //En customers interest för att se om de vill ha boken. Private då Main inte behöver tillgång.
        private int interest;

        //Variabel som kollar vilken kategori som en Customer föredrar, används i metoder. Main behöver ej tillgång.
        private string preferredCategory;
        
        //Generator som används till olika metoder. Private då Main inte behöver använda den.
        private Random generator;

        //Konstruktor för en Customer, som kan slumpa namn, pengar osv.
        public Customer()
        {

        }

        //Metod som beräknar en kunds intresse utifrån deras originella intresse och kategori på bok.
        public int CalculateInterest()
        {
            return interest;
        }

    }
}
