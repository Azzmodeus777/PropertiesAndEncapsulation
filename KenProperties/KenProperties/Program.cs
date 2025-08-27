using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenProperties
{
    //Khein Retsel B. Pino
    //Section: BSIT-306
    //EXER_05: Applying Encapsulation with User
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of Shoe class
            Shoe myShoe = new Shoe();

            // Set values using properties
            myShoe.Brand = "Nike";
            myShoe.Size = 9.5;

            // Display details
            myShoe.DisplayDetails();

            // Keep console open
            Console.ReadLine();
        }
    }

}
