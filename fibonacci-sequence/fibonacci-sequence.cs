using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_sequence
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de termos para construirmos a sequencia de Fibonacci: ");
            int fiboAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nFibonacci Implementation - OK\n");

            Fibonacci fibonacci = new Fibonacci();

            for (int i = 0; i < fiboAmount; i++)
            {
                Console.Write(fibonacci.GetNext() + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < fiboAmount; i++)
            {
                Console.Write(fibonacci.GetNext() + " ");
            }

            fibonacci.Reset();
            Console.Write("\nAfter Fibonacci.Reset() -> ");

            for (int i = 0; i < fiboAmount; i++)
            {
                Console.Write(fibonacci.GetNext() + " ");
            }

            Console.Write("\n\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nFiboTri Implementation - NOT OK\n");

            FiboTri fiboTri = new FiboTri();

            for (int i = 0; i < fiboAmount; i++)
            {
                Console.Write(fiboTri.GetNext() + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < fiboAmount; i++)
            {
                Console.Write(fiboTri.GetNext() + " ");
            }

            fiboTri.Reset();
            Console.Write("\nAfter FiboTri.Reset() -> ");

            for (int i = 0; i < fiboAmount; i++)
            {
                Console.Write(fiboTri.GetNext() + " ");
            }

            Console.ReadKey();
        }
    }

    public interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int N);
    }

    class Fibonacci : ISeries
    {
        private int n;
        private int contador;

        private int aux;

        private int[] vetor = new int[50];

        public Fibonacci()
        {
            this.SetStart(0);
            this.contador = this.n;
        }

        public int GetNext()
        {
            this.aux = 1;

            return this.recursao(this.contador++);
        }

        private int recursao(int n)
        {
            if (n < 0)
            {
                return this.vetor[0];
            }
            else
            {
                if (aux < 3)
                {
                    this.vetor[n] = this.aux - 1;
                    this.aux++;
                }
                else
                {
                    this.vetor[n] = this.vetor[n + 1] + this.vetor[n + 2];
                }

                return recursao(n - 1);
            }
        }

        public void Reset()
        {
            this.contador = n;
            this.vetor = new int[50];
        }

        public void SetStart(int n)
        {
            this.n = n;
        }
    }

    class FiboTri : ISeries
    {
        private int n;
        private int contador;

        private int aux;

        private int[] vetor = new int[50];

        public FiboTri()
        {
            this.SetStart(0);
            this.contador = this.n;
        }

        public int GetNext()
        {
            this.aux = 1;

            return this.recursao(this.contador++);
        }

        private int recursao(int n)
        {
            if (n < 0)
            {
                return this.vetor[0];
            }
            else
            {
                if (aux < 4)
                {
                    this.vetor[n] = this.aux - 1;
                    this.aux++;
                }
                else
                {
                    this.vetor[n] = this.vetor[n + 1] + this.vetor[n + 2] + this.vetor[n + 3];
                }

                return recursao(n - 1);
            }
        }

        public void Reset()
        {
            this.contador = n;
            this.vetor = new int[50];
        }

        public void SetStart(int n)
        {
            this.n = n;
        }
    }
}
