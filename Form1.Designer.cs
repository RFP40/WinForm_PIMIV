namespace PIM_IV
{
    partial class Root
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Root));
            label1 = new Label();
            btnEnviar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(598, 32);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO E CONSULTA DE USUÁRIOS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEnviar
            // 
            btnEnviar.ForeColor = Color.Black;
            btnEnviar.Location = new Point(361, 327);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(87, 41);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Cadastrar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Insira seu nome";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(323, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Insira seu email";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Selecione uma opção!", "Administrador", "Professor", "Estudante", "Secretaria", "Tesouraria", "Manutenção", "Coordenação" });
            comboBox1.Location = new Point(323, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 4;
            // 
            // Root
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnEnviar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Root";
            Text = "Pim IV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEnviar;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}
