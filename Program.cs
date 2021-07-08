using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--------+");
            Console.WriteLine("|FATORIAL|");
            Console.WriteLine("+--------+");
            
            double numero =0;

            do{
                Console.Write("Digite um número para calcular o fatorial: ");
                numero=Convert.ToDouble(Console.ReadLine());

                if(numero<0){
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Não existe fatorial para números negativos.");
                    Console.BackgroundColor=ConsoleColor.Red;
                    Console.ForegroundColor=ConsoleColor.White;
                    Console.WriteLine("Pressione uma tecla para voltar ao início.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    

                }

            } while (numero<0);
                double cont = numero; 
                double fat=1;

            while(cont>=2)
            {
                fat = fat * cont;
                cont = cont - 1;
            }
            Console.BackgroundColor=ConsoleColor.Green;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine($"O fatorial de {numero} é {fat}");
            Console.ResetColor();
            
        }
    }
}
