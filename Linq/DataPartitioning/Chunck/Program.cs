using Shared;

namespace Chunck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var chuncks = emps.Chunk(2).ToList();
            for(int i = 0; i < chuncks.Count; i++)
            {
                Console.WriteLine($"{i+1}");
                chuncks[i].PrintEmployees();
            }//lw operation t2ela momken n2smha aw kda
                       

        }
    }
}
