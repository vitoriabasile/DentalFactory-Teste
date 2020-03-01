using System;


namespace Questao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x = Console.ReadLine().Split(' ');
            int[] number = new int[x.Length];

            if (x.Length > 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    number[i] = Convert.ToInt32(x[i]);
                }
            }

            int r = GetNumber(number);

            Console.WriteLine(r);
        }

        private static int GetNumber(int[] number)
        {
            int x = number.Length;
            int i, j;
            int[] cont = new int [x];
            int conta = 0, moda = 0;

            for (i = 0; i < number.Length; i++)
            {
                for (j = i + 1; j < number.Length; j++)
                {

                    if (number[i] == number[j])
                    {
                        cont[i]++;
                        if (cont[i] == conta && number[i] > moda)
                        {
                            moda = number[i];
                        }
                        else
                        {
                            if (cont[i] > conta)
                            {
                                conta = cont[i];
                                moda = number[i];

                            }
                        }
                    }

                }
                cont[i] = 0;
            }
            if (conta == 0)
            {
                return 0;
            }
            else
            {
                return moda;
            }

        }
    }
}
