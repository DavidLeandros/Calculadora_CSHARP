using System;

namespace Calculadora_C_
{
    class Program
    {
        static void Main(string[] args)
        {   
            int on, off = 0;

            Console.WriteLine("Tecle 1 para ligar");
            on = int.Parse(Console.ReadLine());

            if (on == 1)
            {
                do 
                {

                Console.WriteLine("Digite a opção desejada para sua calculadora: \n" + 
                 "1 - Soma \n" + 
                 "2 - Subtração \n" + 
                 "3 - Multiplação \n" + 
                 "4 - Divisão \n");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    Console.WriteLine("Primeiro valor: ");
                    int soma1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    int soma2 = int.Parse(Console.ReadLine());

                    int resultado1 = Somar(soma1, soma2);

                    Console.WriteLine(soma1 + "+" + soma2 + ":" + resultado1);

                    Console.WriteLine("Tecle 0 para desligar ou 1 retornar ao inicio");
                    off = int.Parse(Console.ReadLine());

                    break;

                    case 2:
                    Console.WriteLine("Primeiro valor: ");
                    int sub1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    int sub2 = int.Parse(Console.ReadLine());

                    int resultado2 = Subtrair(sub1, sub2);

                    Console.WriteLine(sub1 + "-" + sub2 + ":" + resultado2);

                    Console.WriteLine("Tecle 0 para desligar ou 1 retornar ao inicio");
                    off = int.Parse(Console.ReadLine());

                    break;

                    case 3:
                    Console.WriteLine("Primeiro valor: ");
                    int mult1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo valor: ");
                    int mult2 = int.Parse(Console.ReadLine());

                    int resultado3 = Multiplicar(mult1, mult2);

                    Console.WriteLine(mult1 + "x" + mult2 + ":" + resultado3);

                    Console.WriteLine("Tecle 0 para desligar ou 1 retornar ao inicio");
                    off = int.Parse(Console.ReadLine());

                    break;    


                }

                } while (off == 1);                  
            } 
        }



        public static int Somar(int soma1, int soma2)
        {
            return soma1 + soma2;
        }

        public static int Subtrair(int sub1, int sub2)
        {
            return sub1 - sub2;
        }

        public static int Multiplicar(int mult1, int mult2)
        {
            return mult1 * mult2;
        }

        public static int Dividir(int div1, int div2)
        {
            return div1 / div2;
        }
    }
}
