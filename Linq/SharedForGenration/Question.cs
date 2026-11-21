using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForGenration
{
    public class Question
    {
        public string Title { get; set; }
        public List<Choice> Choices { get; set; } = new();
        public int CorrectAnswer { get; set; }
        public readonly static Question Default = new Question
        {
            Title = "What is the capital of France?",
            Choices = new List<Choice>
            {
            new Choice { Order = 1, Description = "Berlin" },
                new Choice { Order = 2, Description = "Madrid" },
                new Choice { Order = 3, Description = "Paris" },
                new Choice { Order = 4, Description = "Rome" }
        },
            CorrectAnswer = 2
        };

        public override string? ToString()
        {
            var choices = "";
            foreach (var choice in Choices)
            {
                choices += $"{choice.Order}. {choice.Description}\n";
            }
            return $"{Title}\n{choices}";
        }
    }
}
