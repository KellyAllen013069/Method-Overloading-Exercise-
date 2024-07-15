namespace MethodOverloading
{
    public class Program
    {
        // Create a method named Add, that accepts two integers and returns the sum of those two integers
        public static int Add(int x, int y)
        {
            return x + y;
        }
        // Now create an overload of the Add method to account for being able to add two decimals together
        public static double Add(double x, double y)
        {
            return x + y;
        }
        // Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        public static string Add(int x, int y, bool isMoney)
        {
            var result = x + y;
            var stringToAppend = result == 1 ? " dollar" : " dollars";
            var returnString = (x + y).ToString();
            return isMoney ? returnString + stringToAppend : returnString ;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the first integer:");
            var int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer:");
            var int2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{int1} + {int2} = {Add(int1, int2)}");
            
            Console.WriteLine("Please enter the first decimal number:");
            var double1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer:");
            var double2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{double1} + {double2} = {Add(double1, double2)}");
            
            Console.WriteLine("Please enter the first integer:");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second integer:");
            int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Should this be in dollars? Enter 1 for yes and 2 for no");
            var money = int.Parse(Console.ReadLine());
            var isMoney = money == 1 ? true : false;
            Console.WriteLine($"{int1} + {int2} = {Add(int1, int2, isMoney)}");



    }
    }
}
