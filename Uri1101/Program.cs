using System;

namespace Uri1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, menor, soma, a, b, sair;

            soma = 0;
            sair = 0;
            maior = 1;
            menor = 1;



            while (sair !=1)
            {

                string[] vetor = Console.ReadLine().Split(' ');
                a = int.Parse(vetor[0]);
                b = int.Parse(vetor[1]);

                if (a <= 0 || b <= 0)
                {
                    sair = 1;
                }
                else
                {
                    if (a > b)
                    {
                        maior = a;
                        menor = b;
                    }
                    else
                    {
                        maior = b;
                        menor = a;
                    }



                    for (int c = menor; c <= maior; c++)
                    {


                        soma = soma + c;
                        Console.Write(c + " ");

                    }



                    Console.WriteLine("Sum = " + soma);
                    soma = 0;
                }
            }
        }
    }
}
