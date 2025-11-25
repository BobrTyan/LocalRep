using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalRep
{
    public partial class Form5 : Form
    {
        Student s = new Student();
        public Form5(Student student)
        {
            InitializeComponent();
            this.s = student;
            label1.Text = $"{s.name}, набрал(а)";
            label2.Text = Convert.ToString(s.ball);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("out.txt", true))
            {
                //запись в файл
                writer.WriteLine(s.name);
                writer.WriteLine(Convert.ToString(s.ball));
                writer.WriteLine(Convert.ToString(s.day));
                writer.WriteLine();
                writer.Close();
            }
            Application.Exit(); // закрыть приложение и все окна выгрузить
        }
    }
}
