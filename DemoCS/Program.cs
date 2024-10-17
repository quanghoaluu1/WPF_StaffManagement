using System.Linq;

namespace DemoCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Đếm số hoàn hảo và tính tổng nó
            int[] arr = {2,4,6,12  };
            //Console.WriteLine(sumPerfectNumber(arr));
            //int x = 4; int y = 5; int z = 6;
            //myMethod(x, ref y, out z);
            //Console.WriteLine($"x: {x}, y: {y}, z: {z}");
            //Console.ReadLine();
            //(int sum, int count) result = sumAndCount(arr);
            //Console.WriteLine($"Sum: {result.sum}, Count: {result.count}");

        }
        public string ClearDigits(string s)
        {
            char[] a = s.ToCharArray();
            List<char> list = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (isDigit(a[i]))
                {

                }                
            }
        }
        private bool isDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        private static void myMethod(int a, ref int b, out int c) {
            a = 1;
            b = 2;
            c = 3;
        }

        //Tuples
        private static (int sum, int count) sumAndCount(int[] n)
        {
            (int sum, int count) result = (0,0);
            
            foreach(int num in n)
            {
                result.sum += num;
                result.count++;
            }
            return result;
        }

        private static int sumPerfectNumber(int[] n)
        {
            int sum = 0;
            for (int i = 1; i < n.Length; i++)
            {
                if (isPerfectNumber(n[i]))
                {
                    sum += n[i];
                }
            }
            return sum;
        }

        private static bool isPerfectNumber(int n)
        {
            bool isPerfect = false;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                isPerfect = true;
            }
            return isPerfect;

        }

    }
}
