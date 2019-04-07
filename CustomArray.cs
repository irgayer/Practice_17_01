using System;

namespace Practice_17_01
{
    public class CustomArray
    {
        const int MAX_RANDOM = 100;
        const int DEFAULT_SIZE = 5;

        public int MinIndex { get; }
        public int MaxIndex { get; }
        public int Size { get; }

        private int[] array;

        public CustomArray(int minIndex, int maxIndex)
        {
            Random random = new Random();
            MinIndex = minIndex;
            MaxIndex = maxIndex;

            if (MinIndex > MaxIndex)
            {
                Size = DEFAULT_SIZE;
            }
            else if (MaxIndex > MinIndex)
            {
                Size = MaxIndex - MinIndex + 1;
            }
            array = new int[Size];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(MAX_RANDOM);
            }
        }

        public int this[int index]
        {
            get {
                if(MinIndex <= 0)
                {
                    return array[index + Math.Abs(MinIndex)];            
                }
                else
                {
                    return array[index - MinIndex];
                }
            }
            set {
                if (MinIndex <= 0)
                {
                    array[index + Math.Abs(MinIndex)] = value;
                }
                else
                {
                    array[index - MinIndex] = value;
                }
            }
        }
    }
}
