using ClassPersona;
using ClassRisposte;
using System;

namespace BE_U1_W1_D2
{
    internal class Program
    {


        static void Main(string[] args)
        {

            bool iniziaGioco = false;
            char letteraCasuale = (char)('A' + new Random().Next(26));
            int numeroCasuale = new Random().Next(100);
            string benvenuto = "Benvenuto Soggetto " + letteraCasuale + numeroCasuale;
            Console.WriteLine(benvenuto);
            Console.WriteLine("\nQual'è il tuo nome? ");
            string nomePersona = Console.ReadLine();
            Console.WriteLine("\nQual'è il tuo cognome?  ");
            string cognomePersona = Console.ReadLine();

            int etaPersona;

            while (true)
            {
                Console.WriteLine("\nQual'è la tua età? ");

                if (int.TryParse(Console.ReadLine(), out etaPersona))
                {
                    // L'input è un numero valido, esci dal ciclo
                    break;
                }
                else
                {
                    Console.WriteLine("\nL'età inserita non è valida. Inserisci un numero valido.");
                }
            }

            if (etaPersona < 18)
            {
                Console.WriteLine("non possiamo giocare con te. Sei un frutto troppo acerbo. Lontano dagli orrori volgi il tuo sguardo.");
            }
            else
            {

                Persona soggetto1 = new Persona(nomePersona, cognomePersona, etaPersona);

                Console.WriteLine("\n Scheda soggetto " + letteraCasuale + numeroCasuale + "\n");
                Console.WriteLine(soggetto1.getDettagli());

                Console.WriteLine("\nVuoi giocare a un gioco? (y/n)");
                string risp = Console.ReadLine();

                if (risp.ToLower() == "y")
                {
                    iniziaGioco = true;
                }
                else
                {
                    Console.WriteLine("\nMi dispiace, ma non puoi scappare.");
                }
            }

            if (iniziaGioco == true)
            {


                Console.WriteLine("\nOttimo! Iniziamo");
                Console.WriteLine("\nRispondi alle seguenti domande:");


                Console.WriteLine("\n Domanda 1 \n Nell'abisso di R'lyeh, ho incontrato una medusa di smeraldo che tesse gli incubi degli dei morti.\n Puoi udire il canto delle sue spine luminose mentre danza con le larve del caos?");
                string rispostaDomanda1 = Console.ReadLine();

                Console.WriteLine("\n Domanda 2 \n Nel maelstrom delle onde cosmiche, le stelle cantano il lamento dei trilobiti dimenticati.\n Qual è il colore del suono delle loro voci?");
                string rispostaDomanda2 = Console.ReadLine();

                Console.WriteLine("\n Domanda 3 \n Nel regno degli specchi incrinati, ho incontrato una farfalla di vetro che beveva il vino dell'incertezza.\n Quale è il riflesso della nostra mente nell'occhio di un unicorno invisibile che danza con le stelle frantumate?");
                string rispostaDomanda3 = Console.ReadLine();

                Risposte rispSogg = new Risposte(rispostaDomanda1, rispostaDomanda2, rispostaDomanda3);

                Console.WriteLine("\n Molto interessante. queste sono le tue risposte:");
                Console.WriteLine(rispSogg.getRisposte());
                Console.WriteLine("\n corretto? (y/n)");
                string risp2 = Console.ReadLine();


                Console.WriteLine("\n Perfetto. Rinchiudetelo di nuovo");
            }

            Console.WriteLine("\n THE END");
            Console.ReadKey();
        }
    }
}
