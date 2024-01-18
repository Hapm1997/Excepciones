using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                r = a / b;
                lblResultado.Text = a + " / " + b + " = " + r;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ingrese el formato correcto");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error no reconocido... Intente más tarde");
            }
            
        }
    }
}
