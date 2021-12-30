using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_player
{
    public partial class Form1 : Form
    {
        string[] questions =
            {
            "Organs of our body?",
            "Capital of countries?",
            "C# data types?",
            "Programming languages?",
            "European countries?",
            };
        int score1 = 0;
        int score2 = 0;
        int meter = 0;
        int i = 0;
        Random ques = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meter++;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            button1.Text = "Next";
            progressBar1.Value = 100;
            timer1.Enabled = true;
            listBox1.Items.Clear();
            WriteQuestion(meter);
        }

        private void WriteQuestion(int meter)
        {
            if (meter < questions.Length)
            {
                label1.Text = questions[i];
                i++;
            }
            if(meter == questions.Length - 1)
            {
                button1.Text = "Finish";
            }
            else if (meter >= questions.Length)
            {
                if (score1 > score2)
                {
                    MessageBox.Show("Game Over! Player1 won!");
                }
                else if (score2 > score1)
                {
                    MessageBox.Show("Game Over! Player2 won!");
                }
                else if(score1 == score2)
                {
                    MessageBox.Show("Game Over! Draw!");
                }
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox2.Focus();
                progressBar1.Value = 95;
                if (label1.Text == questions[0])
                {
                    Question1();
                }
                else if (label1.Text == questions[1])
                {
                    Question2();
                }
                else if (label1.Text == questions[2])
                {
                    Question3();
                }
                else if (label1.Text == questions[3])
                {
                    Question4();
                }
                else if (label1.Text == questions[4])
                {
                    Question5();
                }
                textBox1.Text = "";
                label5.Text = score1.ToString();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.ReadOnly = true;
                textBox1.ReadOnly = false;
                textBox1.Focus();
                progressBar1.Value = 95;
                if (label1.Text == questions[0])
                {
                    Question1();
                }
                else if (label1.Text == questions[1])
                {
                    Question2();
                }
                else if (label1.Text == questions[2])
                {
                    Question3();
                }
                else if (label1.Text == questions[3])
                {
                    Question4();
                }
                else if (label1.Text == questions[4])
                {
                    Question5();
                }
                textBox2.Text = "";
                label10.Text = score2.ToString();
            }
        }

        private void Question5()
        {
            if (listBox1.Items.Count != 10)
            {
                string path = Path.Combine(Application.StartupPath, "question5.txt");
                string[] answers = File.ReadAllLines(path);
                for (int i = 0; i < answers.Length; i++)
                {
                    if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score1 += 10;
                        }
                    }
                    else if (progressBar1.Value != 100 && (textBox2.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score2 += 10;
                        }
                    }
                }
            }
            else if (listBox1.Items.Count == 10)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
            }
        }

        private void Question4()
        {
            if (listBox1.Items.Count != 10)
            {
                string path = Path.Combine(Application.StartupPath, "question4.txt");
                string[] answers = File.ReadAllLines(path);
                for (int i = 0; i < answers.Length; i++)
                {
                    if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score1 += 10;
                        }
                    }
                    else if (progressBar1.Value != 100 && (textBox2.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score2 += 10;
                        }
                    }
                }
            }
            else if (listBox1.Items.Count == 10)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
            }
        }

        private void Question3()
        {
            if (listBox1.Items.Count != 10)
            {
                string path = Path.Combine(Application.StartupPath, "question3.txt");
                string[] answers = File.ReadAllLines(path);
                for (int i = 0; i < answers.Length; i++)
                {
                    if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score1 += 10;
                        }
                    }
                    else if (progressBar1.Value != 100 && (textBox2.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score2 += 10;
                        }
                    }
                }
            }
            else if (listBox1.Items.Count == 10)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
            }
        }

        private void Question2()
        {
            if (listBox1.Items.Count != 10)
            {
                string path = Path.Combine(Application.StartupPath, "question2.txt");
                string[] answers = File.ReadAllLines(path);
                for (int i = 0; i < answers.Length; i++)
                {
                    if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score1 += 10;
                        }
                    }
                    else if (progressBar1.Value != 100 && (textBox2.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score2 += 10;
                        }
                    }
                }
            }
            else if (listBox1.Items.Count == 10)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
            }
        }

        private void Question1()
        {
            if (listBox1.Items.Count != 10)
            {
                string path = Path.Combine(Application.StartupPath, "question1.txt");
                string[] answers = File.ReadAllLines(path);
                for (int i = 0; i < answers.Length; i++)
                {
                    if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(answers[i]);
                            score1 += 10;
                        }
                    }
                    else if (progressBar1.Value != 100 && (textBox2.Text).ToLower() == answers[i].ToLower())
                    {
                        if (listBox1.Items.Contains(answers[i]) == false)
                        {
                            listBox1.Items.Add(String.Format(answers[i]));
                            score2 += 10;
                        }
                    }
                }
            }
            else if(listBox1.Items.Count == 10)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 5;
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                progressBar1.Value = 100;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;

            listBox1.BackColor = Color.Yellow;
            listBox1.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;

            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;

            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.Yellow;
            textBox2.ForeColor = Color.Black;
            textBox2.BackColor = Color.Yellow;

            button8.BackColor = Color.Yellow;
            button8.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            listBox1.BackColor = Color.Black;
            listBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;

            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Black;
            textBox2.ForeColor = Color.White;
            textBox2.BackColor = Color.Black;

            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

            listBox1.BackColor = Color.Blue;
            listBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;

            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Blue;
            textBox2.ForeColor = Color.White;
            textBox2.BackColor = Color.Blue;

            button8.BackColor = Color.Blue;
            button8.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

            listBox1.BackColor = Color.Red;
            listBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;

            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Red;
            textBox2.ForeColor = Color.White;
            textBox2.BackColor = Color.Red;

            button8.BackColor = Color.Red;
            button8.ForeColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

            listBox1.BackColor = Color.Green;
            listBox1.ForeColor = Color.White;


            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;

            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Green;
            textBox2.ForeColor = Color.White;
            textBox2.BackColor = Color.Green;

            button8.BackColor = Color.Green;
            button8.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;

            listBox1.BackColor = Color.Purple;
            listBox1.ForeColor = Color.White;


            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;

            button1.BackColor = Color.Purple;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Purple;
            textBox2.ForeColor = Color.White;
            textBox2.BackColor = Color.Purple;

            button8.BackColor = Color.Purple;
            button8.ForeColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult color = new DialogResult();
            color = colorDialog1.ShowDialog();
            if (color == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                button8.BackColor = colorDialog1.Color;
                textBox1.BackColor = colorDialog1.Color;
                textBox2.BackColor = colorDialog1.Color;
                button1.BackColor = colorDialog1.Color;
                listBox1.BackColor = colorDialog1.Color;
                if (listBox1.BackColor == Color.White)
                {

                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    button1.ForeColor = Color.Black;
                    button8.ForeColor = Color.Black;
                    listBox1.ForeColor = Color.Black;
                    textBox1.ForeColor = Color.Black;
                }
            }
        }
    }
}
