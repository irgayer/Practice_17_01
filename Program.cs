using System;

namespace Practice_17_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArray array = new CustomArray(-5, -1);
            for(int i = array.MinIndex; i <= array.MaxIndex; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
