using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject.StringCollection
{
    class AvgNumberInString
    {

        public static void FindAvg(string str)
        {
            int avg, sum = 0,count=0;
            for(int i=0; i<str.Length; i++)
            {
                if(str[i]>=0 && str[i]<=9)
                {
                    sum = sum +str[i];
                    count++;
                }
                sum = (sum % count) * 100 / count;
                Console.WriteLine(sum);
            }
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            FindAvg(str);

        }
    }
}
