using Model;

namespace lab1
{
    public partial class RecordForm : Form
    {
        public string name;
        public int age;
        public DateTime date;
        public string cause;
        public int cell;

        public RecordForm()
        {
            InitializeComponent();
            Text = "Новая запись";
        }

        public RecordForm(Record r)
        {
            InitializeComponent();
            Text = "Изменение записи";
            textBox1.Text = r.Name;
            textBox2.Text = r.Age.ToString();
            dateTimePicker1.Value = r.Date;
            textBox3.Text = r.Cause;
            textBox4.Text = r.Cell.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Заполни все поля");
                return;
            }

            if (!int.TryParse(textBox2.Text, out age) || age < 0 || age > 120)
            {
                MessageBox.Show("Возраст должен быть числом от 0 до 120");
                return;
            }
            if (!int.TryParse(textBox4.Text, out cell))
            {
                MessageBox.Show("Камера должна быть числом");
                return;
            }

            name = textBox1.Text.Trim();
            date = dateTimePicker1.Value.Date;
            cause = textBox3.Text.Trim();
            DialogResult = DialogResult.OK;
        }
    }
}
