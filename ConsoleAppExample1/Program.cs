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
            string x = null; //user's option

            WelcomeMessage message = new WelcomeMessage(); //creates message object
            message.StartMessage(); //creates the start message

            x = System.Console.ReadLine(); 
            System.Console.WriteLine(x);
        }
    }

}
