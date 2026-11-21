using SharedForGenration;

namespace ElementAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var questionAt1 = questions.ElementAt(1);//index starts from 0, so this will get the 2nd question in the collection
            //if at index 300 there is no question, it will throw an ArgumentOutOfRangeException, so we can use ElementAtOrDefault to avoid that and return null instead
            var questionAt300 = questions.ElementAtOrDefault(300);//and check if it is null before using it
            Console.WriteLine(questionAt1);
            if (questionAt300 != null)
            {
                Console.WriteLine(questionAt300);
            }
        }
    }
}
