using EFCore.ReverseEngineering.Models;

namespace EFCore.ReverseEngineering
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new TechTalkContext().Speakers)
            {
                Console.WriteLine(item.FirstName+" "+ item.LastName); 
            }
        }
    }
}