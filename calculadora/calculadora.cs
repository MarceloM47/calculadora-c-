namespace calculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(txtNumero1.Text);
            int numero2 = Int32.Parse(txtNumero2.Text);
            int resultado = numero1 + numero2;

            lblResultado.Text = "El resultado es: " + resultado.ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(txtNumero1.Text);
            int numero2 = Int32.Parse(txtNumero2.Text);
            int resultado = numero1 - numero2;

            lblResultado.Text = "El resultado es: " + resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(txtNumero1.Text);
            int numero2 = Int32.Parse(txtNumero2.Text);
            int resultado = numero1 * numero2;

            lblResultado.Text = "El resultado es: " + resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = Int32.Parse(txtNumero1.Text);
            int numero2 = Int32.Parse(txtNumero2.Text);
            int resultado = numero1 / numero2;

            lblResultado.Text = "El resultado es: " + resultado.ToString();
        }
    }
}