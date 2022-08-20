using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentreportcard
{
    public partial class Reportcard : Form
    {
        public Reportcard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Scorebutton_Click(object sender, EventArgs e)
        {
            int testScore = Int32.Parse (testbox.Text);
            int assignmentScore = Int32.Parse(assignbox.Text);
            int examScore = Int32.Parse(exambox.Text);
            Scorebox.Text = TotalScore (testScore, assignmentScore, examScore).ToString();
        }
        public int TotalScore(int testScore, int AssignmentScore, int ExamScore)
        {
            return (testScore + AssignmentScore + ExamScore);
        }
    }  
        
}
