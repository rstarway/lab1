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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // button1
            //
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(197, 29);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // button2
            //
            button2.Location = new Point(12, 48);
            button2.Name = "button2";
            button2.Size = new Size(197, 29);
            button2.TabIndex = 1;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            //
            // button3
            //
            button3.Location = new Point(12, 82);
            button3.Name = "button3";
            button3.Size = new Size(197, 29);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new Point(12, 131);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 3;
            label7.Text = "Поиск по причине";
            //
            // textBox6
            //
            textBox6.Location = new Point(12, 149);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(197, 23);
            textBox6.TabIndex = 4;
            //
            // button5
            //
            button5.Location = new Point(12, 177);
            button5.Name = "button5";
            button5.Size = new Size(97, 27);
            button5.TabIndex = 5;
            button5.Text = "Найти";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            //
            // button6
            //
            button6.Location = new Point(113, 177);
            button6.Name = "button6";
            button6.Size = new Size(96, 27);
            button6.TabIndex = 6;
            button6.Text = "Показать все";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            //
            // button7
            //
            button7.Location = new Point(12, 223);
            button7.Name = "button7";
            button7.Size = new Size(197, 29);
            button7.TabIndex = 7;
            button7.Text = "Камеры";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(12, 259);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 8;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(227, 14);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(609, 494);
            dataGridView1.TabIndex = 9;
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Учет поступлений в морг";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
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
