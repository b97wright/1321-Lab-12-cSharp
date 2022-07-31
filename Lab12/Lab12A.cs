using System;

namespace Lab12
{
    // This is the Class For Chair 
    class Chair
    {
        public int numOfLegs;
        public bool isRooling;
        public string chairMaterial;

        public void userCreatedChair()
        {
            Console.Write("Your chair has " + numOfLegs + " legs, ");

            if (isRooling == true)
                Console.Write("is rolling, and is made of " + chairMaterial);
            else
                Console.Write("is not rolling, and is made of " + chairMaterial);

            Console.WriteLine("\n");
        }

    }

    class Lab12
    {
        static void Main(string[] args)
        {
            string uI;

            // Cretes and Objet of Type Chair 
            Chair userChair = new Chair();
            Chair compChair = new Chair();

            Console.WriteLine("You are about to create a chair.");
            Console.Write("How many legs does your chair have: ");
            uI = Console.ReadLine();

            // sends (int) uI to the userChhair variable which is of class Chair
            userChair.numOfLegs = Convert.ToInt32(uI);

            Console.Write("Is your chair rolling (true/false): ");
            uI = Console.ReadLine();

            // sends (bool) uI to the userChhair variable which is of class Chair
            userChair.isRooling = Convert.ToBoolean(uI);

            Console.Write("What is your chair made of: ");
            uI = Console.ReadLine();

            // sends (string) uI to the userChhair variable which is of class Chair
            userChair.chairMaterial = Convert.ToString(uI);

            Console.Write("\n");

            userChair.userCreatedChair();

            Console.WriteLine("This program is going to change that. \n");

            compChair.numOfLegs = 4;
            compChair.isRooling = false;
            compChair.chairMaterial = "wood";


            compChair.userCreatedChair();

        }
    }
}
