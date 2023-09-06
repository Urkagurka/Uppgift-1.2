using System;                                                               //ett paket med saker som man använder

namespace Uppgift_1._2                                                      //Namn på samlingen av kod
{
    class Program                                                           //class Program är en samling av saker som du ska anvädna
    {
        static void Main(string[] args)                                     //Det associseras med klassen av något
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;                //gör bakgrunden blå
            Console.ForegroundColor = ConsoleColor.White;                   //gör texten Vit
            Console.WriteLine("Your computer is currently on fire");        //får datorn att skriva texten
            Console.ReadKey();                                              //Tar bort all onödig text
        }


    }



}