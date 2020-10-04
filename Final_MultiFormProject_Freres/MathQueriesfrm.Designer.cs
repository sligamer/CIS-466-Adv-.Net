namespace Final_MultiFormProject_Freres
{
    partial class MathQueriesfrm
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
            this.tutorialCountBtn = new System.Windows.Forms.Button();
            this.tutorialMinBtn = new System.Windows.Forms.Button();
            this.tutorialMaxbtn = new System.Windows.Forms.Button();
            this.finalProjectDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.multiFormDbDataSet = new Final_MultiFormProject_Freres.MultiFormDbDataSet();
            this.finalProjectDataTableAdapter = new Final_MultiFormProject_Freres.MultiFormDbDataSetTableAdapters.FinalProjectDataTableAdapter();
            this.tableAdapterManager = new Final_MultiFormProject_Freres.MultiFormDbDataSetTableAdapters.TableAdapterManager();
            this.tutorialCounttxt = new System.Windows.Forms.TextBox();
            this.tutorialMinStepstxt = new System.Windows.Forms.TextBox();
            this.tutorialMaxStepstxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.finalProjectDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiFormDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialCountBtn
            // 
            this.tutorialCountBtn.Location = new System.Drawing.Point(15, 4);
            this.tutorialCountBtn.Name = "tutorialCountBtn";
            this.tutorialCountBtn.Size = new System.Drawing.Size(111, 43);
            this.tutorialCountBtn.TabIndex = 2;
            this.tutorialCountBtn.Text = "Get Tutorial Count";
            this.tutorialCountBtn.UseVisualStyleBackColor = true;
            this.tutorialCountBtn.Click += new System.EventHandler(this.tutorialCountBtn_Click);
            // 
            // tutorialMinBtn
            // 
            this.tutorialMinBtn.Location = new System.Drawing.Point(132, 4);
            this.tutorialMinBtn.Name = "tutorialMinBtn";
            this.tutorialMinBtn.Size = new System.Drawing.Size(111, 43);
            this.tutorialMinBtn.TabIndex = 3;
            this.tutorialMinBtn.Text = "Get Tutorial Min Steps";
            this.tutorialMinBtn.UseVisualStyleBackColor = true;
            this.tutorialMinBtn.Click += new System.EventHandler(this.tutorialMinBtn_Click);
            // 
            // tutorialMaxbtn
            // 
            this.tutorialMaxbtn.Location = new System.Drawing.Point(249, 4);
            this.tutorialMaxbtn.Name = "tutorialMaxbtn";
            this.tutorialMaxbtn.Size = new System.Drawing.Size(111, 43);
            this.tutorialMaxbtn.TabIndex = 4;
            this.tutorialMaxbtn.Text = "Get Tutorial Max Steps";
            this.tutorialMaxbtn.UseVisualStyleBackColor = true;
            this.tutorialMaxbtn.Click += new System.EventHandler(this.tutorialMaxbtn_Click);
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
            // tutorialCounttxt
            // 
            this.tutorialCounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialCounttxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tutorialCounttxt.Location = new System.Drawing.Point(15, 53);
            this.tutorialCounttxt.Name = "tutorialCounttxt";
            this.tutorialCounttxt.ReadOnly = true;
            this.tutorialCounttxt.Size = new System.Drawing.Size(111, 20);
            this.tutorialCounttxt.TabIndex = 5;
            this.tutorialCounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tutorialMinStepstxt
            // 
            this.tutorialMinStepstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialMinStepstxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tutorialMinStepstxt.Location = new System.Drawing.Point(132, 53);
            this.tutorialMinStepstxt.Name = "tutorialMinStepstxt";
            this.tutorialMinStepstxt.ReadOnly = true;
            this.tutorialMinStepstxt.Size = new System.Drawing.Size(111, 20);
            this.tutorialMinStepstxt.TabIndex = 6;
            this.tutorialMinStepstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tutorialMaxStepstxt
            // 
            this.tutorialMaxStepstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialMaxStepstxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tutorialMaxStepstxt.Location = new System.Drawing.Point(249, 53);
            this.tutorialMaxStepstxt.Name = "tutorialMaxStepstxt";
            this.tutorialMaxStepstxt.ReadOnly = true;
            this.tutorialMaxStepstxt.Size = new System.Drawing.Size(111, 20);
            this.tutorialMaxStepstxt.TabIndex = 7;
            this.tutorialMaxStepstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MathQueriesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 85);
            this.Controls.Add(this.tutorialMaxStepstxt);
            this.Controls.Add(this.tutorialMinStepstxt);
            this.Controls.Add(this.tutorialCounttxt);
            this.Controls.Add(this.tutorialMaxbtn);
            this.Controls.Add(this.tutorialMinBtn);
            this.Controls.Add(this.tutorialCountBtn);
            this.Name = "MathQueriesfrm";
            this.Text = "FormOne";
            this.Load += new System.EventHandler(this.MathQueriesfrm_Load);
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
        private System.Windows.Forms.Button tutorialCountBtn;
        private System.Windows.Forms.Button tutorialMinBtn;
        private System.Windows.Forms.Button tutorialMaxbtn;
        private System.Windows.Forms.TextBox tutorialCounttxt;
        private System.Windows.Forms.TextBox tutorialMinStepstxt;
        private System.Windows.Forms.TextBox tutorialMaxStepstxt;
    }
}