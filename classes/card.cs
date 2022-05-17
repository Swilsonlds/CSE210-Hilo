using System;
using System.Collections.Generic;

namespace CSE210_Hilo.classes
{
    public class card
    {
        public int currentCard;
        public int nextCard;

        public void DrawCards()
        {
           Random random1 = new Random();
           Random random2 = new Random();

           currentCard = random1.Next(1,14);
           nextCard = random2.Next(1,14);
        }
    }

    
}