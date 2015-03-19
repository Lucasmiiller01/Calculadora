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
