using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verificação_divisivel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[4];

            numbers[0] = int.Parse(textBox1.Text);
            numbers[1] = int.Parse(textBox2.Text);
            numbers[2] = int.Parse(textBox3.Text);
            numbers[3] = int.Parse(textBox4.Text);

            string resultado = "Números divisiveis por 2 ou 3: ";

            foreach (int number in numbers)
            {
                if (number % 2 == 0 || number % 3 == 0)
                {
                    resultado+= number + ", ";
                }
            }
            resultado = resultado.TrimEnd(' ', ',');
            lblResultado.Text = resultado;
        }
    }
}
