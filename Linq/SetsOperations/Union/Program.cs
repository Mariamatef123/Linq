using SharedForSetsOperations;

namespace Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participants1 = Repository.GetMeetings()[0].Participants.Union(Repository.GetMeetings()[1].Participants);
            var participants2 = Repository.GetMeetings()[0].Participants.UnionBy(Repository.GetMeetings()[1].Participants, p => p.EmployeeId);
            foreach (var p in participants2)
            {
                Console.WriteLine(p.Name);
            }
        }

    }
}
