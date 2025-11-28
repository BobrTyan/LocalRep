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
   
    public partial class Form6 : Form 
    {   
        Student s = new Student();
        int N;
        public Form6(Student student)
        {
            InitializeComponent();
            this.s = student;
            LoadStatistic();
        }
        public void LoadStatistic()
        {
            using (StreamReader reader = new StreamReader("out.txt"))
            {
                N = 0;
                String line;
                line = reader.ReadLine(); /*name*/
                while (line != null)
                {

                    Student resultTest = new Student();
                    
                    resultTest.name = line;
                   
                    line = reader.ReadLine();/*result*/
                    resultTest.ball = resultTest.ball = Convert.ToInt32(line);

                    line = reader.ReadLine();/*date*/
                    resultTest.day = Convert.ToDateTime(line);
                    
                    enter_Table(N, resultTest);
                    N++;
                    line = reader.ReadLine(); /*name*/
                }
            }
        }
        private void enter_Table(int index, Student student)
        {
            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells[0].Value = student.name;
            dataGridView1.Rows[rowIndex].Cells[1].Value = student.ball;
            dataGridView1.Rows[rowIndex].Cells[2].Value = student.day.ToShortDateString();
        }
    }
}
