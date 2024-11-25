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
    public partial class Form2 : Form
    {
        private static int numero;
        private string name;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name)
        {
            this.name = name;
            Form2.numero = FormPrincipal.num;
            InitializeComponent();
            this.textBoxNombre.Text = this.name;
            this.textBoxNumero.Text = Convert.ToString(Form2.numero);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Returning");
            this.Close();
        }
    }
}
