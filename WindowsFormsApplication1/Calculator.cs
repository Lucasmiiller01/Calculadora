using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculator
    {
        public double sl;
        public string simbolinho;
        public double valor = 0;
        public double valor2 = 0;
        public double total = 0;
        // funcao para fatoriar o valor recursivamente
        private double fatoriar(double valor)
        {
            if (valor.Equals(0))
                return 1;
            return fatoriar(valor - 1) * valor;
        }
        // funcao para fibonacci recursivo
        private double fibo(double valor)
        {
            if (valor.Equals(1) || valor.Equals(2)) return 1;
            return fibo(valor - 1) + fibo(valor - 2);
        }
        // funcao para calcular
        public void calcular()
        {
            // pegar o valor atual
            valor2 = sl;
            // executar as contas no "total"
            switch (simbolinho)
            {
                case "*":
                    total = valor * valor2;
                    break;
                case "/":
                    total = valor / valor2;
                    break;
                case "-":
                    total = valor - valor2;
                    break;
                case "+":
                    total = valor + valor2;
                    break;
                case "Cos":
                    total = Math.Cos(Math.PI * valor / 180);
                    break;
                case "Sen":
                    total = Math.Sin(Math.PI * valor / 180);
                    break;
                case "Tg":
                    total = Math.Tan(Math.PI * valor / 180);
                    break;
                case "√":
                    total = Math.Sqrt(valor);
                    break;
                case "! Re":
                    total = fatoriar(valor);
                    break;
                case "! In":
                    if (valor.Equals(0)) total = 1;
                    else
                    {
                        total = 1;
                        for (double i = valor; i > 0; i--)
                        {
                            total *= i;
                        }
                    }
                    break;
                case "Fi Re":
                    total = fibo(valor);
                    break;
                case "Fi In":
                    if (valor.Equals(0)) total = 0;
                    else
                    {
                        double n = 0;
                        double m = 1; 
                        for (double i = 1; i < valor; i++)
                        {
                            
                            if (valor > 1)
                                total = m + n;
                            n = m;
                            m = total;
                        }
                        if (valor.Equals(1)) total = 1;
                    }
                    break;
                case "^":
                    total = Math.Pow(valor, valor2);
                    break;
                case "Resto":
                    total = Math.IEEERemainder(valor, valor2);
                    break;
                case "%":
                    total = valor / 100 * valor2;
                    break;
            }
        }
    }
}
