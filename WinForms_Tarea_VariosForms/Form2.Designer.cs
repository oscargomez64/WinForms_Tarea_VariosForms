namespace WinForms_Tarea_VariosForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo2 = new Label();
            textBoxNombre = new TextBox();
            buttonRegresar = new Button();
            textBoxNumero = new TextBox();
            labelAutor = new Label();
            SuspendLayout();
            // 
            // labelTitulo2
            // 
            labelTitulo2.Anchor = AnchorStyles.Top;
            labelTitulo2.AutoSize = true;
            labelTitulo2.BackColor = Color.Transparent;
            labelTitulo2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo2.ForeColor = SystemColors.ControlLightLight;
            labelTitulo2.Location = new Point(216, 61);
            labelTitulo2.Name = "labelTitulo2";
            labelTitulo2.Size = new Size(141, 28);
            labelTitulo2.TabIndex = 0;
            labelTitulo2.Text = "Form 2 Title";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top;
            textBoxNombre.Enabled = false;
            textBoxNombre.Location = new Point(159, 111);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(255, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Anchor = AnchorStyles.Bottom;
            buttonRegresar.Location = new Point(229, 254);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(114, 40);
            buttonRegresar.TabIndex = 2;
            buttonRegresar.Text = "Back";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Anchor = AnchorStyles.Top;
            textBoxNumero.Enabled = false;
            textBoxNumero.Location = new Point(159, 162);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(255, 23);
            textBoxNumero.TabIndex = 3;
            // 
            // labelAutor
            // 
            labelAutor.Anchor = AnchorStyles.Bottom;
            labelAutor.AutoSize = true;
            labelAutor.BackColor = Color.Transparent;
            labelAutor.ForeColor = SystemColors.ControlLightLight;
            labelAutor.Location = new Point(184, 334);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(204, 15);
            labelAutor.TabIndex = 4;
            labelAutor.Text = "452160 - Oscar Ivan Gomez Ruiz - 3°C";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.fondo2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(573, 358);
            Controls.Add(labelAutor);
            Controls.Add(textBoxNumero);
            Controls.Add(buttonRegresar);
            Controls.Add(textBoxNombre);
            Controls.Add(labelTitulo2);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo2;
        private TextBox textBoxNombre;
        private Button buttonRegresar;
        private TextBox textBoxNumero;
        private Label labelAutor;
    }
}