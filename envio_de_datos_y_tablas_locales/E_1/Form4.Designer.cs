﻿namespace E_1
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(359, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(345, 231);
            dataGridView1.TabIndex = 58;
            // 
            // button1
            // 
            button1.Location = new Point(21, 221);
            button1.Name = "button1";
            button1.Size = new Size(85, 43);
            button1.TabIndex = 57;
            button1.Text = "Agregar A Tabla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(14, 183);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 165);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 55;
            label7.Text = "cotizacion";
            label7.Click += label7_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(695, 84);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(721, 54);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 53;
            label6.Text = "direccion";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(554, 84);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(580, 54);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 51;
            label5.Text = "correo electronico";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(431, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 54);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 49;
            label4.Text = "domicilio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(297, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 54);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 47;
            label3.Text = "telefono";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 54);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 45;
            label2.Text = "edad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 54);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 43;
            label1.Text = "nombre";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}