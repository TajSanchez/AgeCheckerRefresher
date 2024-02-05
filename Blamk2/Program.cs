using System.Security.Cryptography.X509Certificates;

namespace Blamk2
{
   internal class Program
    {
        public static void AgeChecker(int userAge)
        {
            if (userAge == 18)
            {
                
                Console.WriteLine("You can vote, finally 18!!! :P ");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Sorry you're a bit too young..");
            }
            else
            {
                Console.WriteLine("You can vote, a little bit older I see.");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hi welcome to the voting page! Please enter your age. (USE NUMBERS ONLY)");


            int userAge = int.Parse(Console.ReadLine());

            AgeChecker(userAge);
        } 
    }
}