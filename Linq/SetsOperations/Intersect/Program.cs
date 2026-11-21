using SharedForSetsOperations;

namespace Intersect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participants1 = Repository.GetMeetings()[0].Participants.Intersect(Repository.GetMeetings()[1].Participants);
            var participants2 = Repository.GetMeetings()[0].Participants.IntersectBy((Repository.GetMeetings()[1].Participants).Select(p => p.EmployeeId), p => p.EmployeeId);
            foreach (var p in participants2)
            {
                Console.WriteLine(p.Name);
            }
        }
        
    }
}
