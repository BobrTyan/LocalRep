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
       
        public Form3(Student student)
        {
            InitializeComponent();
            this.s = student;
        }
        public void proverka()
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox1.Checked == false)
            { s.ball = s.ball + 0; }
            if ((checkBox1.Checked == true && checkBox2.Checked == false && checkBox1.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == true && checkBox1.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == false && checkBox1.Checked == true)) { s.ball++; }
            else if ((checkBox1.Checked == true && checkBox2.Checked == true && checkBox1.Checked == false) || (checkBox1.Checked == true && checkBox2.Checked == false && checkBox1.Checked == true) || (checkBox1.Checked == false && checkBox2.Checked == true && checkBox1.Checked == true)) { s.ball = s.ball + 2; }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox1.Checked == true) { s.ball = s.ball + 3; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(s);
            f.ShowDialog();

        }
    }
}
