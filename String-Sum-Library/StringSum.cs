using System;

namespace String_Sum_Library
{
    public static class StringSum
    {
        public static int Sum(String series)
        {
            int answer = 0;

            String[] numbers = series.Split(' ');

            foreach(string number in numbers)
            {
                int temp;

                if (int.TryParse(number, out temp))
                {
                    answer += temp;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            return answer;
        }
    }
}
