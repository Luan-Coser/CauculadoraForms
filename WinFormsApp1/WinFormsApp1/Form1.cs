namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCauc_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(txtN1.Text);
            decimal numero2 = Convert.ToDecimal(txtN2.Text);
            decimal resultado = 0;
            Calculadora calculadora = new Calculadora(numero1, numero2);

            if (chkSoma.Checked)
            {
                resultado = calculadora.Somar();
                ListaCalculo.Items.Add(numero1 + " + " + numero2 +" = "+ resultado);

            }
            else if (chkSubtracao.Checked)
            {
                resultado = calculadora.Subitrair();
                ListaCalculo.Items.Add(numero1 + " - " + numero2 + " = " + resultado);

            }
            else if (chkDivisao.Checked)
            {
                resultado = calculadora.Dividir();
                ListaCalculo.Items.Add(numero1 + " / " + numero2 + " = " + resultado);

            }
            else if (chkMult.Checked)
            {
                resultado = calculadora.Multiplicar();
                ListaCalculo.Items.Add(numero1 + " * " + numero2 + " = "  + resultado);
            }else
            {
                ListaCalculo.Items.Add("Erro, nenhuma operação foi escolhida");
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
        }
    }
}
