using static System.Reflection.Metadata.BlobBuilder;

namespace CChavezCustomExceptionsDemo_
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                //try
                //{
                //    // code from live demo 
                //    int num1 = int.Parse(Input("Enter a number: "));
                //    //  Console.Write("Please enter num1: ");
                //    //  string num1str = Console.ReadLine();
                //    //  int num1 = int.Parse(num1str);

                //    Console.Write("Enter a second number: ");
                //    string num2str = Console.ReadLine();
                //    int num2 = int.Parse(num2str);

                //    Console.WriteLine("Num1/Num2: {0}", num1 / num2);
                //}
                try
                {
                    Console.Write("Please enter a social security number: ");
                    String userInput = Console.ReadLine();
                    SocialSecurityNumber ssn = new SocialSecurityNumber();
                    ssn.SSN = userInput;
                }
                //catch
                //{
                //    Console.WriteLine("There was an error!");
                //}
                //  6.2.	Add two more catch blocks before the generic Exception exc block:
                //  7.5.Remove or comment out all the catch blocks, except the generic Exception exc blocl.
                //catch (System.FormatException exc)
                //{
                //    Console.WriteLine("Not a number!");
                //}
                //catch(System.OverflowException exc)
                //{
                //    Console.WriteLine("Number is too large or small!");
                //}

                //  4.1.Change the catch block to:
                catch (Exception exc)
                {
                    Console.WriteLine("Error! " + exc.Message + "\nException type: " + exc.GetType());
                }
                //  5.1.	After the catch block add:
                finally
                {
                Console.WriteLine("This section always excecutes!");
                }

            Console.Write("Do another (y/n): ");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");

        }
        // one line ask a number method
        private static string Input(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }
    }
}
