namespace maior_de_3_nmrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);
            if (numero1 > numero2)
                {
                    txtresultado.Text = ($"O maior numero é:{numero1}");
                }
                else
            {
                txtresultado.Text = ($"O maior numero é: {numero2}");
            }
        }
    }
}