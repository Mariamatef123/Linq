using SharedForGenration;

namespace StandardMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAverage();
        }

        private static void RunCount()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 10));
            Console.WriteLine(quiz.Count());
            Console.WriteLine(quiz.Count(x => x.CorrectAnswer != null));
            Console.WriteLine(quiz.Where(x=>x.CorrectAnswer != null).Count());
            Console.WriteLine(quiz.Where(x => x.CorrectAnswer != null).LongCount());
        }
        private static void RunMax()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 10));
            Console.WriteLine(quiz.Max(x => x.Title.Length));
        }
        private static void RunMaxBy()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 10));
            foreach (var item in quiz)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine(quiz.MaxBy(x => x.Title.Length));
        }
        private static void RunMin()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 10));
            Console.WriteLine(quiz.Min(x => x.Title.Length));
        }
        private static void RunMinBy()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 10));
            foreach (var item in quiz)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine(quiz.MinBy(x => x.Title.Length));
        }
        private static void RunSum()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 10));
            Console.WriteLine(quiz.Sum(x => x.Title.Length));
        }
        private static void RunAverage()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 10));
            Console.WriteLine(quiz.Average(x => x.Title.Length));
        }
    }
}
