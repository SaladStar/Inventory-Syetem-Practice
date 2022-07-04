using System;

namespace InventorySystem
{
    
    /*
     * Part object - represents a part
     * Attributes: Part Number, Part ID, 
     *             Description, Cost
     */
    class Parts
    {
        string partNumber { get; set; } 
        int partId { get; set; }
        string partDescription { get; set; }
        double partCost { get; set; }

    }

    class WelcomeMessage
    {
        /*
         * Start Message for the program
         */
        public void StartMessage()
        {
            System.Console.WriteLine("----------Welcome to the Simple inventory system (SIS)-----------\n");
            System.Console.WriteLine("Please choose from the following options:\n" +
                "1. Inventory       2. Add a new part   3. Delete a part\n" +
                "4. Modify a part   5. Exit");
        }


    }


    class MainPage : WelcomeMessage
    {


        static void Main(string[] args)
        {
            String x = String.Empty; //initialize user's option

            WelcomeMessage message = new WelcomeMessage(); //creates message object
            message.StartMessage(); //creates the start message

            x = System.Console.ReadLine();
            validateUserOption(x);
        }
        static void validateUserOption(String x)
        {
            try
            {
                int result = Int32.Parse(x);

                // TODO: implement While loop until user selects valid option
                if (result > 5 || result < 0) System.Console.WriteLine("Please choose a valid option");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse'{x}'");
            }
        }


    }
    

}
