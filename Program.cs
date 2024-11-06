namespace Assignment1_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a console application in C# to explore different ways in which
            //   array is declared and initialized and explore different properties and methods of Array class.

            //Declare a new array without size, can be initialized later
            int[] arr1;

            //Declare a new empty array with a predetermined size
            int[] arr2 = new int[5];

            //Declare a new array that already has elements and assumed size
            int[] arr3 = { 3, 1, 3, 6, 2 };
            string[] arr4 = { "Tom", "Josh", "Mike", "Kim"};
            double[] arr5 = { 1.0, 3.5, 5.3, 22.1, 42.3, -3.1};

            // Print out array elements and length to console
            PrintArray(arr3);
            Console.WriteLine("\nThe Length of Array 3 is: " + (arr3.Length));
            PrintArray(arr4);
            Console.WriteLine("\nThe Length of Array 4 is: " + (arr4.Length));
            PrintArray(arr5);
            Console.WriteLine("\nThe Length of Array 5 is: " + (arr5.Length));

            // Sorts the arrays in ascending order
            Array.Sort(arr3);
            Array.Sort(arr4);
            Array.Sort(arr5);

            // Prints sorted arrays to console
            Console.WriteLine("\nSORTED ARRAYS");
            PrintArray(arr3);
            Console.WriteLine("\n Array 3");
            PrintArray(arr4);
            Console.WriteLine("\n Array 4");
            PrintArray(arr5);
            Console.WriteLine("\n Array 5");


        }

        static void PrintArray(Array arr)
        {
            Console.WriteLine();
            foreach (var elem in arr)
            {
                Console.Write("| " + elem + " |");
            }
        } 
    }
}
