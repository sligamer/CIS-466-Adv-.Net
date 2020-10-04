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
    public partial class MathQueriesfrm : Form
    {
        public MathQueriesfrm()
        {
            InitializeComponent();
        }

        private void finalProjectDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finalProjectDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.multiFormDbDataSet);

        }

        private void MathQueriesfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'multiFormDbDataSet.FinalProjectData' table. You can move, or remove it, as needed.
            this.finalProjectDataTableAdapter.Fill(this.multiFormDbDataSet.FinalProjectData);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.finalProjectDataTableAdapter.Fill(this.multiFormDbDataSet.FinalProjectData);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tutorialCountBtn_Click(object sender, EventArgs e)
        {
            // declare variables
            int count;

            // get the count of tutorials
            count = (int)this.finalProjectDataTableAdapter.FinalProjectCount();

            // fill readonly text box with count
            this.tutorialCounttxt.Text = count.ToString();

        }

        private void tutorialMinBtn_Click(object sender, EventArgs e)
        {
            // declare variables
            int min;

            // get the count of tutorials
            min = (int)this.finalProjectDataTableAdapter.FinalProjectMin();

            // fill readonly text box with min number of steps
            this.tutorialMinStepstxt.Text = min.ToString();
        }

        private void tutorialMaxbtn_Click(object sender, EventArgs e)
        {
            // declare variables
            int max;

            // get the count of tutorials
            max = (int)this.finalProjectDataTableAdapter.FinalProjectMax();

            // fill readonly text box with max number of steps
            this.tutorialMaxStepstxt.Text = max.ToString();
        }
    }
}
