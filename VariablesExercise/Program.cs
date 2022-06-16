using System;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string petName = "Charlie";
            int petAge = 1;
            decimal petweight = 65.55m;
            bool isHealthy = true;
            char firstInitial = 'C';
            double petHeight = 26;

            Console.WriteLine($"My dog's name is {petName}. He is a {petAge} " +
                $"year old Golden Retriever that weighs {petweight} LBS. " +
                $"He is {petHeight} inches tall and it is {isHealthy} that he is healthy. " +
                $"His first initial is {firstInitial}.");

        }
    }
}
