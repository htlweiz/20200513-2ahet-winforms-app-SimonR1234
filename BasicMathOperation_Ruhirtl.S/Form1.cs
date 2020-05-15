using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperation_Ruhirtl.S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            lblResult.Text = "Ergebnis";
            lblTypeResult.Text = "";
            txtNumber1.Focus();
            txtNumber1.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1, number2, result;

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 + number2;
                lblTypeResult.Text = Convert.ToString(result);
                lblResult.Text = "Summe";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Fehler";
                lblTypeResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            int number1, number2, result;

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 - number2;
                lblTypeResult.Text = Convert.ToString(result);
                lblResult.Text = "Differenz";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Fehler";
                lblTypeResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            int number1, number2, result;

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 * number2;
                lblTypeResult.Text = Convert.ToString(result);
                lblResult.Text = "Produkt";
            }
            catch (Exception ex)
            {
                lblResult.Text = "Fehler";
                lblTypeResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            double number1, number2, result;

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                if (number2 == 0)
                {
                    lblResult.Text = "Fehler";
                    MessageBox.Show("Division durch 0", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = number1 / number2;
                    lblTypeResult.Text = Convert.ToString(result);
                    lblResult.Text = "Quotient";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = "Fehler";
                lblTypeResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }
    }
}
