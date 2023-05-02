using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Mcvey_Zander
{
    abstract class Game
    {
        //sets a "get" and "set" for Esrb and Title.
        public string Esrb { get; set; }

        public string Title { get; set; }

        //Makes the name Esrb and Title into strings and links the names to the strings.
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Prints the title and says it is starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        public abstract string Describe();
    }
}
