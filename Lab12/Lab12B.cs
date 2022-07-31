using System;

namespace Lab12
{
    // This is the Class For dog
    class dog
    {
        public int age;             // current age of the dog
        public double weight;       // how much does it weight in lbs
        public string name;         // what is the name of the dog
        public string furColor;     // color of the dog’s fur/hair 
        public string breed;        // what breed is the dog 

        public void bark()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public string rename(string newName)
        {
            name = newName;
            return null;
        }

        public double eat(double food)
        {
            weight += food;
            return 0;   
        }

    }

    class Lab12
    {
        static void Main(string[] args)
        {
            string uI;

            // Cretes and Objet of Type Chair 
            dog dogOne = new dog();

            // age
            Console.WriteLine("You are about to create a dog. ");
            Console.Write("How old is the dog: ");
            uI = Console.ReadLine();

            dogOne.age = Convert.ToInt32(uI);

            // weight
            Console.Write("How much does the dog weigh: ");
            uI = Console.ReadLine();

            dogOne.weight = Convert.ToDouble(uI);

            // name
            Console.Write("What is the dog’s name: ");
            uI = Console.ReadLine();

            dogOne.name = uI;

            // color
            Console.Write("What color is the dog: ");
            uI = Console.ReadLine();

            dogOne.furColor = uI;

            // breed
            Console.Write("What breed is the dog: ");
            uI = Console.ReadLine();

            dogOne.breed = uI;

            // print
            Console.WriteLine("\n" + dogOne.name + " is a " + dogOne.age + " year old " + dogOne.furColor + " " + dogOne.breed + " that weighs " + dogOne.weight + " lbs. \n");
            dogOne.bark();

            // feed dog
            Console.Write(dogOne.name + " is hungry, how much should he eat: ");
            uI = Console.ReadLine();
            dogOne.eat(Convert.ToDouble(uI));

            // rename 
            Console.Write(dogOne.name + "  isn’t a very good name. What should they be renamed to: ");
            uI = Console.ReadLine();
            dogOne.rename(uI);

            //print
            Console.WriteLine("\n" + dogOne.name + " is a " + dogOne.age + " year old " + dogOne.furColor + " " + dogOne.breed + " that weighs " + dogOne.weight + " lbs.");


        }
    }
}
