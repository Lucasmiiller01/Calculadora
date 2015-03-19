using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculadora : Form
    {
        Calculator calculator = new Calculator();
        public Calculadora()
        {
            InitializeComponent();
        }
        public double negativando;
        public string pegar;
        public bool simbol = false;
        public bool somou = false;
        public bool algo = false;
        public bool batata = false;
        // add caracteres
        private void Add(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            // verificar se tem algum digito escrito na tela
            algo = true;
            // usos da virgula
            if (clicked.Text.Equals(",") && !somou && !simbol)
            {
                if (Result.Text.IndexOf(",") != -1) Result.Text = Result.Text;
                else Result.Text += clicked.Text;
            }
            else if (clicked.Text.Equals(",") || clicked.Text.Equals(",") && simbol)
            {
                Result.Text = "0,";
                somou = false;
                simbol = false;
            }
            // respectivamente: testando se vai colocar o primeiro digito; colocando mais um digito; negando o zero;
            if (simbol && clicked.Text != "," || somou && clicked.Text != ",") { Result.Text = clicked.Text; simbol = false; somou = false; }
            else if (Result.Text != "0" && clicked.Text != ",") Result.Text += clicked.Text;
            else if (clicked.Text != ",") Result.Text = clicked.Text;
        }
        // reiniciar tudo
        private void Reset(object sender, EventArgs e)
        {
            Result.Text = "0";
            calculator.simbolinho = null;
            calculator.valor = 0;
            calculator.valor2 = 0;
            calculator.total = 0;
            simbol = false;
            algo = false;
        }
        // executar a conta
        private void Total(object sender, EventArgs e)
        {
            // testar se existe algum simbolo ativado
            if (calculator.simbolinho != null)
            {
                // pegar o valor escrito
                calculator.sl = Convert.ToDouble(Result.Text);
                // usar a funçao da conta
                calculator.calcular();
                // digitar o total
                Result.Text = calculator.total.ToString();
                // pegar o valor escrito
                calculator.sl = Convert.ToDouble(Result.Text);
                // definir que valor sera o valor escrito
                calculator.valor = calculator.sl;
                // zerador
                calculator.simbolinho = null;
                batata = true;
                somou = true;
            }
        }
        // escolher a conta
        private void Add_simbolos(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            // ver se algo foi digitado
            if (algo) calculator.sl = Convert.ToDouble(Result.Text);
            if (batata && algo) { calculator.valor = calculator.sl; batata = false; }
            // caso aperte um botao de sinal ja tendo definido uma conta anterior
            if (calculator.simbolinho != null)
            {
                // mesmo que no total exceto por colocar o simbolo clicado para a prox conta
                calculator.calcular();
                Result.Text = calculator.total.ToString();
                calculator.sl = Convert.ToDouble(Result.Text);
                calculator.valor = calculator.sl;
                calculator.simbolinho = clicked.Text;
                somou = true;
            }
            // criar o simbolo
            if (calculator.simbolinho == null && algo) calculator.simbolinho = clicked.Text;
            // pegar segundo valor ou primeiro valor
            if (calculator.valor != 0)calculator.valor2 = calculator.sl;
            else calculator.valor = calculator.sl;
            // contas que sao executadas na h que clicadas no simbolo
            if (algo && calculator.simbolinho.Equals("√") || algo && calculator.simbolinho.Equals("Sen") || algo && calculator.simbolinho.Equals("Cos") ||
                algo && calculator.simbolinho.Equals("Tg")) 
            {
                calculator.calcular();
                Result.Text = calculator.total.ToString();
                calculator.sl = Convert.ToDouble(Result.Text);
                calculator.valor = calculator.sl;
                calculator.simbolinho = null;
                somou = true;
            }
            simbol = true;
        }
        // inverter sinal
        private void Negativar(object sender, EventArgs e)
        {
            negativando = Convert.ToDouble(Result.Text) * -1;
            Result.Text = negativando.ToString();
        }
        // deletar caracter final
        private void Backspace(object sender, EventArgs e)
        {
            Result.Text = Result.Text.Remove(Result.Text.Length- 1);
            if (Result.Text == "") Result.Text = "0";
        }
    }
}
