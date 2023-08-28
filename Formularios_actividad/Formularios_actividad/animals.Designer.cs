namespace Formularios_actividad
{
    partial class animals
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
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(639, 311);
            button4.Name = "button4";
            button4.Size = new Size(116, 57);
            button4.TabIndex = 51;
            button4.Text = "Registro De Un Familiar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(548, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(639, 229);
            button3.Name = "button3";
            button3.Size = new Size(116, 58);
            button3.TabIndex = 49;
            button3.Text = "Registro De Animal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(317, 292);
            button2.Name = "button2";
            button2.Size = new Size(170, 43);
            button2.TabIndex = 48;
            button2.Text = "mostrar datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(301, 345);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(201, 82);
            textBox6.TabIndex = 47;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 308);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 46;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 45;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 44;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 43;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 42;
            // 
            // button1
            // 
            button1.Location = new Point(431, 105);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 41;
            button1.Text = "cargar foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 315);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 40;
            label6.Text = "sexo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 267);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 39;
            label5.Text = "edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 208);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 38;
            label4.Text = "color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 37;
            label3.Text = "correo de tutor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 36;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 23);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 35;
            label1.Text = "Registro De Mascota";
            label1.Click += label1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            button5.Location = new Point(639, 384);
            button5.Name = "button5";
            button5.Size = new Size(116, 43);
            button5.TabIndex = 52;
            button5.Text = "CERRAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // animals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "animals";
            Text = "animals";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button button5;
    }
}