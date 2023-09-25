using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace _1._3Uzduotis_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 13, 5, 27, 10, 3 };
            List<int> result = HighterThan10(numbers);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static List<int> HighterThan10(List<int> numbers)
        {
            return numbers.FindAll(listNumber => listNumber > 10);
        }
    }
}


