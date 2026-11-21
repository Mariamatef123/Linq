using SharedForGenration;

namespace Aggregate
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            RunMethod2();
        }

        private static void RunMethod1()
        {
            var names = new[]{ "Mariam", "Malak", "Nada", "Clara", "Ellen" };
            var commaSeparatedNames = names.Aggregate((a, b) => a + ", " + b);//a is the first element, b is the second element, then a is the result of the previous operation and b is the next element
            Console.WriteLine(commaSeparatedNames);
        }
        private static void RunMethod2()
        {
            var quiz = QuestionBank.All;
            var longestQuestionTitle2 = quiz.Aggregate((q1, q2) => q1.Title.Length > q2.Title.Length ? q1 : q2);
            Console.WriteLine(longestQuestionTitle2.Title);
        }
    }
}
