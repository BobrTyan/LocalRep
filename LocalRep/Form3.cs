using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalRep
{
    public partial class Form3 : Form
    {
        Student s = new Student();
        int ball;
        public Form3(Student student)
        {
            InitializeComponent();
            this.s = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox1.Checked == false)
            { MessageBox.Show("Вы должны выбрать хотя бы 1 ответ!");}
            if ((checkBox1.Checked == true && checkBox2.Checked == false && checkBox1.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == true && checkBox1.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == false && checkBox1.Checked == true)) { ball++; }
            else if ((checkBox1.Checked == true && checkBox2.Checked == true && checkBox1.Checked == false) || (checkBox1.Checked == true && checkBox2.Checked == false && checkBox1.Checked == true) || (checkBox1.Checked == false && checkBox2.Checked == true && checkBox1.Checked == true)) { ball=ball+2; } 
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox1.Checked == true) { ball = ball + 3; }

        }
    }
}
