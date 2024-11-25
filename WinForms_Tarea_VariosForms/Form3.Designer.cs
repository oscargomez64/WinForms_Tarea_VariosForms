namespace WinForms_Tarea_VariosForms
{
    partial class Form3
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
            labelTitulo3 = new Label();
            buttonRegresar = new Button();
            labelResultado = new Label();
            textBoxResultado = new TextBox();
            labelAutor = new Label();
            SuspendLayout();
            // 
            // labelTitulo3
            // 
            labelTitulo3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTitulo3.AutoSize = true;
            labelTitulo3.BackColor = Color.Transparent;
            labelTitulo3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo3.ForeColor = SystemColors.ControlLightLight;
            labelTitulo3.Location = new Point(398, 25);
            labelTitulo3.Name = "labelTitulo3";
            labelTitulo3.Size = new Size(141, 28);
            labelTitulo3.TabIndex = 0;
            labelTitulo3.Text = "Form 3 Title";
            // 
            // buttonRegresar
            // 
            buttonRegresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRegresar.Location = new Point(464, 181);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(75, 23);
            buttonRegresar.TabIndex = 1;
            buttonRegresar.Text = "Back";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // labelResultado
            // 
            labelResultado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Transparent;
            labelResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelResultado.ForeColor = SystemColors.ControlLightLight;
            labelResultado.Location = new Point(433, 63);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(95, 20);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Your result is:";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxResultado.Enabled = false;
            textBoxResultado.Location = new Point(464, 96);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(64, 23);
            textBoxResultado.TabIndex = 3;
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.BackColor = SystemColors.ControlDarkDark;
            labelAutor.ForeColor = Color.White;
            labelAutor.Location = new Point(12, 334);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(204, 15);
            labelAutor.TabIndex = 4;
            labelAutor.Text = "452160 - Oscar Ivan Gomez Ruiz - 3°C";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(573, 358);
            Controls.Add(labelAutor);
            Controls.Add(textBoxResultado);
            Controls.Add(labelResultado);
            Controls.Add(buttonRegresar);
            Controls.Add(labelTitulo3);
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo3;
        private Button buttonRegresar;
        private Label labelResultado;
        private TextBox textBoxResultado;
        private Label labelAutor;
    }
}