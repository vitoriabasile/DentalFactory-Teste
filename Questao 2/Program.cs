using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' ');
            int[] number = new int[5];

            if (x.Length > 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    number[i] = Convert.ToInt32(x[i]);
                }
            }

            int i1 = 0;
            int i2 = 0;
            int aux = 0;

            for (int j = 0; j < 5; j++)
            {

                for(int k = 1; k < 5; k++)
                {
                    if(j == 0 && k == 1)
                    {
                        aux = number[j] - number[k];
                        i1 = number[j];
                        i2 = number[k];
                    }
                    else
                    {
                        if (number[j] - number[k] < aux && j < (k -1))
                        {
                            aux = number[j] - number[k];
                            i1 = number[j];
                            i2 = number[k];
                        }
                    }
                    
 
                }
            }

            

            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(aux);
        }
    }
}
