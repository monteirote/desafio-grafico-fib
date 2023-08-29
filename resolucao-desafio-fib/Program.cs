
class Program
{
    static int fib(int n, ref int contadorChamadas)
    {
        contadorChamadas++;

        if (n <= 1) return 1;

        return fib(n - 1, ref contadorChamadas) + fib(n - 2, ref contadorChamadas);
    }


    static void Main(string[] args)
    {
        Console.Write("Digite o termo máximo que será exibido no gráfico: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetorTermos = new int[n];
        int[] vetorResultados = new int[n];

        Console.WriteLine("Gráfico de Chamadas da Função fib()");

        for (int i = n; i >= 1; i--)
        {
            int contadorChamadas = 0;
            int resultado = fib(i - 1, ref contadorChamadas);

            vetorTermos[i - 1] = i - 1;
            vetorResultados[i - 1] = contadorChamadas;
        }

        int maiorResultado = vetorResultados[vetorResultados.Length - 1];

        String linha = "";
        for (int i = maiorResultado; i >= 1; i--)
        {
            linha = "";
            linha += i.ToString();

            if (i.ToString().Length == 1)
            {
                linha += "  ";
            }
            else if (i.ToString().Length == 2)
            {
                linha += " ";
            }

            linha += "|";

            for (int v = 0; v < vetorResultados.Length; v++)
            {
                if (i <= vetorResultados[v])
                {
                    linha += "*";
                }
                else
                {
                    linha += " ";
                }
                linha += " ";
            }

            Console.WriteLine(linha);
        }

        String baseGrafico = "    ";
        for (int i = 0; i < linha.Length - 4; i++)
        {
            baseGrafico += "-";
        }
        Console.WriteLine(baseGrafico);

        String linhaBase = "    ";
        for (int i = 0; i < vetorTermos.Length; i++)
        {
            linhaBase += (i + 1).ToString() + " ";
        }
        Console.WriteLine(linhaBase);

        Console.ReadKey();
    }
}
