using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Tarea_VariosForms
{
    public partial class Form3 : Form
    {
        public static int indice;
        private double valor1, valor2;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(double v1, double v2)
        {
            this.valor1 = v1;
            this.valor2 = v2;
            Form3.indice = FormPrincipal.indice;
            InitializeComponent();

            switch(Form3.indice)
            {
                case 0:
                    this.textBoxResultado.Text = Convert.ToString(v1 + v2);
                    break;
                case 1:
                    this.textBoxResultado.Text = Convert.ToString(v1 - v2);
                    break;
                case 2:
                    this.textBoxResultado.Text = Convert.ToString(v1 * v2);
                    break;
                case 3:
                    this.textBoxResultado.Text = Convert.ToString(v1 / v2);
                    break;
                default:
                    this.textBoxResultado.Text = "?";
                    break;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Returning to Main Form");
            this.Close();
        }
    }
}
