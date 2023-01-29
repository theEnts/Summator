namespace Summator
{
    public static class Summator_Methods
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static double Average(double[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        public static double Multiplication(int[] arr)
        {

            int x = arr[0];
            int y = arr[1];

            int quotient = 0;

            for (int i = 0; i < y; i++)
            {
                quotient += x;
            }
            return quotient;
        }

        public static double PowerOfNumbers(double[] arr)
        {
            double result = Math.Pow(arr[0], arr[1]);
            return result;
        }

        public static int Divide(int[] arr)
        {
            int x = arr[0]; 
            int y = arr[1];

            int quotient = 0;

            while (x - y >=0)
            {
                x -= y;
                quotient += 1;
            }
            return quotient;


        }
    }
}
