using SharedForGenration;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var firstQuestion = questions.First();
            Console.WriteLine(firstQuestion);
           // var someQuestion = questions.First(q => q.Title.Length == 0);//invalidoperationException if no question with empty title
            var someQuestion2 = questions.FirstOrDefault(q => q.Title.Length == 0);//null if no question with empty title
            if(someQuestion2 is null)
            {
                Console.WriteLine("Question not found");
            }
        }
    }
}
