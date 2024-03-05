namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            btResultado.Text = (float.Parse(txtNro1.Text) + float.Parse(txtNro2.Text)).ToString();
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            btResultado.Text = (float.Parse(txtNro1.Text) - float.Parse(txtNro2.Text)).ToString();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            btResultado.Text = (float.Parse(txtNro1.Text) * float.Parse(txtNro2.Text)).ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            btResultado.Text = (float.Parse(txtNro1.Text) / float.Parse(txtNro2.Text)).ToString();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            btResultado.Text = "0";
            txtNro1.Text = "0";
            txtNro2.Text = "0";
        }
    }
}
