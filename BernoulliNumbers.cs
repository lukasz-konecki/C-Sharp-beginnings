using System;

namespace ArrayExercise
{
    class BernoulliNumbers
    {
        static long factorial(int n)
        {
            if (n < 2)
                return 1;
            else
            {
                long result = n;
                for (int i = 1; i < n; i++)
                {
                    result *= n-i;
                }
                return result;
            }
        }

        static long binomial(int n, int k)
        {
            return factorial(n) / factorial(k) / factorial(n-k);
        }
        
        static double[] bernoulli(int n)
        {
            double[] returnArray = new double[n+1];

            returnArray[0] = 1;
            for(int m=1; m <= n; m++)
            {
                double sum = 0;
                for (int k = 0; k < m; k++)
                {
                    sum += binomial(m+1, k) * returnArray[k];
                }
                returnArray[m] = -sum/(m+1);
            }
            return returnArray;
        }

        static void Main()
        {
            Console.WriteLine("Up to which Bernoulli number do you want to display?");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int n)&&(n>=0))
            {
                Console.Write("\n");
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine($"B[{i}]={bernoulli(n)[i]}");
                }
            }
            else
                Console.WriteLine("You did not provide a non-negative integer.");

            Console.ReadLine();
        }
    }
}
