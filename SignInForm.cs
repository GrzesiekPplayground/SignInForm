using System;

namespace SignInForm
{
    class SignInForm
    {
        static void Main(string[] args)
        {
            Person AdamK = new Person("Adam", "Kowalski");
            AdamK.email = "adam@kowalski.pl";
            Console.WriteLine(AdamK.email);
            AdamK.UpdateContact("AdamKowalski@pgnig.pl");
            Console.WriteLine(AdamK.email);

            Console.WriteLine(AdamK.fullName);


            Console.ReadKey();

        }
    }
}
