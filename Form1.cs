using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string FatherName= textBox4.Text;
            string MotherName = textBox3.Text;
            string Gender = string.Empty;
            string age = comboBox1.SelectedItem.ToString();
            string Country = comboBox2.SelectedItem.ToString();
            string mobile = maskedTextBox1.Text;
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
           else if (radioButton2.Checked)
            {
                Gender = radioButton2.Text;
            }
           else if (radioButton3.Checked)
            {
                Gender = radioButton3.Text;
            }
            string hobbies=string.Empty;
            if (checkBox1.Checked)
            {
                hobbies = hobbies +checkBox1.Text+"";
            }
           else if (checkBox2.Checked)
            {
                hobbies = hobbies+ checkBox2.Text+"";
            }
            else if (checkBox3.Checked)
            {
                hobbies = hobbies + checkBox3.Text+"";
            }
            else if (checkBox4.Checked)
            {
                hobbies = hobbies + checkBox4.Text+"";
            }
            dataGridView1.Rows.Add(Name, FatherName,MotherName, Gender, age, Country, mobile);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 18; i <=25; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(comboBox2.Text);
            comboBox2.Text = string.Empty;
        }
    }
}
