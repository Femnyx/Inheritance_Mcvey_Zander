using System;

namespace Inheritance_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
           //Saves myFPS as text for it to be Describe.
            FPS myFPS = new FPS("M", "Call of doody ");

           //Describes what is in myFPS.
            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            //saves csGo as text for it to be Describe and does so.
            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}
