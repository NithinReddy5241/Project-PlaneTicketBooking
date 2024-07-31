using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PlaneTicketBooking
{
    public static class ISP
    {
             public static bool IsPrime(this int N)
            {
                 int c = 0;
                for (int i = 2; i <= N/2; i++)
                {
                    if (N % i == 0) c++;
                    if (c > 0) break;
                } if (c >=1 ) return false;
                else return true;
            } 
    }
    class Prime
    {
        static void Main(string[] args)
        {
            int n = 5;
            if (n.IsPrime())Console.WriteLine("Prime ");
            else Console.WriteLine("Not Prime");
        }
    }
}
