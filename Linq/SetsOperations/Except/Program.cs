using SharedForSetsOperations;

namespace Except
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var participants1 = Repository.GetMeetings()[0].Participants.Except(Repository.GetMeetings()[1].Participants);
           var participants2 = Repository.GetMeetings()[0].Participants.ExceptBy((Repository.GetMeetings()[1].Participants).Select(p => p.EmployeeId), p => p.EmployeeId);
           foreach (var p in participants2)
           {
               Console.WriteLine(p.Name);
           }                    
        }
    }
}
