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
    public partial class Form1 : Form
    { Student student = new Student();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            student.name = textBox1.Text;
            student.ball = 0;
            student.day = DateTime.Today;//текущая дата
            Form2 f = new Form2(student);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6(student);
            f.ShowDialog();
        }
    }
}
