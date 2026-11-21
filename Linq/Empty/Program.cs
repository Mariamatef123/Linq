using SharedForGenration;

namespace Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = new List<Question>();//empty list 
            //1
            //..
            //1000 est5dmt el ques b3d 
            foreach(var question in questions)
            {
                Console.WriteLine(question);
            }

            var questions2 = Enumerable.Empty<Question>();//deferred execution
            foreach (var question in questions2)
            {
                Console.WriteLine(question);
            }

        }
    }
}
