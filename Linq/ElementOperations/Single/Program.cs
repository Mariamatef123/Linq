using SharedForGenration;

namespace Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var questions = QuestionBank.All;
            // var question = questions.Single(q => q.Title.Contains("#1"));//invalidoperationException if no question with #1 in title or more than one question with #1 in title
            // var question2 = questions.SingleOrDefault(q => q.Title.Contains("#1"));//null if no question with #1 in title, invalidoperationException if more than one question with #1 in title
            //var question3 = questions.Single(q => q.Title.Length == 0);
            //Console.WriteLine(question3);
            var question4 = questions.SingleOrDefault(q => q.Title.Length == 0);
            if(question4 is null)
            {
                Console.WriteLine("Question not found");
            }
        }
    }
}
