using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double r1, r2, r3, r4, s;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { textBox2.BackColor = Color.Black; r3 = 1; }
            if (comboBox1.SelectedIndex == 1) { textBox2.BackColor = Color.Brown; r3 = 10; }
            if (comboBox1.SelectedIndex == 2) { textBox2.BackColor = Color.Red; r3 = 100; }
            if (comboBox1.SelectedIndex == 3) { textBox2.BackColor = Color.Orange; r3 = 1000; }
            if (comboBox1.SelectedIndex == 4) { textBox2.BackColor = Color.Yellow; r3 = 10000; }
            if (comboBox1.SelectedIndex == 5) { textBox2.BackColor = Color.Green; r3 = 100000; }
            if (comboBox1.SelectedIndex == 6) { textBox2.BackColor = Color.Blue; r3 = 1000000; }
            if (comboBox1.SelectedIndex == 8) { textBox2.BackColor = Color.Gold; r3 = 0.1; }
            if (comboBox1.SelectedIndex == 9) { textBox2.BackColor = Color.Silver; r3 = 0.01; }








        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) { textBox3.BackColor = Color.Black; r3 = 1; }
            if (comboBox2.SelectedIndex == 1) { textBox3.BackColor = Color.Brown; r3 = 10; }
            if (comboBox2.SelectedIndex == 2) { textBox3.BackColor = Color.Red; r3 = 100; }
            if (comboBox2.SelectedIndex == 3) { textBox3.BackColor = Color.Orange; r3 = 1000; }
            if (comboBox2.SelectedIndex == 4) { textBox3.BackColor = Color.Yellow; r3 = 10000; }
            if (comboBox2.SelectedIndex == 5) { textBox3.BackColor = Color.Green; r3 = 100000; }
            if (comboBox2.SelectedIndex == 6) { textBox3.BackColor = Color.Blue; r3 = 1000000; }
            if (comboBox2.SelectedIndex == 8) { textBox3.BackColor = Color.Gold; r3 = 0.1; }
            if (comboBox2.SelectedIndex == 9) { textBox3.BackColor = Color.Silver; r3 = 0.01; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0) { textBox4.BackColor = Color.Black; }
            if (comboBox3.SelectedIndex == 1) { textBox4.BackColor = Color.Silver; }
            if (comboBox3.SelectedIndex == 2) { textBox4.BackColor = Color.Brown; }
            if (comboBox3.SelectedIndex == 3) { textBox4.BackColor = Color.Red; }
            if (comboBox3.SelectedIndex == 4) { textBox4.BackColor = Color.Orange; }
            if (comboBox3.SelectedIndex == 5) { textBox4.BackColor = Color.Yellow; }
            if (comboBox3.SelectedIndex == 6) { textBox4.BackColor = Color.Blue; }
            if (comboBox3.SelectedIndex == 8) { textBox4.BackColor = Color.Gold; }
            if (comboBox3.SelectedIndex == 9) { textBox4.BackColor = Color.Gray; }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToDouble(comboBox1.SelectedIndex.ToString());
            r2 = Convert.ToDouble(comboBox2.SelectedIndex.ToString());
            r4 = Convert.ToDouble(comboBox3.SelectedIndex.ToString());
            s = ((r1 * 10) + r2) * r3;
            label6.Text = s.ToString();
            if (comboBox1.SelectedIndex == 0) { label7.Text = "+- %5"; }
            if (comboBox1.SelectedIndex == 1) { label7.Text = "+- %10"; }
            if (comboBox1.SelectedIndex == 2) { label7.Text = "+- %1"; }
            if (comboBox1.SelectedIndex == 3) { label7.Text = "+- %2"; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {                                                                                   
            if (comboBox4.SelectedIndex == 0) textBox5.BackColor = Color.Yellow;
            if (comboBox4.SelectedIndex == 1) textBox5.BackColor = Color.Silver;
            if (comboBox4.SelectedIndex == 2) textBox5.BackColor = Color.Red;
            if (comboBox4.SelectedIndex == 3) textBox5.BackColor = Color.Brown;
        }
    }
}
