using System;

namespace TriCatch
{
    class Program
    {
        static void Main(string[] args) {
            try //try starts the catch with the thing you are trying to test for errors
            {
                int[] myNumbers = { 1, 5, 70 };
                Console.WriteLine(myNumbers[10]);
            }
            catch(Exception e) //in () you state the exception specifically or just do a blanked catch with Exception
            // you can set the exception as a variable in this case 'e'. You can then print out the exception
            {
                Console.WriteLine("something went wrong?");
                Console.WriteLine(e);
            }
            
            
        }
    }
}
