using System.ComponentModel.Design;

namespace Repairing_the_Clocktower
{
    public class Program
{
    static void Main(string[] args)
    {
        //ask user for variable and assign it
        Console.WriteLine("Enter #");
        int tickTock = int.Parse(Console.ReadLine());

        //statement to determine output
        if (tickTock % 2 == 0) ;
        {
            //This is an even output
            Console.WriteLine("Tick");
        }

        else
        {
            //this is an odd output
            Console.WriteLine("Tock");
        }

    }
}
}