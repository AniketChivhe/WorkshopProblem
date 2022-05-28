using System;

namespace WorkshopProject
{
    public class Programs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter nth no. to check Harmomnic Number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("please enter valid input other than 0");
                return;
            }
            Console.WriteLine("nth Harmonic number is :");
            Console.WriteLine(Harmonic(n));  
        }

        static double Harmonic(int N)
        {
            float harmo = 1;
            for (int i=2; i<= N; i++)
            {
                float a = (float)1 / i;
                harmo = harmo + a;
            }
            return harmo;
        }
    }
    
}