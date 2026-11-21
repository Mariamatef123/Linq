using SharedForGenration;

namespace Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var numbers = Enumerable.Range(1, 10);//deferred execution
          //implementation
                                                 //int[] range2 = new int[10];
                                                 //for (int i = 0; i < range2.Length; i++)
                                                 //{
                                                 //    range2[i] = i+1;
                                                 //}
                                                 //for (int i = 0; i < range2.Length; i++)
                                                 //{
                                                 //    Console.WriteLine(range2[i]);
                                                 //}
                                                 //for (int i = 0; i < range2.Length; i++)
                                                 //{
                                                 //    Console.WriteLine(range2[i]);
                                                 //}
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            var questions =QuestionBank.GetQuestionRange(numbers);
       questions.ToQuiz();
        }
    }
}
