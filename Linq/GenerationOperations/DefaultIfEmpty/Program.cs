using SharedForGenration;

namespace DefaultIfEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = Enumerable.Empty<Question>();
            //var questions2 = questions.DefaultIfEmpty();
            //questions2.ToQuiz();//with default is empty =null lw mn 8erha = fadya

            var questions3 = questions.DefaultIfEmpty(Question.Default);
            questions3.ToQuiz();

        }
    }
}
