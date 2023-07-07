namespace _401_Lab1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            StartSequence();
        }

        static void StartSequence()
        {
            int[] NumberArray = new int[4]; // Creates an array to hold 4 numbers
            int[] PopulateResult = Populate(NumberArray); // Calls the Populate method to fill the array with numbers
            int sum = GetSum(PopulateResult); // Gets the sum of the numbers in the array
            int product = GetProduct(PopulateResult, sum); // Gets the product of a random number from the array and the sum
            GetQuotient(product); // Gets the quotient of the product and a number provided by the user

            Console.WriteLine(PopulateResult); // Prints the array
            for (int i = 0; i < PopulateResult.Length; i++)
            {
                Console.Write(PopulateResult[i] + " "); // Prints each element of the array
            }
        }

        static int[] Populate(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Give me a number");
                string userInput = Console.ReadLine();
                int number = Int32.Parse(userInput);
                array[i] = number; // Stores the users number in the array
            }
            return array; // Returns the populated array
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; // Calculates the sum of the numbers in the array
            }

            if (sum < 20)
            {
                throw new Exception("Number is too low"); // Throws an exception if the sum is less than 20
            }

            Console.WriteLine("This is the sum: " + sum);
            return sum; // Returns the sum
        }

        static int GetProduct(int[] array, int sum)
        {
            Console.WriteLine("Pick a random number between 1 and {0}", array.Length);
            string randomIndex = Console.ReadLine();
            int randomIndexInt = Int32.Parse(randomIndex) - 1;
            int randomNumber = array[randomIndexInt]; // Gets a random number from the array based on user input

            Console.WriteLine("Random number is: {0}", randomNumber);

            int product = randomNumber * sum; // Calculates the product of the random number and the sum
            Console.WriteLine("This is the product {0}", product);
            return product; // Returns the product
        }

        static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine("Give me a number to divide the product by");
                string userInput = Console.ReadLine();
                int divisor = Int32.Parse(userInput);

                if (divisor == 0)
                {
                    Console.WriteLine("Cannot divide by 0");
                    return 0;
                }

                decimal quotient = (decimal)product / divisor; // Calculates the quotient of the product and the divisor
                Console.WriteLine("This is the quotient: {0}", quotient);
                return quotient; // Returns the quotient
            }
            catch (Exception e)
            {
                Console.WriteLine("Uh Oh ", e);
                return 0;
            }
        }
    }
}