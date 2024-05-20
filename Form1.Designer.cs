namespace Uzrasu_knygele
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            button4 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            button5 = new Button();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            button6 = new Button();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBox10 = new TextBox();
            button7 = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button9 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(89, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Vardas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Pavardė";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 108);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Tel. numeris";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 137);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "Adresas";
            // 
            // button1
            // 
            button1.Location = new Point(13, 179);
            button1.Name = "button1";
            button1.Size = new Size(218, 23);
            button1.TabIndex = 8;
            button1.Text = "Prisijungti prie duomenų bazės";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 208);
            button2.Name = "button2";
            button2.Size = new Size(146, 23);
            button2.TabIndex = 9;
            button2.Text = "Įrašyti duomenis";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(255, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(533, 213);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(52, 237);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 11;
            button3.Text = "Rodyti duomenis";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(465, 274);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 23);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 278);
            label5.Name = "label5";
            label5.Size = new Size(172, 15);
            label5.TabIndex = 13;
            label5.Text = "Ieškoti žmogaus pagal pavardę:";
            // 
            // button4
            // 
            button4.Location = new Point(587, 274);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(78, 23);
            button4.TabIndex = 14;
            button4.Text = "Ieškoti";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(465, 304);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(117, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 306);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(195, 15);
            label6.TabIndex = 16;
            label6.Text = "Iveskite norimą žmogaus id numerį:";
            // 
            // button5
            // 
            button5.Location = new Point(586, 304);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(79, 23);
            button5.TabIndex = 17;
            button5.Text = "Trinti";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 334);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(175, 15);
            label7.TabIndex = 18;
            label7.Text = "Įveskite norimą id, norint taisyti:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(465, 334);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(117, 23);
            textBox7.TabIndex = 19;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(464, 361);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(118, 23);
            textBox8.TabIndex = 20;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 358);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 21;
            label8.Text = "Naujas tel. numeris:";
            // 
            // button6
            // 
            button6.Location = new Point(586, 361);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(78, 23);
            button6.TabIndex = 22;
            button6.Text = "Keisti";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 186);
            label9.Location = new Point(34, 433);
            label9.Name = "label9";
            label9.Size = new Size(159, 17);
            label9.TabIndex = 23;
            label9.Text = "Informacijos kodavimas:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(208, 458);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(139, 23);
            textBox9.TabIndex = 24;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 461);
            label10.Name = "label10";
            label10.Size = new Size(169, 15);
            label10.TabIndex = 25;
            label10.Text = "Norima užkoduoti informacija:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(133, 492);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 26;
            label11.Text = "Slaptažodis:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(208, 489);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 27;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // button7
            // 
            button7.Location = new Point(314, 489);
            button7.Name = "button7";
            button7.Size = new Size(102, 23);
            button7.TabIndex = 28;
            button7.Text = "Kodavimas AES";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(690, 433);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(186, 19);
            label12.TabIndex = 30;
            label12.Text = "Informacijos atkodavimas:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(715, 461);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(107, 15);
            label13.TabIndex = 31;
            label13.Text = "uzkoduotas tekstas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(798, 489);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 32;
            label14.Text = "Slaptažodis:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(886, 461);
            textBox11.Margin = new Padding(2);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(106, 23);
            textBox11.TabIndex = 33;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(886, 487);
            textBox12.Margin = new Padding(2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(106, 23);
            textBox12.TabIndex = 34;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // button9
            // 
            button9.Location = new Point(1009, 488);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(78, 20);
            button9.TabIndex = 35;
            button9.Text = "Atkoduoti";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(816, 104);
            button8.Name = "button8";
            button8.Size = new Size(210, 23);
            button8.TabIndex = 36;
            button8.Text = "rodyti uzkoduotus duoemnis";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 536);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(button7);
            Controls.Add(textBox10);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(button6);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBox5;
        private Label label5;
        private Button button4;
        private TextBox textBox6;
        private Label label6;
        private Button button5;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Button button6;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private TextBox textBox10;
        private Button button7;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button button9;
        private Button button8;
    }
}
