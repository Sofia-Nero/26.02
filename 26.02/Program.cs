namespace _26._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = CreateArray(7);
            int num = int.Parse(Console.ReadLine());
            foreach (int i in array) { Console.WriteLine(i); }
            (array, int place)= TransSearch(array, num);
            if (place == -1)
            {
                Console.WriteLine("Your target num wasnt found");
            }
            else { Console.WriteLine("target num was found on " + place + " place"); }
            foreach (int i in array) { Console.WriteLine(i); }
        }
        static (int[] array,int target) TransSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (i != 0)
                    {
                        array[i - 1] = array[i - 1] + array[i];
                        array[i] = array[i - 1] - array[i];
                        array[i - 1] = array[i - 1] - array[i];
                    }
                    return (array, i);
                }
                
            }
            return (array, -1);
        }
        public static int[] CreateArray(int size)
        {
            Random random = new Random(Environment.TickCount);
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, size);
            }
            return array;
        }
    }
}
