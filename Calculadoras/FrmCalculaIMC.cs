namespace Calculadoras
{
    public partial class FrmCalculaIMC : Form
    {
        public FrmCalculaIMC()
        {
            InitializeComponent();
        }

        private void lblLimpar_Click(object sender, EventArgs e)
        {
            mskPeso.Clear();
            mskAltura.Clear();
            lblResultado.Text = String.Empty;
            mskPeso.Focus();
        }

        private void CalculaIMC_Load(object sender, EventArgs e)
        {
       
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = double.Parse(mskPeso.Text);
            altura = double.Parse(mskAltura.Text)/100;

            var (resultadoIMC, descricaoIMC) = CalcularIMC(peso, altura);

            lblResultado.Text = $"IMC: {Math.Round(resultadoIMC,2)}\n{descricaoIMC}";
        }

        private (double,string) CalcularIMC (double peso, double altura)
        {
            double imc = peso/(altura*altura);

            var resultado = imc switch 
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobrepeso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (imc, resultado);
        }

        private void mskPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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