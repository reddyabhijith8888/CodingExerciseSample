using System;

namespace CodingExerciseSample
{
   public class Program
    {
        static void Main(string[] args)
        {
           var request = Console.ReadLine();
            var response = StringFormatter.GetExpectedResult(request);
            Console.WriteLine(response);
        }
    }
}
