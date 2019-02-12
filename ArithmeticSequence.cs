using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int k = 0;
            if (number < int.MinValue || add < int.MinValue || count < int.MinValue)
                throw new OverflowException();
            if (number > int.MaxValue || add > int.MaxValue || count > int.MaxValue)
                throw new OverflowException();
            if (count < 0)
                throw new ArgumentException();
            int result = 0;
            for (int i = 0; i < count; i++)
            {
                k = result;
                if ((k += number) < 0)
                    throw new OverflowException();
                result += number;

                for (int j = 0; j < i; j++)
                {
                    k = result;
                    if ((k += add) < 0)
                        throw new OverflowException();
                    result += add;

                }
            }
            return result;
            //throw new NotImplementedException();
        }
    }
}
