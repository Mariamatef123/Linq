using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForGenration
{
    public static class QuestionBank
    {
        private static Random random = new Random();
        public static IEnumerable<Question> Randomize(int count)
        {
            if(All.Count < count)
            {
                return AllShuffled;
            }
            return AllShuffled.Take(count);
        }
        public static Question PickOne()
        {
            return All[random.Next(0, All.Count )]; 
        }
        public static List<Question> All = new List<Question>
        {
            Question.Default,
            new Question
            {
                Title = "#1 What is the capital of Germany?",
                Choices = new List<Choice>
                {
                    new Choice { Order = 1, Description = "Berlin" },
                    new Choice { Order = 2, Description = "Madrid" },
                    new Choice { Order = 3, Description = "Paris" },
                    new Choice { Order = 4, Description = "Rome" }
                },
                CorrectAnswer = 1
            },
            new Question
            {
                Title = "#1 What is the capital of Spain?",
                Choices = new List<Choice>
                {
                    new Choice { Order = 1, Description = "Berlin" },
                    new Choice { Order = 2, Description = "Madrid" },
                    new Choice { Order = 3, Description = "Paris" },
                    new Choice { Order = 4, Description = "Rome" }
                },
                CorrectAnswer = 2
            }
        };
        private static List<Question> AllShuffled => All.OrderBy(x => random.Next()).ToList();
    public static  void ToQuiz(this IEnumerable<Question> question)
        {
            foreach(var q in question)
            {
                Console.WriteLine(q);
                Console.WriteLine();
            }
        }
   public static List<Question> GetQuestionRange(IEnumerable<int> range)
        {
            var questions = new List<Question>();
            foreach (var index in range)
            {
                if (index >= 0 && index < All.Count)
                {
                    questions.Add(All[index]);
                }
            }
            return questions;
        }
       

    }
}
