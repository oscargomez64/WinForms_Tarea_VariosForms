namespace WinForms_Tarea_VariosForms
{
    public partial class FormPrincipal : Form
    {
        public static int num = 21;
        public static int indice = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            string dato;
            dato = this.textBoxDato.Text;

            Form2 f2 = new Form2(dato);
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void buttonForm3_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            valor1 = Convert.ToDouble(this.textBoxValue1.Text);
            valor2 = Convert.ToDouble(this.textBoxValue2.Text);

            Form3 f3 = new Form3(valor1, valor2);
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void comboBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboBoxOptions.SelectedIndex;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
