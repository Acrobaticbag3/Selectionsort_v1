using System;

namespace Selectionsort {
    class Program {
        static void Main(string[] args) {
            int[] numberArray = new int[8000]; // Array with 1000 ints
            Random intRng = new Random(); // Random number generator
        
            bool flag = true;  
            int arrayLength = numberArray.Length; // The length of the array.

            Console.WriteLine("= = = = = = = = = = = = = = = = = = = =");
            Console.WriteLine("Initial array is:");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = =");
            Console.ReadKey();

            for(int i = 0; i < 8000 ; i++) { // Assigns random values to the ints
                numberArray[i] = intRng.Next(1, 1001);
                Console.Write(numberArray[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = =");
            Console.WriteLine("Selection sort");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = =");
            Console.ReadKey();
            
            int temp, smallest;
            for (int i = 0; i < arrayLength - 1; i++) {
                smallest = i;
                for (int j = i + 1; j < arrayLength; j++) {
                    if (numberArray[j] < numberArray[smallest]) {
                    smallest = j;
                    }
                }
                temp = numberArray[smallest];
                numberArray[smallest] = numberArray[i];
                numberArray[i] = temp;
            }

            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < arrayLength; i++) {
                Console.Write(numberArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
