using SharedForGenration;

namespace Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var lastQuestion = questions.Last();
            Console.WriteLine(lastQuestion);
            // var someQuestion = questions.Last(q => q.Title.Length == 0);//invalidoperationException if no question with empty title
            var someQuestion2 = questions.LastOrDefault(q => q.Title.Length == 0);//null if no question with empty title
            if (someQuestion2 is null)
            {
                Console.WriteLine("Question not found");
            }
        }
    }
}
