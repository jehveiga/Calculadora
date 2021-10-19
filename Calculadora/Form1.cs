using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
            valor2 = Convert.ToUInt16(txtDigiteSegundoNumero.Text);
            resultado = valor1 - valor2;
            lblResultado.Visible = true;
            txtResultado.Visible = true;
            txtResultado.Text = Convert.ToString(resultado);
            MessageBox.Show("O valor da subtração é: " + resultado.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
            valor2 = Convert.ToUInt16(txtDigiteSegundoNumero.Text);
            resultado = valor1 * valor2;
            lblResultado.Visible = true;
            txtResultado.Visible = true;
            txtResultado.Text = Convert.ToString(resultado);
            MessageBox.Show("O valor da multiplicação é " + resultado.ToString());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
            valor2 = Convert.ToUInt16(txtDigiteSegundoNumero.Text);
            resultado = valor1 + valor2;
            lblResultado.Visible = true;
            txtResultado.Visible = true;
            txtResultado.Text = Convert.ToString(resultado);
            MessageBox.Show("O valor da soma é " + resultado.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            valor1 = Convert.ToInt16(txtDigitePrimeiroNumero.Text);
            valor2 = Convert.ToUInt16(txtDigiteSegundoNumero.Text);
            lblResultado.Visible = true;
            txtResultado.Visible = true;
            // Passo 1 - Verificar se o valor2 é diferente de zero (0)
            // Caso a condição for verdadeira irá acessar o cálculo
            // e o resultado será apresentado na caixa de texto
            if (valor2 != 0)
            {
                resultado = valor1 / valor2;
                txtResultado.Text = Convert.ToString(resultado);
                MessageBox.Show("O valor da divisão é: " + resultado.ToString());
            }
            else
            {
                // Passo2 - Caso o valor2 for igual a zero (0)
                // deverá ser exibida a mensagem "não foi possível efetuar  a divisão"
                // por zero(0)
                MessageBox.Show("Não é possível efetuar a divisão por zero(0)");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Close();
            //varíavel do tipo MessageBoxResult

            var result = MessageBox.Show("Deseja realmente fechar essa aplicação", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.No)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDigitePrimeiroNumero.Text = String.Empty;
            txtDigiteSegundoNumero.Text = String.Empty;
            txtResultado.Text = String.Empty;
            lblResultado.Visible = false;
            txtResultado.Visible = false;
            txtDigitePrimeiroNumero.Focus();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDigitePrimeiroNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDigiteSegundoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
