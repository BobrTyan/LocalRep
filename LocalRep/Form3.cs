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

        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked1 = checkBox1.Checked;
            bool isChecked2 = checkBox2.Checked;
            bool isChecked3 = checkBox3.Checked;
            if (isChecked1 == true) s.ball++;
            if (isChecked2 == true) s.ball++;
            if (isChecked3 == true) s.ball++;
            /* if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox1.Checked == false) { s.ball = s.ball + 0; } 
             else if ((checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)) { s.ball = s.ball + 1; }
             else if ((checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false) || (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true) || (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)) { s.ball = s.ball + 2; }
             else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox1.Checked == true) { s.ball = s.ball + 3; }*/
           this.Hide();
            Form4 f = new Form4(s);
            f.ShowDialog();
           
        

        }
    }
}
