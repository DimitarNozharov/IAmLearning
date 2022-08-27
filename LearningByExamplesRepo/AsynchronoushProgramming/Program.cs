
using System;
using System.Threading.Tasks;

namespace AsynchronoushProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 200000;
            char charToContatenate = 'c';

            //Task t = Task.Factory.StartNew(() => ConcatenateChars(charToContatenate, count));
            //Task<string> t = Task.Factory.StartNew(() => ConcatenateChars(charToContatenate, count));

            Task<string> t = ConcatenateCharsAsync(charToContatenate, count);

            Console.WriteLine("In progress");

            //the main thread waits for the t Task to finish from the background thread and then continue with the next lines
            //without t.Wait() if we call async method with await inside, so the main thread will wait for the result from t.Result and then continue
            
            //t.Wait();
   

            //Console.WriteLine("Completed");
            Console.WriteLine($"The length of the result is {t.Result.Length}.");
            Console.Read();
        }

        public static string ConcatenateChars(char charToConcatenate, int count)
        {
            string concatenatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                concatenatedString += charToConcatenate;
            }

            return concatenatedString; 
        }

        public static async Task<string> ConcatenateCharsAsync(char charToConcatenate, int count)
        {
            Task<string> task = Task<string>.Factory.StartNew(() =>
            {
                return ConcatenateChars(charToConcatenate, count);
            });

            string result = await task;
            Console.WriteLine("Completed");

            return result;
            //return await task;
        }
    }
}
