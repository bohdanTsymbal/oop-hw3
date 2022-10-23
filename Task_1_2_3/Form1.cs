namespace Task_1_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Failed to read your input, you should enter some text here!", "Format error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(input, out int inputNumber))
            {
                MessageBox.Show("You should enter an integer!", "Type error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Ви ввели число {inputNumber}", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}