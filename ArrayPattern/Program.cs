using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPattern_P_Q_R
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Testing basic combination logic");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Comb of 6 elem choose 2 = " + CombinationCount(6,2).ToString());
            Console.WriteLine("Comb of 3 elem choose 2 = " + CombinationCount(3, 2).ToString());
            Console.WriteLine("Comb of 7 elem choose 3 = " + CombinationCount(7, 3).ToString());
            
            int[] test = new[] { 0,0,0 };
            int[] result = makeArrayOfAllCombination(test);
            Console.WriteLine("Testing merged array logic");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("result[" + i.ToString() + "] = " + result[i]);
            }
            Console.ReadLine();

        }
/// <summary>
/// Computes total number of combinations of n elements with lenght of k
/// </summary>
/// <param name="n">Total number of elements</param>
/// <param name="k">Lenght (less than n) </param>
/// <returns></returns>
        private static int CombinationCount(int n, int k)
        {
            //int rv = 0;
            int N = 1;
            int K = 1;

            for (int i = n; i >= n - k + 1; i--)
            {
                N *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                K *= i;
            }
            Console.WriteLine("from subroutine N = " + N.ToString());
            Console.WriteLine("from subroutine K = " + K.ToString());
            return N/K;
        }

        public static int[] makeArrayOfAllCombination(int[] origin)
        {
            int countOfResultArray = CombinationCount(origin.Length, 2);
            int[] resultArray = new int[countOfResultArray];
            int loopcount = 0;
            for (int i = 0; i < origin.Length; i++)
            {
                for (int j = i+1; j < origin.Length; j++)
                {
                    resultArray[loopcount] = origin[i] + origin[j];
                    for (int k = 0; k < origin.Length; k++)
                    {
                        if(origin[k] == resultArray[loopcount] && 
                                   i != j && 
                                   i!=k && 
                                   j != k)
                        {
                            Console.WriteLine("***Found:  " + origin[k].ToString() + " = " + origin[i].ToString() + " + " + origin[j].ToString() + "***");
                        }
                    }
                    loopcount++;
                }
            }
            return resultArray;
        }
     }
 }
    