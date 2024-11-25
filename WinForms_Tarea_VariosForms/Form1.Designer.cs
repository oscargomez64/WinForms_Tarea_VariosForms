namespace WinForms_Tarea_VariosForms
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            buttonForm2 = new Button();
            buttonForm3 = new Button();
            textBoxDato = new TextBox();
            buttonSalir = new Button();
            textBoxValue1 = new TextBox();
            textBoxValue2 = new TextBox();
            comboBoxOptions = new ComboBox();
            labelAutor = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.Top;
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Purple;
            labelTitulo.Location = new Point(287, 73);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(121, 28);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Main Title";
            // 
            // buttonForm2
            // 
            buttonForm2.Anchor = AnchorStyles.Bottom;
            buttonForm2.Location = new Point(122, 149);
            buttonForm2.Name = "buttonForm2";
            buttonForm2.Size = new Size(135, 50);
            buttonForm2.TabIndex = 1;
            buttonForm2.Text = "Form2";
            buttonForm2.UseVisualStyleBackColor = true;
            buttonForm2.Click += buttonForm2_Click;
            // 
            // buttonForm3
            // 
            buttonForm3.Anchor = AnchorStyles.Bottom;
            buttonForm3.Location = new Point(437, 149);
            buttonForm3.Name = "buttonForm3";
            buttonForm3.Size = new Size(135, 50);
            buttonForm3.TabIndex = 2;
            buttonForm3.Text = "Form3";
            buttonForm3.UseVisualStyleBackColor = true;
            buttonForm3.Click += buttonForm3_Click;
            // 
            // textBoxDato
            // 
            textBoxDato.Anchor = AnchorStyles.Bottom;
            textBoxDato.Location = new Point(240, 239);
            textBoxDato.Name = "textBoxDato";
            textBoxDato.PlaceholderText = "Insert a name";
            textBoxDato.Size = new Size(214, 23);
            textBoxDato.TabIndex = 4;
            textBoxDato.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalir.Location = new Point(593, 394);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Exit";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // textBoxValue1
            // 
            textBoxValue1.Anchor = AnchorStyles.Bottom;
            textBoxValue1.Location = new Point(297, 300);
            textBoxValue1.Name = "textBoxValue1";
            textBoxValue1.PlaceholderText = "Value 1";
            textBoxValue1.Size = new Size(100, 23);
            textBoxValue1.TabIndex = 6;
            textBoxValue1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxValue2
            // 
            textBoxValue2.Anchor = AnchorStyles.Bottom;
            textBoxValue2.Location = new Point(297, 329);
            textBoxValue2.Name = "textBoxValue2";
            textBoxValue2.PlaceholderText = "Value 2";
            textBoxValue2.Size = new Size(100, 23);
            textBoxValue2.TabIndex = 7;
            textBoxValue2.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxOptions
            // 
            comboBoxOptions.Anchor = AnchorStyles.Bottom;
            comboBoxOptions.FormattingEnabled = true;
            comboBoxOptions.Items.AddRange(new object[] { "Sum", "Subtract", "Multiplication", "Divide" });
            comboBoxOptions.Location = new Point(297, 358);
            comboBoxOptions.Name = "comboBoxOptions";
            comboBoxOptions.Size = new Size(100, 23);
            comboBoxOptions.TabIndex = 8;
            comboBoxOptions.Text = "--Operation--";
            comboBoxOptions.SelectedIndexChanged += comboBoxOptions_SelectedIndexChanged;
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.BackColor = Color.Transparent;
            labelAutor.Location = new Point(12, 9);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(204, 15);
            labelAutor.TabIndex = 9;
            labelAutor.Text = "452160 - Oscar Ivan Gomez Ruiz - 3°C";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(694, 445);
            Controls.Add(labelAutor);
            Controls.Add(comboBoxOptions);
            Controls.Add(textBoxValue2);
            Controls.Add(textBoxValue1);
            Controls.Add(buttonSalir);
            Controls.Add(textBoxDato);
            Controls.Add(buttonForm3);
            Controls.Add(buttonForm2);
            Controls.Add(labelTitulo);
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button buttonForm2;
        private Button buttonForm3;
        private TextBox textBoxDato;
        private Button buttonSalir;
        private TextBox textBoxValue1;
        private TextBox textBoxValue2;
        private ComboBox comboBoxOptions;
        private Label labelAutor;
    }
}
