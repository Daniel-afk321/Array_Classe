using System;
using System.Globalization;

namespace Array_Classe
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Digite o numero de pessoas");
            //Criando a variável de entrada
            int A = int.Parse(Console.ReadLine());
            //Criando vetor com o número da variável de entrada
            double[] vect = new double[A];
            //Utilização do comando for para percorrer o vetor
            for (int i = 0; i < A; i++)
            {
                Console.WriteLine("Digite as alturas");
                //Entrada dos elementos no vetor pelo usuário
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //Variável soma 
            double sum = 0.0;
            //Variável Media
            double media;
            //Utilização do for para percorrer o vetor
            for (int i = 0; i < A; i++)
                
            {
                //Somatoriados elementos inseridos
                sum += vect[i];
               
            }
            //calculo da media 
            media = sum / A;

            Console.WriteLine("A Media de altura das pessoas Inseridos é = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

