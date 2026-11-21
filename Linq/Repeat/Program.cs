using SharedForGenration;

namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q = QuestionBank.PickOne();
            var questions = Enumerable.Repeat(q, 10);// kolhom nfs el so2al msh el so2al 3shr marat,3shan homa reference type
            questions.ToQuiz();
        }
    }
}
