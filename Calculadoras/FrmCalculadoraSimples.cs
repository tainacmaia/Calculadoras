using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class FrmCalculadoraSimples : Form
    {
        bool limpar = true;
        bool teveResultado = true;
        char[] operadores = { '+', '-', '*', '/' };
        public FrmCalculadoraSimples()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbResultado.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "1";
            teveResultado = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "2";
            teveResultado = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "3";
            teveResultado = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "4";
            teveResultado = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "5";
            teveResultado = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "6";
            teveResultado = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "7";
            teveResultado = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "8";
            teveResultado = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "9";
            teveResultado = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ChecarLimpeza();
            txbResultado.Text += "0";
            teveResultado = false;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (operadores.Any(x => txbResultado.Text.Contains(x)) ||
                txbResultado.Text == "")
            {
                if (txbResultado.Text.Contains('-') &&
                txbResultado.Text.StartsWith('-') &&
                (txbResultado.Text.Count(x => txbResultado.Text.Contains(x)) <= 2))
                {
                    txbResultado.Text += "+";
                }
            }
            else
            {
                txbResultado.Text += "+";
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operadores.Any(x => txbResultado.Text.Contains(x)))
            {
                if (txbResultado.Text.Contains('-') &&
                txbResultado.Text.StartsWith('-') &&
                (txbResultado.Text.Count(f => f == '-') < 2))
                {
                    txbResultado.Text += "-";
                }
            }
            else
            {
                txbResultado.Text += "-";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (operadores.Any(x => txbResultado.Text.Contains(x)) ||
                txbResultado.Text == "")
            {
                if (txbResultado.Text.Contains('-') &&
                txbResultado.Text.StartsWith('-') &&
                (txbResultado.Text.Count(x => txbResultado.Text.Contains(x)) <= 2))
                {
                    txbResultado.Text += "*";
                }
            }
            else
            {
                txbResultado.Text += "*";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (operadores.Any(x => txbResultado.Text.Contains(x)) ||
                txbResultado.Text == "")
            {
                if (txbResultado.Text.Contains('-') &&
                txbResultado.Text.StartsWith('-') &&
                (txbResultado.Text.Count(x => txbResultado.Text.Contains(x)) <= 2))
                {
                    txbResultado.Text += "/";
                }
            }
            else
            {
                txbResultado.Text += "/";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (operadores.Any(x => txbResultado.Text.EndsWith(x)))
            {
            }
            else
            {
                DataTable Calc = new DataTable();
                var resultado = Calc.Compute(txbResultado.Text, "");
                if (resultado.ToString().EndsWith('0') && resultado.ToString().Contains(','))//&& só tiver zero depois da vírgula)
                {
                    if (resultado.ToString().EndsWith('0'))
                    {
                        resultado = resultado.ToString().TrimEnd('0');
                    }
                    if (resultado.ToString().EndsWith(','))
                    {
                        resultado = resultado.ToString().TrimEnd(',');
                    }
                    txbResultado.Text = resultado.ToString().Replace(',', '.');
                }
                else
                {
                    txbResultado.Text = resultado.ToString().Replace(',', '.');
                }
                limpar = true;
                teveResultado = true;
            }
        }

        private void ChecarLimpeza()
        {
            if (limpar && teveResultado && !operadores.Any(x => txbResultado.Text.EndsWith(x)))
            { txbResultado.Clear(); limpar = false; }
        }
        private void txbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
