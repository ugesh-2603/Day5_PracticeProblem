namespace Day5_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems.");
            Console.WriteLine("Please select from Integer/Double/Char:");
            Console.WriteLine("1.Delete Array \n2. Delete using Generics \n3. Delete using generic class \n4. Find Min Integer \n5. Find Min Float \n6. Find Min String \n7. Refractor using Generic Method \n8. Refractor using Generic Class ");

            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:

                    object[] Array = { 1, 2, 'A', 3, 4.0, 'B', 5, 6.5, 'C' };
                    object elementToDelete = 'B';
                    Array = DeleteArray.DeleteMethod(Array, elementToDelete);

                    Console.WriteLine("Updated Array:");
                    foreach (var item in Array)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 2:

                    object[] mixedArray = { 1, 2.5, 'A', 3, 4.0, 'B', 5, 6.5, 'C' };

                    object elementToDelete1 = 'c';

                    // Call the DeleteMethod to delete the specified element
                    mixedArray = DeleteArray.DeleteMethod(mixedArray, elementToDelete1);

                    // Display the updated array
                    Console.WriteLine("Updated Array:");
                    foreach (var item in mixedArray)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 3:

                    char[] charArray = new char[n];
                    Console.WriteLine("Enter the character array:");
                    for (int i = 0; i < n; i++)
                    {
                        charArray[i] = char.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Enter the element to delete from character array:");
                    char elementToDeleteChar = char.Parse(Console.ReadLine());
                    DeleteArray<char> charDeleteArray = new DeleteArray<char>();
                    char[] updatedCharArray = charDeleteArray.DeleteMethod(charArray, elementToDeleteChar);

                    Console.WriteLine("\nUpdated Character Array:");
                    foreach (var item in updatedCharArray)
                    {
                        Console.Write(item + " ");
                    }
                    break;

                case 4:

                    Console.WriteLine("Enter three integers:");

                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    int num3 = int.Parse(Console.ReadLine());

                    FindMinOfThree minFinder = new FindMinOfThree();
                    int min = minFinder.FindMin(num1, num2, num3);

                    Console.WriteLine("The minimum number is: " + min);
                    break;

                case 5:

                   
                    Console.Write("Enter the first float: ");
                    float num1 = float.Parse(Console.ReadLine());

                    Console.Write("Enter the second float: ");
                    float num2 = float.Parse(Console.ReadLine());

                    Console.Write("Enter the third float: ");
                    float num3 = float.Parse(Console.ReadLine());

                    
                    float min = FindMinimum(num1, num2, num3);
                    Console.WriteLine("The minimum of the three floats is: " + min);
                    break;

                case 6:

                    Console.WriteLine("Enter three strings:");

                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    string str3 = Console.ReadLine();

                    FindMinOfThree minStringFinder = new FindMinOfThree();
                    string minS = minStringFinder.FindMin(str1, str2, str3);

                    Console.WriteLine("The minimum string is: " + minS);
                    break;

               

                    
            }

        
        }
    }
}