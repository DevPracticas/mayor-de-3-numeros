namespace winAppMayorTresNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1, num2, num3;

        private void txtNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                num3 = int.Parse(txtNum3.Text);
                clMayorTresNumeros objMayorTresNumeros = new clMayorTresNumeros(num1, num2, num3);
                lblRespuesta.Text = objMayorTresNumeros.mayorTresNumeros().ToString();
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                num2 = int.Parse(txtNum2.Text);
                txtNum3.Focus();
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                num1 = int.Parse(txtNum1.Text);
                txtNum2.Focus();
            }
        }
    }
}