// See https://aka.ms/new-console-template for more information

//// Reverser stringen!

//Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert.
//Gjør dette uten å bruke innebygde reverse metoder.
//Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
//Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase

class Program
{

    static void Main()

    {
        string text = "Dette er en TEKST vi skal reversere";
        string reversed = "";

        while (true)
        { 

        Console.WriteLine("Trykk på '1' for å reversere teksten");
        Console.WriteLine("Trykk på '2' for å gjøre alle bokstaver små");
        Console.WriteLine("Trykk på '3' for å gjøre alle bokstaver store");

        switch(Console.ReadLine())
        {
        case "1":
            for (int i = text.Length - 1; i >= 0; i--)
                reversed += text[i];
            Console.WriteLine("Tekst reversert: " + reversed);
            break;
        case "2":
            string makeItToLowText = text.ToLower();
            Console.WriteLine("Alle bokstaver gjort om til lowercase: " + makeItToLowText);
            break;
        case "3":
            string makeItToUpText = text.ToUpper();
            Console.WriteLine("Alle bokstaver gjort om til uppercase: " + makeItToUpText);
            break;
            }
            Console.WriteLine("Velg et nytt alternativ\r\n");
            Console.ReadLine();
           
        }  
    } 
}
