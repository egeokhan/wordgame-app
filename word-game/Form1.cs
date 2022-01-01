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
using System.Collections;
using System.Data.SqlClient;

namespace word_game
{
    public partial class Form1 : Form
    {
        string[] lines = new string[1]; 
        string[] questions =
            {
            "Organs of our body?",
            "Capital of countries?",
            "Popular Turkish dishes?",
            "Phone manufacturer brands?",
            "European countries?",
            "C# data types?",
            "Programming languages?",
            "Rap artists?",
            "Genres of music?",
            "Computer equipment brands?"
            };
        int i = 0;
        int score = 0;
        string bestscore;
        int allscore = 0;
        string result;
        Random ques = new Random();
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
                    else if (label1.Text == questions[4])
                    {
                        Question5();
                    }
                    else if(label1.Text == questions[5])
                    {
                        Question6();
                    }
                    else if (label1.Text == questions[6])
                    {
                        Question7();
                    }
                    else if (label1.Text == questions[7])
                    {
                        Question8();
                    }
                    else if (label1.Text == questions[8])
                    {
                        Question9();
                    }
                    else if (label1.Text == questions[9])
                    {
                        Question10();
                    }

            }
        }

        private void Question10()
        {
            string path = Path.Combine(Application.StartupPath, "question10.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                        allscore += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question9()
        {
            string path = Path.Combine(Application.StartupPath, "question9.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                        allscore += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question8()
        {
            string path = Path.Combine(Application.StartupPath, "question8.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                        allscore += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question7()
        {
            string path = Path.Combine(Application.StartupPath, "question7.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                        allscore += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void Question6()
        {
            string path = Path.Combine(Application.StartupPath, "question6.txt");
            string[] answers = File.ReadAllLines(path);
            for (int i = 0; i < answers.Length; i++)
            {
                if (progressBar1.Value != 100 && (textBox1.Text).ToLower() == answers[i].ToLower())
                {
                    if (listBox1.Items.Contains(answers[i]) == false)
                    {
                        listBox1.Items.Add(answers[i]);
                        score += 10;
                        allscore += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
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
                        allscore += 10;
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
                        allscore += 10;
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
                        allscore += 10;
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
                        allscore += 10;
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
                        allscore += 10;
                    }
                }
            }
            label3.Text = score.ToString();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            textBox1.Focus();
            button1.Text = "Next";
            progressBar1.Value = 100;
            timer1.Enabled=true;
            listBox1.Items.Clear();
            WriteQuestion();
            BestScore();
            label3.Text = "0";
        }

        private void BestScore()
        {
            int j = 0;
            while (j < 10)
            {
                j++;
                string path = Path.Combine(Application.StartupPath, "bestscore.txt");
                lines = File.ReadAllLines(path);
                string bestscore = lines[0];
                label5.Text = lines[0];
                try
                {
                    if (Convert.ToInt32(bestscore) < Convert.ToInt32(label3.Text))
                    {
                        bestscore = label3.Text;
                        StreamWriter sw = new StreamWriter(path);
                        sw.Write(bestscore);
                        sw.Close();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void WriteQuestion()
        {
            if(i == questions.Length-1)
            {
                button1.Text = "Finish";
            }
            if(i >= questions.Length)
            {
                if (Convert.ToInt32(label3.Text) > Convert.ToInt32(label5.Text))
                {
                    bestscore = label3.Text;
                    label5.Text = bestscore;
                    label3.Text = "0";
                }
                if(allscore <= 50)
                {
                    result = "You should improve yourself...";
                }
                if(allscore > 50 && allscore <= 100)
                {
                    result = "Nice! but its not enough...";
                }
                if(allscore > 100 && allscore <= 180)
                {
                    result = "Amazing! you are good at this...";
                }
                if(allscore > 180)
                {
                    result = "You're unbelievable! 10/10";
                }
                MessageBox.Show($"Game Over! \nYour Best Score: {bestscore} \nYour Total Score: {allscore} \n{result} ");
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

        private void button3_Click(object sender, EventArgs e)
        {
            ToYellow();
        }

        private void ToYellow()
        {
            this.BackColor = Color.Yellow;

            listBox1.BackColor = Color.Yellow;
            listBox1.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;

            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black; 

            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.Yellow;

            button8.BackColor = Color.Yellow;
            button8.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToBlack();
        }

        private void ToBlack()
        {
            this.BackColor = Color.Black;

            listBox1.BackColor = Color.Black;
            listBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Black;

            button8.BackColor= Color.Black;
            button8.ForeColor= Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToBlue();
        }

        private void ToBlue()
        {
            this.BackColor = Color.Blue;

            listBox1.BackColor = Color.Blue;
            listBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Blue;

            button8.BackColor = Color.Blue;
            button8.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ToRed();
        }

        private void ToRed()
        {
            this.BackColor = Color.Red;

            listBox1.BackColor = Color.Red;
            listBox1.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Red;

            button8.BackColor = Color.Red;
            button8.ForeColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ToGreen();
        }

        private void ToGreen()
        {
            this.BackColor = Color.Green;

            listBox1.BackColor = Color.Green;
            listBox1.ForeColor = Color.White;


            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;

            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Green;

            button8.BackColor = Color.Green;
            button8.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToPurple();
        }

        private void ToPurple()
        {
            this.BackColor = Color.Purple;

            listBox1.BackColor = Color.Purple;
            listBox1.ForeColor = Color.White;


            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            button1.BackColor = Color.Purple;
            button1.ForeColor = Color.White;

            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Purple;

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
                button8.BackColor= colorDialog1.Color;
                textBox1.BackColor= colorDialog1.Color;
                button1.BackColor= colorDialog1.Color;
                listBox1.BackColor= colorDialog1.Color;
                if (listBox1.BackColor == Color.White)
                {

                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    button1.ForeColor = Color.Black;
                    button8.ForeColor = Color.Black;
                    listBox1.ForeColor = Color.Black;
                    textBox1.ForeColor= Color.Black;
                }
            }
        }
    }
}