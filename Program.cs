using System.Collections;
namespace myApp{
    class Program{
        static void Main(string[] args){
 
            // Initializing the Hashtable with a capacity of 10
            Hashtable hashTable = new Hashtable(5)
            {
                { 100, "Kahlawy" },
                { 200, "Ahamed" },
                { 300, "Ali"},
                { "100", "Mohamed"},
                { "200", "Hassan"}
            };

            Console.WriteLine(new string("Hash Table Example with C#"));

            Console.WriteLine(new string('-', 60));

            // Print table header
            Console.WriteLine("{0,-10} | {1,-15} | {2,-10} | {3,-10}", "Key", "Key HashCode", "Value",  "Key Type");
            Console.WriteLine(new string('-', 60));

            // Iterating over the Hashtable and formatting the output as a table
            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine("{0,-10} | {1,-15} | {2,-10} | {3,-15}", key, key.GetHashCode(), hashTable[key],  key.GetType());
            }

            Console.WriteLine(new string('-', 60)); // Footer line

            // Explanation of hash codes:
            // For integer keys, the hash code is the same as the key.
            // For string keys, the hash code is calculated differently.
        }
    }
}

