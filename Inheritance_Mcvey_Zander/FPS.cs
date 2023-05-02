using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Mcvey_Zander
{
    class FPS : Game
    {
        //Makes the name Esrb and Title into strings and links the names to the strings.
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }
        
        //Returns the info into text that is displayed below.
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
