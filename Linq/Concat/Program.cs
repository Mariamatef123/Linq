using SharedForGenration;

namespace Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }
        static void Test()
        {
            var quiz1 = QuestionBank.Randomize(1);
            var quiz2 = QuestionBank.Randomize(1);
            var quiz3 = quiz1.Concat(quiz2);
            quiz3.ToQuiz();

        }
        static void Test1()
        {
            var quiz1 = QuestionBank.Randomize(1);
            var quiz2 = QuestionBank.Randomize(1);
            var questionTitles = quiz1.Select(q => q.Title).Concat(quiz2.Select(q=>q.Title));
            foreach (var title in questionTitles)
            {
                Console.WriteLine(title);
            }
        }
        static void Test2()
        {
            var questionTitles =
               QuestionBank.Randomize(1).Select(q => q.Title)
                .Concat(QuestionBank.Randomize(1).Select(q => q.Title))
                .Concat(QuestionBank.GetQuestionRange(Enumerable.Range(1, 2))
                .Select(q => q.Title));
            foreach (var title in questionTitles)
            {
                Console.WriteLine(title);
            }

        }
        static void Test4()
        {
            var quiz1 = QuestionBank.Randomize(1);
            var quiz2 = QuestionBank.Randomize(1);
            var quiz3 = new  [] { quiz1,quiz2 }.SelectMany(x => x);
            quiz3.ToQuiz();

        }
    }
}
