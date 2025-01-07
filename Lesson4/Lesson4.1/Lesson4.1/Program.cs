namespace Lesson4._1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            
            int[] numArray = new int[5];
            Random randomNumbers = new Random();

            Console.Write($"Filling in an array and outputting element values with a help of for  {"\n"}");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = randomNumbers.Next(20);
                Console.WriteLine("Index of the array element " + i + " = Meaning " + numArray[i]);
            }

            Console.Write($"{"\n"}An outputting elements with the help of foreach {"\n"}");
            foreach (int i in numArray)
            {
                Console.WriteLine("The value of the array element: " + i);
            }

            Console.Write($"{"\n"} An outputting elements with the help of  while {"\n"}");
            int count = 0;
            while (numArray.Length > count)
            {
                count++;
                Console.WriteLine("The value of the array element: " + count);
            }

            Console.Write($"{"\n"}Вывод элементов массива циклом do while {"\n"}");
            int countCheck = 0;
            do
            {
                Console.Write(countCheck);
            }
            while (numArray.Length > countCheck++);

            Console.ReadKey();
        }
    }
    }

