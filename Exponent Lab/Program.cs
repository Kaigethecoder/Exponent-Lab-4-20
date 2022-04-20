public class Program

{
    
    public static void Main(string[] args)

    {
        //Exponent Lab / Powers Table
        //Objective: User input, calculations
        // Display table of powers. Ask the user if they would like to go again, and if so loop back to beginning
        //LMS Question: What is the Maximum possible value of an integer in C#? What about a long?
        //Answer: max value of integer = 2,147,483,647.  long max = 9,223,372,036,854,775,807
        bool number = true;
        bool table = true;
        while (table)
        {
            
                Console.WriteLine("Please enter an integer between 1 and 1290!");
                int entry = Int32.Parse(Console.ReadLine());

                if (entry > 0 && entry < 1291)
                {
                    number = true;
                }
                else
                {
                    number = false;
                Console.WriteLine("Whoops!  Try again. :)");
                }



                if (number)
                {

                    Console.WriteLine("Great Job! Let's take a look!");

                    Console.WriteLine("Number     Squared       Cubed");
                    Console.WriteLine("======     ========     ==========");
                    for (int currEntry = 1; currEntry <= entry; currEntry++)
                    {
                        int square = currEntry * currEntry;
                        int cube = square * currEntry;

                        Console.WriteLine(String.Format("{0, 5} |{1,12} | {2, 12}", currEntry, square, cube));


                    }



                    Console.WriteLine("Would you like to continue? y/n  ");
                    string response = Console.ReadLine();

                    if (response == "y" || response == "yes" || response == "Y" || response == "YES" || response == "Yes")
                    {
                        table = true;
                    }
                    else
                    {
                        table = false;
                    }
                }
            
        }
        Console.WriteLine("Thanks for playing! :)");
    }
}