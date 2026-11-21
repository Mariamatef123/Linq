using SharedForSetsOperations;

namespace Distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var meeting1 = Repository.GetMeetings()[0];
            var meeting2 = Repository.GetMeetings()[1];
            var participants = meeting1.Participants.Concat(meeting2.Participants).Distinct();//lw msh nfs el reference hyt3ml distinct 3la el object msh 3la el value
            var participants1 = meeting1.Participants.Concat(meeting2.Participants).DistinctBy(p => p.EmployeeId);
            foreach (var p in participants1)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
