namespace CalculoNumerosPrimos.Domain.Entities
{
    public class NumerosPrimos
    {
        public int NumeroEntrada { get; private set; }

        public string Divisores { get; private set; }

        public string Primos { get; private set; }

        public NumerosPrimos(int numero)
        {
            NumeroEntrada = numero;
        }

        public NumerosPrimos CalcularNumeroPrimos(int numEntrada)
        {
            var numerosPrimos = new NumerosPrimos(numEntrada);
            int divisores = 0;

            for (int numero = 1; numero <= numEntrada; numero++)
            {
                if ((numEntrada % numero) == 0)
                {
                    Divisores += string.Join(" ", $" {numero} ");

                    for (int j = 1; j <= numero; j++)
                    {
                        if ((numero % j) == 0)
                            divisores++;
                    }

                    if (divisores == 2 || numero == 1)
                        Primos += string.Join(" ", $" {numero} ");

                    divisores = 0;
                }
            }

            return numerosPrimos;
        }
    }
}
