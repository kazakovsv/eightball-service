using System;
using MagicEightBallServiceClient.MagicEightBallServiceReference;

namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ask the Magic 8 Ball *****\n");

            using (EightBallClient client = new EightBallClient())
            {
                Console.Write("Your question: ");
                string question = Console.ReadLine();
                string answer = client.ObtainAnswerToQuestion(question);
                Console.WriteLine($"Magic 8 Ball says: {answer}");
                Console.ReadLine();
            }
        }
    }
}
