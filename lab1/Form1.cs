using Model;

namespace lab1
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();

        public Form1()
        {
            InitializeComponent();
        }

        void Fill(List<Record> list)
        {
            dataGridView1.Rows.Clear();
            foreach (Record r in list)
            {
                dataGridView1.Rows.Add(r.Id, r.Name, r.Age, r.Date.ToShortDateString(), r.Cause, r.Cell);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполни все поля");
                return;
            }

            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            DateTime date = dateTimePicker1.Value.Date;
            string cause = textBox3.Text;
            int cell = Convert.ToInt32(textBox4.Text);

            if (logic.Add(name, age, date, cause, cell))
            {
                Fill(logic.GetAll());
                MessageBox.Show("Добавлено");
            }
            else
                MessageBox.Show("Камера занята или нет такой (1-" + logic.cells + ")");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Выбери запись в таблице");
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполни все поля");
                return;
            }

            int id = Convert.ToInt32(textBox5.Text);
            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            DateTime date = dateTimePicker1.Value.Date;
            string cause = textBox3.Text;
            int cell = Convert.ToInt32(textBox4.Text);

            if (logic.Edit(id, name, age, date, cause, cell))
            {
                Fill(logic.GetAll());
                MessageBox.Show("Изменено");
            }
            else
                MessageBox.Show("Не получилось, проверь камеру");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Выбери запись в таблице");
                return;
            }

            if (MessageBox.Show("Точно удалить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                logic.Delete(Convert.ToInt32(textBox5.Text));
                Fill(logic.GetAll());
                textBox5.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // сброс
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Record> res = logic.FindByCause(textBox6.Text);
            Fill(res);
            if (res.Count == 0)
                MessageBox.Show("Ничего не найдено");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            Fill(logic.GetAll());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<int> busy = logic.BusyCells();
            List<int> free = logic.FreeCells();
            label8.Text = "Занято: " + busy.Count + " (" + string.Join(", ", busy) + ")\nСвободно: " + free.Count + " (" + string.Join(", ", free) + ")";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox5.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            textBox3.Text = row.Cells[4].Value.ToString();
            textBox4.Text = row.Cells[5].Value.ToString();
        }
    }
}
