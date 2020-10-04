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
    public partial class ParameterizedQueryfrm : Form
    {
        public ParameterizedQueryfrm()
        {
            InitializeComponent();
        }

        private void finalProjectDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.finalProjectDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.multiFormDbDataSet);

        }

        private void ParameterizedQueryfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'multiFormDbDataSet.FinalProjectData' table. You can move, or remove it, as needed.
            //this.finalProjectDataTableAdapter.Fill(this.multiFormDbDataSet.FinalProjectData);

        }

        private void tutorialSearchbtn_Click(object sender, EventArgs e)
        {
            this.finalProjectDataTableAdapter.FinalProjectSearch(this.multiFormDbDataSet.FinalProjectData, this.tutorialSearchtxt.Text);
        }

        private void tutorialsShowAllbtn_Click(object sender, EventArgs e)
        {
            this.finalProjectDataTableAdapter.Fill(this.multiFormDbDataSet.FinalProjectData);
        }
    }
}
