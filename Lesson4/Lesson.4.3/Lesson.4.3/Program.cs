namespace Lesson4._3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
           

            int x = 0;
            do
            {
                x -= 20;
                Console.WriteLine(x);
            }
            while (x != -100);
            Console.ReadKey();
        }
    }
}