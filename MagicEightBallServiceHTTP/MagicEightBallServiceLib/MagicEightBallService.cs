using System;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        private static readonly Random random = new Random();
        private static readonly string[] answers =
        {
            "Future Uncertain",
            "Yes",
            "No",
            "Hazy",
            "Ask again later",
            "Definitely"
        };


        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question...");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            return answers[random.Next(answers.Length)];
        }
    }
}
