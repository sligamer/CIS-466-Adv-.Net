namespace Final_MultiFormProject_Freres
{
    partial class ParameterizedQueryfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParameterizedQueryfrm));
            this.finalProjectDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.finalProjectDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.finalProjectDataDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tutorialSearchtxt = new System.Windows.Forms.TextBox();
            this.tutorialSearchbtn = new System.Windows.Forms.Button();
            this.tutorialsShowAllbtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalProjectDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.multiFormDbDataSet = new Final_MultiFormProject_Freres.MultiFormDbDataSet();
            this.finalProjectDataTableAdapter = new Final_MultiFormProject_Freres.MultiFormDbDataSetTableAdapters.FinalProjectDataTableAdapter();
            this.tableAdapterManager = new Final_MultiFormProject_Freres.MultiFormDbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataBindingNavigator)).BeginInit();
            this.finalProjectDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiFormDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // finalProjectDataBindingNavigator
            // 
            this.finalProjectDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.finalProjectDataBindingNavigator.BindingSource = this.finalProjectDataBindingSource;
            this.finalProjectDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.finalProjectDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.finalProjectDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.finalProjectDataBindingNavigatorSaveItem});
            this.finalProjectDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.finalProjectDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.finalProjectDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.finalProjectDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.finalProjectDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.finalProjectDataBindingNavigator.Name = "finalProjectDataBindingNavigator";
            this.finalProjectDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.finalProjectDataBindingNavigator.Size = new System.Drawing.Size(568, 25);
            this.finalProjectDataBindingNavigator.TabIndex = 0;
            this.finalProjectDataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // finalProjectDataBindingNavigatorSaveItem
            // 
            this.finalProjectDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.finalProjectDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("finalProjectDataBindingNavigatorSaveItem.Image")));
            this.finalProjectDataBindingNavigatorSaveItem.Name = "finalProjectDataBindingNavigatorSaveItem";
            this.finalProjectDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.finalProjectDataBindingNavigatorSaveItem.Text = "Save Data";
            this.finalProjectDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.finalProjectDataBindingNavigatorSaveItem_Click);
            // 
            // finalProjectDataDataGridView
            // 
            this.finalProjectDataDataGridView.AutoGenerateColumns = false;
            this.finalProjectDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalProjectDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.finalProjectDataDataGridView.DataSource = this.finalProjectDataBindingSource;
            this.finalProjectDataDataGridView.Location = new System.Drawing.Point(12, 28);
            this.finalProjectDataDataGridView.Name = "finalProjectDataDataGridView";
            this.finalProjectDataDataGridView.Size = new System.Drawing.Size(543, 220);
            this.finalProjectDataDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tutorialSearchbtn);
            this.groupBox1.Controls.Add(this.tutorialSearchtxt);
            this.groupBox1.Location = new System.Drawing.Point(28, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Tutorials";
            // 
            // tutorialSearchtxt
            // 
            this.tutorialSearchtxt.Location = new System.Drawing.Point(7, 29);
            this.tutorialSearchtxt.Name = "tutorialSearchtxt";
            this.tutorialSearchtxt.Size = new System.Drawing.Size(168, 20);
            this.tutorialSearchtxt.TabIndex = 0;
            // 
            // tutorialSearchbtn
            // 
            this.tutorialSearchbtn.Location = new System.Drawing.Point(7, 56);
            this.tutorialSearchbtn.Name = "tutorialSearchbtn";
            this.tutorialSearchbtn.Size = new System.Drawing.Size(168, 23);
            this.tutorialSearchbtn.TabIndex = 1;
            this.tutorialSearchbtn.Text = "Search";
            this.tutorialSearchbtn.UseVisualStyleBackColor = true;
            this.tutorialSearchbtn.Click += new System.EventHandler(this.tutorialSearchbtn_Click);
            // 
            // tutorialsShowAllbtn
            // 
            this.tutorialsShowAllbtn.Location = new System.Drawing.Point(405, 255);
            this.tutorialsShowAllbtn.Name = "tutorialsShowAllbtn";
            this.tutorialsShowAllbtn.Size = new System.Drawing.Size(150, 86);
            this.tutorialsShowAllbtn.TabIndex = 3;
            this.tutorialsShowAllbtn.Text = "Show All Tutorials";
            this.tutorialsShowAllbtn.UseVisualStyleBackColor = true;
            this.tutorialsShowAllbtn.Click += new System.EventHandler(this.tutorialsShowAllbtn_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TutorialName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TutorialName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TutorialNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "TutorialNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TutorialDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "TutorialDescription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TutorialSteps";
            this.dataGridViewTextBoxColumn5.HeaderText = "TutorialSteps";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TutorialTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "TutorialTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // finalProjectDataBindingSource
            // 
            this.finalProjectDataBindingSource.DataMember = "FinalProjectData";
            this.finalProjectDataBindingSource.DataSource = this.multiFormDbDataSet;
            // 
            // multiFormDbDataSet
            // 
            this.multiFormDbDataSet.DataSetName = "MultiFormDbDataSet";
            this.multiFormDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalProjectDataTableAdapter
            // 
            this.finalProjectDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FinalProjectDataTableAdapter = this.finalProjectDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_MultiFormProject_Freres.MultiFormDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ParameterizedQueryfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 394);
            this.Controls.Add(this.tutorialsShowAllbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.finalProjectDataDataGridView);
            this.Controls.Add(this.finalProjectDataBindingNavigator);
            this.Name = "ParameterizedQueryfrm";
            this.Text = "ParameterizedQueryfrm";
            this.Load += new System.EventHandler(this.ParameterizedQueryfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataBindingNavigator)).EndInit();
            this.finalProjectDataBindingNavigator.ResumeLayout(false);
            this.finalProjectDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiFormDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MultiFormDbDataSet multiFormDbDataSet;
        private System.Windows.Forms.BindingSource finalProjectDataBindingSource;
        private MultiFormDbDataSetTableAdapters.FinalProjectDataTableAdapter finalProjectDataTableAdapter;
        private MultiFormDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator finalProjectDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton finalProjectDataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView finalProjectDataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tutorialSearchbtn;
        private System.Windows.Forms.TextBox tutorialSearchtxt;
        private System.Windows.Forms.Button tutorialsShowAllbtn;
    }
}