namespace Lesson4._2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            

            int[] numArray = new int[10];
            Random randomNumbers = new Random();
            Console.Write($"The programme has created an array of 10 different numbers. {"\n"}{"\n"}Two-digit numbers that are multiples of 5: {"\n"}{"\n"}");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = randomNumbers.Next(250);

                if (numArray[i] > 9)
                {
                    if (numArray[i] % 5 == 0)
                    {
                        Console.Write(numArray[i] + "\t");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}