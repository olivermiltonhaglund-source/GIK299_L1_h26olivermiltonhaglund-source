namespace GIK299_L1_h26olivermiltonhaglund_source
{
    internal class WCT
    {
        static void Main(string[] args)
        {
            bool WCT = true;
            // While loop som körs tills användaren väljer att avsluta programmet
           
            while (WCT)
            {
                Console.WriteLine();
                Console.WriteLine("1. Beräkna Wind Chill");
                Console.WriteLine("2. Avsluta Programmet");
                Console .Write("Val: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    // Första valet som beräknar Wind Chill
                    case "1":


                        Console.Write("Vad är temperatur i celsius (Med siffror): ");
                        double temp = double.Parse(Console.ReadLine());

                        Console.Write("Vad är vindhastighet (Med siffror) : ");
                        double wind = double.Parse(Console.ReadLine());

                        Console.Write("Är hastigheten i km/h eller m/s?: ");
                        string measurement = Console.ReadLine();
                        
                        if (measurement == "m/s") ;
                        {
                            wind = wind * 3.6;
                        }
                        //Beräkningen till WCT
                        double wct = 
                            13.12
                            + 0.6215 * temp
                            - 11.37 * Math.Pow(wind, 0.16)
                            + 0.3965 * temp * Math.Pow(wind, 0.16);

                        Console.WriteLine("Wind Chill är " + wct.ToString("F1"));

                        //Kollar de olika tempraturerna och skriver ut olika meddelanden beroende på vad WCT är.



                        if (wct>60)
                        {
                            Console.WriteLine("STEK HETT");
                        }
                        
                        else if (wct>=0)
                        {
                            Console.WriteLine("Ingen Risk");
                        }

                        else if (wct>-25)
                        {
                            Console.WriteLine("Risk för lite kyla");
                        }
                        else if (wct>=-35)
                        {
                            Console.WriteLine("Risk för mycket kallt");
                        }
                        else if (wct>=-60)
                        {
                            Console.WriteLine("Risk för frostskada");
                        }
                        else if (wct<-60)
                        {
                            Console.WriteLine("Stor risk för frostskada");
                        }

                        break;

                    // ANdra valet som avslutar programmet
                    case "2":


                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Avslutar program");

                        WCT = false;
                        break;
                        //om man gör del
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen:)");
                        break;

                        // Debugging:
                        // Testade programmet med olika värden för temperatur och vindhastighet.
                        // Använde debuggern för att kontrollera att användarens inmatning sparades korrekt
                        // och att Wind Chill-värdet beräknades som förväntat.
                        // Min kod funkade inte ett tag sedan såg jag att jag hade missat ett semikolon i slutet på ekvationen för wind chill




















                }










            }                             

        }
    }
}
