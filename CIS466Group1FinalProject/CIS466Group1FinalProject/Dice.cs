using System;
using System.Collections.Generic;
using System.Text;

namespace CIS466Group1FinalProject
{
    public class Dice
    {
        public int Sides { get; set; }
        Random random = new Random();
        public int Roll()
        {
            // using Random.Next           
            return random.Next(Sides);
        }
    }
}
