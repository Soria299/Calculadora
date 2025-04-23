using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Asignar el evento KeyPress a ambos TextBox
            txtNum1.KeyPress += new KeyPressEventHandler(txtNum_KeyPress);
            txtNum2.KeyPress += new KeyPressEventHandler(txtNum_KeyPress);

            // Hacer que el campo de resultado sea de solo lectura
            Resultado.ReadOnly = true;
        }
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, punto, coma y teclas de control como backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar el carácter
            }

            // Evitar múltiples puntos o comas
            TextBox textBox = (TextBox)sender;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox.Text.Contains('.') || textBox.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                double num1 = Convert.ToDouble(txtNum1.Text);

                double num2 = Convert.ToDouble(txtNum2.Text);

                double suma = num1 + num2;

                Resultado.Text =  suma.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try

            {
                double num1 = Convert.ToDouble(txtNum1.Text);

                double num2 = Convert.ToDouble(txtNum2.Text);

                double suma = num1 - num2;

                Resultado.Text = suma.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtNum1.Text = "";
            txtNum2.Text = "";
            Resultado.Text = "";

            // Opcional: poner el foco en el primer campo
            txtNum1.Focus();
        } 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
