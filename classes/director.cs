using System;

namespace CSE210_Hilo.classes
{
    public class director
    {
        bool isPlaying;
        int score;
        string guess;
        card card = new card();

        public director()
        {
            isPlaying = true;
            score = 300;
            guess = "y";
            card.currentCard = 1;
            card.nextCard = 1;
        }

        public void StartGame()
        {
            while (isPlaying && score > 0)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

            }

            if (!isPlaying)
            {
                Console.Write($"Your final score is {score}, thanks for playing!");

            }
            
            else if (score < 0)
            {
                Console.Write("Your score has fallen bel0w 0. Better luck next time!");
            }
        }

        public void GetInputs()
        {
            Console.Write("Draw card [y/n]: ");
            string drawCard = Console.ReadLine();
            isPlaying = (drawCard == "y");
            card.currentCard = 0;
            card.nextCard = 0;
        }

        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }

            card.DrawCards();
            Console.Write($"You drew a {card.currentCard}, will the next card be higher or lower [h/l]? ");
            guess = Console.ReadLine();

            
        }

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            Console.WriteLine($"Your next card is a {card.nextCard}");

            if (guess == "l")
            {
                if (card.currentCard > card.nextCard)
                {
                    score += 100;
                }

                else if (card.currentCard < card.nextCard)
                {
                    score -= 75;
                }
            }

            if (guess == "h")
            {
                if (card.currentCard < card.nextCard)
                {
                    score += 100;
                }

                else if (card.currentCard > card.nextCard)
                {
                    score -= 75;
                }

            }

            Console.WriteLine($"Your new score is {score}\n");
        }
        


        
    }
}