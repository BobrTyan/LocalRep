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
    public partial class Form6 : Form
    {   Student s = new Student();
        public Form6(Student student)
        {
            InitializeComponent();
            this.s = student;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
    }
}
