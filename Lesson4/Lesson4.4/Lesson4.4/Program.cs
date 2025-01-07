namespace Lesson4._4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            
            Console.CursorVisible = false;
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.W)
                {
                    Console.WriteLine("You have shifted the object up");
                }
                else if (pressedKey.Key == ConsoleKey.A)
                {
                    Console.WriteLine("You have shifted the object left");
                }
                else if (pressedKey.Key == ConsoleKey.S)
                {
                    Console.WriteLine("You have shifted the object down");
                }
                else if (pressedKey.Key == ConsoleKey.D)
                {
                    Console.WriteLine("You have shifted the object right");
                }
                else
                {
                    Console.WriteLine("You havent shifted the object!");
                }
            }
        }
    }
}