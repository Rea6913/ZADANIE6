using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            // put your code here
            //throw new NotImplementedException();
            if (number == null)
                throw new ArgumentNullException();
            if (number< 10)
                throw new ArgumentException();

            string str = number.ToString();
            int n = str.Length;
            int i;
            int[] mass = new int[n];
            for (i=0;i<n;i++)
                mass[i] = Convert.ToInt32(str[i])-48;

            int max = 0;
            int nom = n - 1;
            i = n - 1;
            for (;i>0;i--)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                    nom = i;
                }
                else if (mass[i] < max)
                    break;
            }
            mass[nom] = mass[i];
            mass[i] = max;
            for (int i1=i+1;i1<n;i1++)
                for (int j1=i+2;j1<n;j1++)
                {
                    if (mass[i1]>mass[j1])
                    {
                        int el = mass[i1];
                        mass[i1] = mass[j1];
                        mass[j1] = el;
                    }
                }
            int otv = 0;
            for (i = 0; i < n; i++)
            {
                otv += mass[i];
                otv *= 10;
            }
            return otv/10;


        }
    }
}