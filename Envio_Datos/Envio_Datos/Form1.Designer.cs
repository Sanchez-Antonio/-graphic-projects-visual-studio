namespace Envio_Datos
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            Boton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 126);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 295);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 244);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // Boton
            // 
            Boton.Location = new Point(158, 411);
            Boton.Name = "Boton";
            Boton.Size = new Size(125, 43);
            Boton.TabIndex = 5;
            Boton.Text = "Ingresar";
            Boton.UseVisualStyleBackColor = true;
            Boton.Click += Boton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 647);
            Controls.Add(Boton);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button Boton;
    }
}