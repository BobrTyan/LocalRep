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

        }
    }
}
