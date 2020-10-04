using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_MultiFormProject_Freres
{
    public partial class Startupfrm : Form
    {
        public Startupfrm()
        {
            InitializeComponent();
        } 

        private void openMathFrmBtn_Click(object sender, EventArgs e)
        {
            // open the math queries frm
            MathQueriesfrm frm = new MathQueriesfrm();
            frm.ShowDialog();

        }

        private void openParmaFrmBtn_Click(object sender, EventArgs e)
        {
            // open the parameterized queries frm
            ParameterizedQueryfrm frm = new ParameterizedQueryfrm();
            frm.ShowDialog();

        }
    }
}
