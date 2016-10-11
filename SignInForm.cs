
using System;

namespace SignInForm
{
    class SignInForm
    {
        public static void Main(string[] args)
        {
            // Using my class
            Person AdamK = new Person("Adam Kowalski");
            AdamK.email = "adam@kowalski.pl";
            //Console.WriteLine(AdamK.email);
            AdamK.UpdateContact("AdamKowalski@pgnig.pl");
            //Console.WriteLine(AdamK.email);

            // Using references
            Person AdamK2 = null;
            AdamK2 = AdamK;
            AdamK2.name = "Wojciech";

            //play with static private public
            Person JanNowak = new Person("Jan"); // this person will get AGH university as it's default
            JanNowak.city = "UW"; //university is not STATIC so it is called for INSTANCE JanNowak of tthe CLASS Person

            Person.defaultCity = "Wawszawa"; //change default university to UAM defaultUniversity is STATIC so can be called for Preson (class)
            Person MarianKowalski = new Person("Marian"); //this person will get UAM as it's default

            //inheritance
            Team Amarena = new Team("Amarena");
            Amarena.capitan = "Adam Małysz";
            Amarena.UpdateContact("kontakt@amarena.com", "501010010");


            Console.ReadKey();

        }

        private static int counter = 0;
        static void WhatTime()
        {
            counter += 1;
            Console.WriteLine("It is {0}. You asked {1} times(s)",
                DateTime.Now.ToLongTimeString(), counter);
        }
    }
}
