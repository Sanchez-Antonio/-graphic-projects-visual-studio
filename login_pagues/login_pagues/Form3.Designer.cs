﻿namespace login_pagues
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox6 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(158, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(484, 184);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(299, 136);
            button1.Name = "button1";
            button1.Size = new Size(180, 27);
            button1.TabIndex = 1;
            button1.Text = "INGRESAR DATOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(645, 82);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(666, 46);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 22;
            label5.Text = "contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 46);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 21;
            label4.Text = "domicilio";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(477, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 46);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 19;
            label3.Text = "sexo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 18;
            label2.Text = "edad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 46);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 17;
            label1.Text = "nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(327, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox6;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}