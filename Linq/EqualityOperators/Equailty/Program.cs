using SharedForGenration;

namespace Equailty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test2();
        }
        static void Test()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();
            var quiz1 = new List<Question>(new[] { q1, q2, q3 });//shared
            var quiz2 = new List<Question>(new[] { q1, q2, q3 });
            var equal = quiz1.SequenceEqual(quiz2);//true if no of elements same and each element in quiz1 equals to the corresponding element in quiz2

            Console.WriteLine(equal);

        }
        static void Test1()
        {
            var random = QuestionBank.GetQuestionRange(Enumerable.Range(1,2));
            var quiz1 = random;
            var quiz2 = random;//shared
            var equal = quiz1.SequenceEqual(quiz2);//true 

            Console.WriteLine(equal);

        }
        static void Test2()
        {

            var quiz1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 3));//not shared
            var quiz2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 3));
            var equal = quiz1.SequenceEqual(quiz2);//must implements equailty
            Console.WriteLine(equal);

        }
    }
}
