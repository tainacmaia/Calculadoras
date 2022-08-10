using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculaIMC_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmCalculaIMC();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnCalculadoraSimples_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmCalculadoraSimples();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
