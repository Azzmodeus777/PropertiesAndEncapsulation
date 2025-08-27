using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenProperties
{
    class Shoe
    {
        // Private fields
        private string brand;
        private double size;

        // Public properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Size
        {
            get { return size; }
            set
            {
                if (value > 0) // validation for size
                    size = value;
                else
                    size = 0;
            }
        }

        // Method to display shoe details
        public void DisplayDetails()
        {
            Console.WriteLine("Shoe Details:");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Size: " + Size);
        }
    }


}
