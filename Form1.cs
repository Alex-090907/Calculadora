using System.Globalization;
namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        String operacion = "";
        bool acabaDeCalcular = false;
        double memoria = 0;
        bool mrcPresionado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (acabaDeCalcular)
            {
                txtPantalla.Text = "0";
                acabaDeCalcular = false;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = boton.Text;
            }
            else
            {
                txtPantalla.Text += boton.Text;
            }

            mrcPresionado = false;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (acabaDeCalcular)
            {
                txtPantalla.Text = "0";
                acabaDeCalcular = false;
            }

            // NUEVO
            if (txtPantalla.Text == "-")
            {
                txtPantalla.Text = "-0.";
                return;
            }

            if (!txtPantalla.Text.Contains("."))
            {
                txtPantalla.Text += ".";
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (boton.Text == "-" && txtPantalla.Text == "0")
            {
                txtPantalla.Text = "-";
                acabaDeCalcular = false; // NUEVO
                return;
            }

            if (txtPantalla.Text == "-")
            {
                return;
            }

            primerNumero = double.Parse(txtPantalla.Text, CultureInfo.InvariantCulture);
            operacion = boton.Text;
            txtPantalla.Text = "0";
            mrcPresionado = false;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "-")
            {
                return;
            }

            double segundoNumero = double.Parse(txtPantalla.Text, CultureInfo.InvariantCulture);
            double resultado = segundoNumero;

            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = primerNumero / segundoNumero;
                    break;
            }
            txtPantalla.Text = resultado.ToString(CultureInfo.InvariantCulture);
            acabaDeCalcular = true;
            mrcPresionado = false;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            primerNumero = 0;
            operacion = "";
            acabaDeCalcular = false; // NUEVO
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length > 1)
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
            }
            else
            {
                txtPantalla.Text = "0";
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "-")
            {
                return;
            }

            double numero = double.Parse(txtPantalla.Text, CultureInfo.InvariantCulture);
            txtPantalla.Text = (numero / 100).ToString(CultureInfo.InvariantCulture);
            acabaDeCalcular = true;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "-")
            {
                return;
            }

            double numero = double.Parse(txtPantalla.Text, CultureInfo.InvariantCulture);

            if (numero >= 0)
            {
                txtPantalla.Text = Math.Sqrt(numero).ToString(CultureInfo.InvariantCulture);
                acabaDeCalcular = true;
            }
            else
            {
                MessageBox.Show("No se puede sacar raíz de un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMmas_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "-")
            {
                return;
            }
            double numero = double.Parse(txtPantalla.Text, CultureInfo.InvariantCulture);
            memoria += numero;
            acabaDeCalcular = true;
            mrcPresionado = false;
        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "-")
            {
                return;
            }
            double numero = double.Parse(txtPantalla.Text, CultureInfo.InvariantCulture);
            memoria -= numero;
            acabaDeCalcular = true;
            mrcPresionado = false;
        }

        private void btnMRC_Click(object sender, EventArgs e)
        {
            if (mrcPresionado)
            {
                memoria = 0;
                txtPantalla.Text = "0";
                mrcPresionado = false;
            }
            else
            {
                txtPantalla.Text = memoria.ToString(CultureInfo.InvariantCulture);
                mrcPresionado = true;
            }
            acabaDeCalcular = true;
        }
    }
}