using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForSetsOperations
{
    public class Meeting
    {
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public List<Employee> Participants { get; set; } = new();
        public override string ToString()
        {
            var participants = "";
            var length = Participants.Count;
            for (int i = 0; i < length; i++)
            {
                participants += Participants[i];
                if (i < length - 1)
                {
                    participants += ", ";
                }

            }
            return $"Title: {Title}, Date: {Date}, StartTime: {StartTime}, EndTime: {EndTime}, Participants: {participants}";
        }
    }
}
