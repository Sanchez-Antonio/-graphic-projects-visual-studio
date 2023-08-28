namespace Envio_Datos
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
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(493, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 15);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 22;
            label4.Text = "color";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(341, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 15);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 20;
            label3.Text = "domicilio";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 15);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 18;
            label2.Text = "PASSWORD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 16;
            label1.Text = "usuario";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 104);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 26;
            label5.Text = "nacimiento";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 155);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 104);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 24;
            label6.Text = "edad";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(341, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(410, 239);
            dataGridView1.TabIndex = 29;
            // 
            // button1
            // 
            button1.Location = new Point(313, 492);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 30;
            button1.Text = "CARGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 533);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
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
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}