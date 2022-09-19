

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("        Cálculo de Fatorial");

            Console.WriteLine();
            Console.WriteLine("  Insira um número natural:");

            var valorInserido = Console.ReadLine();
            int valor = Int32.Parse(valorInserido);
            Program program = new Program();

            Console.WriteLine();
            Console.WriteLine("  O fatorial de " + valor + " é: " + program.CalculoFatorial(valor));

            Console.WriteLine();
            Console.ReadKey();
        }

        public int CalculoFatorial(int valor)
        {
            if (valor >= 0 && valor < 2)
            {
                return 1;
            }

            int total = 1;
            for (int i = valor; i > 1; i--)
            {
                total = total * i;
            }

            return total;
        }
    }


}