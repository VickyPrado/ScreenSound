// 4. Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

/*
public class Calculadora
{
    public class double Calcular(double numero1, double numero2, char operacao)
    {
        double resultado = 0;

        switch (operacao) 
        {
            case '+':
                resultado = Somar(numero1, numero2);
                break;
            case "-":
                resultado = Subtrair(numero1, numero2);
                break;
            case "*":
                resultado = Multiplicar(numero1, numero2);
                break;
            case "/":
                resultado = Dividir(numero1, numero2);
                break;
            case "^":
                resultado = Potencia(numero1, numero2);
                break;
            case "r":
                resultado = RaizQuadrada(numero1, numero2);
                break;
            default:
                Console.WriteLine("Operação inválida!");
        }
        return resultado;

        private static double Somar(double a, double b) 
        {
            return a + b;
        }

        private static double Subtrair(double a, double b)
        {
            return a - b;
        }

        private static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        private static double Dividir(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Erro. Divisão por zero.");
                return 0;
            }
        }

        private static double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        private static double RaizQuadrada(double a)
        {
            return Math.Sqrt(a);
        }
}
*/