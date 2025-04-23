using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDigital
{
    public partial class Form1 : Form
    {
        private string operacion = "";  // Guarda la operación actual
        private double resultado = 0;
        public Form1()
        {
            InitializeComponent();
            Pantalla.ReadOnly = true;  // Evita que el usuario escriba directamente
            Pantalla.TextAlign = HorizontalAlignment.Right;  // Alinea el texto a la derecha
        }
        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;  // Captura el botón presionado
            operacion += btn.Text;        // Agrega el número al string de la operación
            Pantalla.Text = operacion;
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // Evita operadores consecutivos
            if (operacion.Length > 0 && !char.IsDigit(operacion[operacion.Length - 1]))
            {
                return;
            }
            operacion += " " + btn.Text + " ";  // Agrega el operador con espacios
            Pantalla.Text = operacion;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacion.Contains("/ 0"))  // Evita división por cero
                {
                    Pantalla.Text = "Error: División por 0";
                    return;
                }
                string expresion = operacion.Replace("x", "*");  // Reemplaza 'x' por '*'
                resultado = Convert.ToDouble(new DataTable().Compute(expresion, null)); // Evalúa

                Pantalla.Text = resultado.ToString();  // Muestra el resultado
                operacion = resultado.ToString();  // Guarda el resultado para continuar operando
            }
            catch
            {
                Pantalla.Text = "Error";
            }
        }
       
        private void bttnSuma_Click(object sender, EventArgs e)
        {

        }

        private void Pantalla_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bttnBorrar_Click(object sender, EventArgs e)
        {
            operacion = "";
            resultado = 0;
            Pantalla.Text = "";
        }
    }
}
