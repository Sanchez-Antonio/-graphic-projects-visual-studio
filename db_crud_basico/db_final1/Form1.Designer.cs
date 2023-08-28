namespace db_final1
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            DELETE = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(448, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(237, 146);
            dataGridView1.TabIndex = 21;
            // 
            // button2
            // 
            button2.Location = new Point(214, 179);
            button2.Name = "button2";
            button2.Size = new Size(100, 62);
            button2.TabIndex = 20;
            button2.Text = "mostrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(564, 44);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 19;
            label4.Text = "puesto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(540, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 44);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 17;
            label3.Text = "id";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(373, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 44);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 15;
            label2.Text = "salario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(40, 179);
            button1.Name = "button1";
            button1.Size = new Size(100, 62);
            button1.TabIndex = 11;
            button1.Text = "insertar datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(40, 258);
            button3.Name = "button3";
            button3.Size = new Size(100, 62);
            button3.TabIndex = 22;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(214, 258);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(100, 62);
            DELETE.TabIndex = 24;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += DELETE_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(50, 387);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(90, 23);
            textBox5.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 358);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 26;
            label5.Text = "Actualizar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(DELETE);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button DELETE;
        private TextBox textBox5;
        private Label label5;
    }
}