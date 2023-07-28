namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 58,67,98,45};
            double[] doubleArray = { 20.25, 40.31, 68.99, 43.32 };
            char[] charArray = { 'D', 'R', 'E', 'A', 'M' };

            Console.WriteLine("Welcome to Generics program");
            Console.WriteLine("Please choose any one program from below options.");
            Console.WriteLine("1.PrintArray without generics.\n2.Print array using generics method.\n3.PrintArrayUsingGenericClass");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PrintArray.ToPrint(intArray) ; 
                    PrintArray.ToPrint(doubleArray) ;
                    PrintArray.ToPrint(charArray) ;
                    break;
                case 2:
                    PrintArrayUsingGenericMethod.ToPrint(intArray) ;
                    PrintArrayUsingGenericMethod.ToPrint(intArray);
                    PrintArrayUsingGenericMethod.ToPrint(intArray);
                    break; 
                case 3:
                    PrintArrayUsingGenericClass<int> intObject = new PrintArrayUsingGenericClass<int>(intArray);
                    intObject.ToPrint();
                    PrintArrayUsingGenericClass<double> doubleObject = new PrintArrayUsingGenericClass<double>(doubleArray);
                    doubleObject.ToPrint();
                    PrintArrayUsingGenericClass<char> charObject = new PrintArrayUsingGenericClass<char>(charArray);
                    charObject.ToPrint();
                    break;

                default:
                    Console.WriteLine("Please choose number within given options.");
                    break;
            }
        }
    }
}