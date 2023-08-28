namespace Envio_Datos
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
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 70);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 10;
            label2.Text = "PASSWORD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 70);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 8;
            label1.Text = "usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 70);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 12;
            label3.Text = "domicilio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(426, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 70);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 14;
            label4.Text = "color";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(611, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(65, 255);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 204);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 18;
            label5.Text = "nacimiento";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(259, 255);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 204);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 16;
            label6.Text = "edad";
            // 
            // button1
            // 
            button1.Location = new Point(520, 255);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1086827;
            pictureBox1.Location = new Point(656, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 460);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox1;
    }
}