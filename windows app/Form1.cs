namespace windows_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add(10);
            listBox1.Items.Add(20);

            listBox1.SelectedItem = listBox1.Items[0];

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tal = listBox1.SelectedItem.ToString();

            int st�rst = int.Parse(tal);
            Random random = new Random();

            int datorn = random.Next(1, st�rst + 1);

            int Spelare = int.Parse(textBox1.Text);

            if (Spelare == datorn)
            {
                label6.Text = "Du fick r�tt bra jobbat!";
                label3.Text = "Datorn fick " + datorn;
            }

            else if (Spelare < datorn)
            {
                label6.Text = "Du Gissade f�r l�gt";
                label3.Text = "Datorns tal var " + datorn;
            }
            else
            {
                label6.Text = "Du gissade f�r h�gt";
                label3.Text = "Datorns tal var " + datorn;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}