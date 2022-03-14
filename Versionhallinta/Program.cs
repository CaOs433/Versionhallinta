using System;

namespace Versionhallinta {
    class MainClass {

        // Print sum of 2 number parameters
        static void Sum(double x, double y) {
            Console.WriteLine(x + y);
        }

        // Print reduction of 2 number parameters
        static void Reduct(double x, double y) {
            Console.WriteLine(x - y);
        }

        // Print division of 2 number parameters
        static void Divide(double x, double y) {
            // !!!REMEMBER: CAN'T DIVIDE WITH 0!!!
            Console.WriteLine(y == 0 ? "Inf" : x / y);
        }

        // Print multiplication of 2 number parameters
        static void Multiplication(double x, double y) {
            Console.WriteLine(x * y);
        }

        public static void Main(string[] args) {
            Console.WriteLine("Versionhallinta - Ryhmä 4");
            Console.WriteLine("Nelilaskin\n");

            // Variables
            double x, y;
            string z;

            // Ask the 1. number
            Console.Write("\nAnna 1. luku: ");
            x = Convert.ToDouble(Console.ReadLine());

            // Ask the 2. number
            Console.Write("\nAnna 2. luku: ");
            y = Convert.ToDouble(Console.ReadLine());

            // Ask the operation
            Console.Write("\nAnna laskutoimitus (+, -, * tai /): ");
            z = Console.ReadLine();

            // Check and execute the operation
            switch (z) {
                case "+": Sum(x, y); break;
                case "-": Reduct(x, y); break;
                case "*": Multiplication(x, y); break;
                case "/": Divide(x, y); break;

                default: Console.WriteLine("Tuntematon operaattori!"); break;
            }

            // Prevent the console being terminated by waiting a key press from the user
            Console.ReadKey();
        }
    }
}
