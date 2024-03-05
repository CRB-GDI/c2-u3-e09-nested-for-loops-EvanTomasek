namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your row width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter how many rows: ");
            int height = int.Parse(Console.ReadLine());

            //print rows going down
            Console.WriteLine();
            for (int a =1; a < height; a++) 
            {
               //print content of the row to the right
               for (int b =1; b < width; b++) 
                {
                    Console.Write("*");
                }
               Console.WriteLine();
            }
        }
    }
}