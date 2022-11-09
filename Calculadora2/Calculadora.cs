using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        double Num1, Num2;

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Double multiplicacion;
            Num1 = Convert.ToDouble(txtPrimer.Text);
            Num2 = Convert.ToDouble(txtSegundo.Text);
            multiplicacion = Num1 * Num2;
            txtResultado.Text = multiplicacion.ToString();
            MessageBox.Show("El resultado de la multiplicacion es: " + multiplicacion, MessageBoxIcon.Information.ToString());
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Double division;
            Num1 = Convert.ToDouble(txtPrimer.Text);
            Num2 = Convert.ToDouble(txtSegundo.Text);
            division = Num1 / Num2;
            txtResultado.Text = division.ToString();
            MessageBox.Show("El resultado de la division es: " + division, MessageBoxIcon.Information.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Double resta;
            Num1 = Convert.ToDouble(txtPrimer.Text);
            Num2 = Convert.ToDouble(txtSegundo.Text);
            resta = Num1 - Num2;
            txtResultado.Text = resta.ToString();
            MessageBox.Show("El resultado de la resta es: " + resta, MessageBoxIcon.Information.ToString());
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Double suma;
            Num1 = Convert.ToDouble(txtPrimer.Text);
            Num2 = Convert.ToDouble(txtSegundo.Text);
            suma = Num1 + Num2;
            txtResultado.Text = suma.ToString();
            MessageBox.Show("El resultado de la suma es: " + suma, MessageBoxIcon.Information.ToString());
        }
    }
}
