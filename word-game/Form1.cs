using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace word_game
{
    public partial class Form1 : Form
    {
        string[] questions =
            {
            "Organs of our body?",
            "Capital of countries?",
            "Popular Turkish dishes?",
            "Phone manufacturer brands?",
            "European countries?"
            };
        int i = 0;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
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
                else if(label1.Text == questions[4])
                {
                    Question5();
                }
            }
        }

        private void Question5()
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
                        score += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question4()
        {
            string path = Path.Combine(Application.StartupPath, "question4.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 &&(textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question3()
        {
            string path = Path.Combine(Application.StartupPath, "question3.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 &&(textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question2()
        {
            string path = Path.Combine(Application.StartupPath, "question2.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 &&(textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question1()
        {
            string path = Path.Combine(Application.StartupPath, "question1.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 &&(textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            button1.Text = "Next";
            progressBar1.Value = 100;
            timer1.Enabled=true;
            listBox1.Items.Clear();
            WriteQuestion();
        }

        private void WriteQuestion()
        {
            if(i == 4)
            {
                button1.Text = "Finish";
            }
            if(i >= 5)
            {
                MessageBox.Show($"Game Over! Score: {score}");
                this.Close();
                i = 0;
            }
            label1.Text = questions[i];
            i++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time();
        }

        private void Time()
        {
            progressBar1.Value -= 5;
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                progressBar1.Value = 100;
            }
        }
    }
}
