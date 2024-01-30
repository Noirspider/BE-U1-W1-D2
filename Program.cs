using ClassPersona;
using System;

namespace BE_U1_W1_D2
{
    internal class Program
    {


        static void Main(string[] args)
        {


            char letteraCasuale = (char)('A' + new Random().Next(26));
            int numeroCasuale = new Random().Next(100);
            string benvenuto = "Benvenuto Soggetto " + letteraCasuale + numeroCasuale;
            Console.WriteLine(benvenuto);
            Console.WriteLine("Qual'è il tuo nome? ");

            string nomePersona = Console.ReadLine();

            Console.WriteLine(nomePersona + " Qual'è il tuo cognome?  ");

            string cognomePersona = Console.ReadLine();

            Console.WriteLine("ciao " + nomePersona + " " + cognomePersona + " Qual'è la tua età?  ");

            int etaPersona = Convert.ToInt32(Console.ReadLine());

            Persona soggetto1 = new Persona(nomePersona, cognomePersona, etaPersona);

            Console.WriteLine("Scheda soggetto" + letteraCasuale + numeroCasuale);
            Console.WriteLine(soggetto1.getDettagli());



            Console.ReadKey();
        }
    }
}
