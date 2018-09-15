using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        DateTime t1;
        DateTime t2;
        TimeSpan dif;
        TimeSpan num;

        string hourenter;
        int ent1, ent2;
        int ex1, ex2;
        double x;
        string y;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hourenter = textBox1.Text;


        }
        string hourexit;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            hourexit = textBox2.Text;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            

                if (textBox1.Text == "" || hourenter.Length != 4)
                {
                    MessageBox.Show("הקש שעה בארבעה ספרות", "message");
                reset1();
                }
                else
                {
                try
                {
                    ent1 = int.Parse(hourenter.Substring(0, 2));
                    ent2 = int.Parse(hourenter.Substring(2, 2));
                    textBox1.Text = hourenter.Insert(2, ":");
 
                        t1 = DateTime.Parse(textBox1.Text);

                    }
                    catch
                    {
                        MessageBox.Show("  השעה אינה נכונה, הקש שעה בארבעה ספרות", "message");
                    reset1();
                    }
                }
            
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "" || hourexit.Length != 4)
            {
                MessageBox.Show("הקש שעה בארבעה ספרות", "message");
                reset2();
            }
            else
            {
                try
                {
                    ex1 = int.Parse(hourexit.Substring(0, 2));
                    ex2 = int.Parse(hourexit.Substring(2, 2));
                    textBox2.Text = hourexit.Insert(2, ":");

                    t2 = DateTime.Parse(textBox2.Text);

                }
                catch
                {
                    MessageBox.Show("  השעה אינה נכונה, הקש שעה בארבעה ספרות", "message");
                    reset2();
                }
            }

        }
        void reset1()
        {
            textBox1.Clear();
            textBox1.Focus();
        }
        void reset2()
        {
            textBox2.Clear();
            textBox2.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            num = new TimeSpan(0);
            x = 0;
            s = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        double s;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                x = num.TotalHours;
                y = x.ToString();
                listBox1.Items.Add(y.Substring(0, 5) + "  :סך הכל שעות ");
                if (pri != 0)
                {
                    s =Math.Round(pri * x, 2);
                    listBox1.Items.Add(s.ToString() + " :הסכום שהתקבל");
                }
            }
            catch
            {
                MessageBox.Show("ההקש שעות כניסה ויציאה ועל לחצן הוסף קודם ורק אחר כך על לחצן חשב");
                textBox1.Focus();
            }
        }

        TimeSpan[] sum = new TimeSpan[40];
        int i = 0;
        double pri;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pri = double.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1 > t2)
            {
                MessageBox.Show("!שעת הכניסה גדולה משעת היציאה  ");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                if (hourenter == "" || hourexit == "")
                {
                    MessageBox.Show("לא הוקשה שעה ");
                    textBox1.Focus();
                }
                else
                {
                    dif = t2.Subtract(t1);
                    string d = dif.ToString().Substring(0, 5);
                    sum[i] = dif;
                    num = num.Add(sum[i]);
                    i++;

                    listBox1.Items.Add(d + " כניסה " + textBox1.Text + "  יציאה " + textBox2.Text + " סך ");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }

       
    }
}
