namespace lab1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            textBox6 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            //
            // textBox1
            //
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 1;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Возраст";
            //
            // textBox2
            //
            textBox2.Location = new Point(12, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 3;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата поступления";
            //
            // dateTimePicker1
            //
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 23);
            dateTimePicker1.TabIndex = 5;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 6;
            label4.Text = "Причина смерти";
            //
            // textBox3
            //
            textBox3.Location = new Point(12, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 23);
            textBox3.TabIndex = 7;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(12, 203);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Камера";
            //
            // textBox4
            //
            textBox4.Location = new Point(12, 221);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(88, 23);
            textBox4.TabIndex = 9;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(119, 203);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 10;
            label6.Text = "id";
            //
            // textBox5
            //
            textBox5.Location = new Point(119, 221);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(90, 23);
            textBox5.TabIndex = 11;
            //
            // button1
            //
            button1.Location = new Point(12, 258);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // button2
            //
            button2.Location = new Point(113, 258);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 13;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            //
            // button3
            //
            button3.Location = new Point(12, 292);
            button3.Name = "button3";
            button3.Size = new Size(97, 29);
            button3.TabIndex = 14;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            //
            // button4
            //
            button4.Location = new Point(113, 292);
            button4.Name = "button4";
            button4.Size = new Size(96, 29);
            button4.TabIndex = 15;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new Point(12, 339);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 16;
            label7.Text = "Поиск по причине";
            //
            // textBox6
            //
            textBox6.Location = new Point(12, 357);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(197, 23);
            textBox6.TabIndex = 17;
            //
            // button5
            //
            button5.Location = new Point(12, 385);
            button5.Name = "button5";
            button5.Size = new Size(97, 27);
            button5.TabIndex = 18;
            button5.Text = "Найти";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            //
            // button6
            //
            button6.Location = new Point(113, 385);
            button6.Name = "button6";
            button6.Size = new Size(96, 27);
            button6.TabIndex = 19;
            button6.Text = "Показать все";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            //
            // button7
            //
            button7.Location = new Point(12, 429);
            button7.Name = "button7";
            button7.Size = new Size(197, 29);
            button7.TabIndex = 20;
            button7.Text = "Камеры";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(12, 465);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 21;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(227, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(609, 494);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            //
            // Column1
            //
            Column1.HeaderText = "id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 40;
            //
            // Column2
            //
            Column2.HeaderText = "ФИО";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 170;
            //
            // Column3
            //
            Column3.HeaderText = "Возраст";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 65;
            //
            // Column4
            //
            Column4.HeaderText = "Дата";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 85;
            //
            // Column5
            //
            Column5.HeaderText = "Причина";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 170;
            //
            // Column6
            //
            Column6.HeaderText = "Камера";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 60;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 521);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Учет поступлений в морг";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private TextBox textBox6;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
