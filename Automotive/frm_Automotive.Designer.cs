namespace Automotive
{
    partial class frm_Automotive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Automotive));
            this.grpBox_oilLube = new System.Windows.Forms.GroupBox();
            this.chkBox_lubeJob = new System.Windows.Forms.CheckBox();
            this.chkBox_oilChange = new System.Windows.Forms.CheckBox();
            this.grpBox_flushes = new System.Windows.Forms.GroupBox();
            this.chkBox_transmissionFlush = new System.Windows.Forms.CheckBox();
            this.chkBox_radiatorFlush = new System.Windows.Forms.CheckBox();
            this.grpBox_misc = new System.Windows.Forms.GroupBox();
            this.chkBox_tireRotation = new System.Windows.Forms.CheckBox();
            this.chkBox_replaceMuffler = new System.Windows.Forms.CheckBox();
            this.chkBox_inspection = new System.Windows.Forms.CheckBox();
            this.grpBox_partsLabor = new System.Windows.Forms.GroupBox();
            this.lbl_laborInput = new System.Windows.Forms.Label();
            this.txtBox_laborInput = new System.Windows.Forms.TextBox();
            this.lbl_partsInput = new System.Windows.Forms.Label();
            this.txtBox_partsInput = new System.Windows.Forms.TextBox();
            this.grpBox_Summary = new System.Windows.Forms.GroupBox();
            this.lbl_totalFeesSummaryOut = new System.Windows.Forms.Label();
            this.lbl_taxSummaryOut = new System.Windows.Forms.Label();
            this.lbl_partsSummaryOut = new System.Windows.Forms.Label();
            this.lbl_serviceLaborSummaryOut = new System.Windows.Forms.Label();
            this.lbl_totalFeesSummary = new System.Windows.Forms.Label();
            this.lbl_taxSummary = new System.Windows.Forms.Label();
            this.lbl_partsSummary = new System.Windows.Forms.Label();
            this.lbl_laborSummary = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.partsValidationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.laborValidationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_isPartsLaborValidTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpBox_oilLube.SuspendLayout();
            this.grpBox_flushes.SuspendLayout();
            this.grpBox_misc.SuspendLayout();
            this.grpBox_partsLabor.SuspendLayout();
            this.grpBox_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_oilLube
            // 
            this.grpBox_oilLube.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBox_oilLube.Controls.Add(this.chkBox_lubeJob);
            this.grpBox_oilLube.Controls.Add(this.chkBox_oilChange);
            this.grpBox_oilLube.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBox_oilLube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_oilLube.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grpBox_oilLube.Location = new System.Drawing.Point(12, 12);
            this.grpBox_oilLube.Name = "grpBox_oilLube";
            this.grpBox_oilLube.Size = new System.Drawing.Size(178, 100);
            this.grpBox_oilLube.TabIndex = 1;
            this.grpBox_oilLube.TabStop = false;
            this.grpBox_oilLube.Text = "Oil and Lube";
            // 
            // chkBox_lubeJob
            // 
            this.chkBox_lubeJob.AutoSize = true;
            this.chkBox_lubeJob.Location = new System.Drawing.Point(7, 43);
            this.chkBox_lubeJob.Name = "chkBox_lubeJob";
            this.chkBox_lubeJob.Size = new System.Drawing.Size(109, 17);
            this.chkBox_lubeJob.TabIndex = 1;
            this.chkBox_lubeJob.Text = "Lube job ($18.00)";
            this.chkBox_lubeJob.UseVisualStyleBackColor = true;
            // 
            // chkBox_oilChange
            // 
            this.chkBox_oilChange.AutoSize = true;
            this.chkBox_oilChange.Location = new System.Drawing.Point(7, 20);
            this.chkBox_oilChange.Name = "chkBox_oilChange";
            this.chkBox_oilChange.Size = new System.Drawing.Size(120, 17);
            this.chkBox_oilChange.TabIndex = 0;
            this.chkBox_oilChange.Text = "Oil Change ($26.00)";
            this.chkBox_oilChange.UseVisualStyleBackColor = true;
            // 
            // grpBox_flushes
            // 
            this.grpBox_flushes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBox_flushes.Controls.Add(this.chkBox_transmissionFlush);
            this.grpBox_flushes.Controls.Add(this.chkBox_radiatorFlush);
            this.grpBox_flushes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBox_flushes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grpBox_flushes.Location = new System.Drawing.Point(195, 12);
            this.grpBox_flushes.Name = "grpBox_flushes";
            this.grpBox_flushes.Size = new System.Drawing.Size(178, 100);
            this.grpBox_flushes.TabIndex = 2;
            this.grpBox_flushes.TabStop = false;
            this.grpBox_flushes.Text = "Flushes";
            // 
            // chkBox_transmissionFlush
            // 
            this.chkBox_transmissionFlush.AutoSize = true;
            this.chkBox_transmissionFlush.Location = new System.Drawing.Point(6, 43);
            this.chkBox_transmissionFlush.Name = "chkBox_transmissionFlush";
            this.chkBox_transmissionFlush.Size = new System.Drawing.Size(157, 17);
            this.chkBox_transmissionFlush.TabIndex = 3;
            this.chkBox_transmissionFlush.Text = "Transmission Flush ($80.00)";
            this.chkBox_transmissionFlush.UseVisualStyleBackColor = true;
            // 
            // chkBox_radiatorFlush
            // 
            this.chkBox_radiatorFlush.AutoSize = true;
            this.chkBox_radiatorFlush.Location = new System.Drawing.Point(6, 20);
            this.chkBox_radiatorFlush.Name = "chkBox_radiatorFlush";
            this.chkBox_radiatorFlush.Size = new System.Drawing.Size(136, 17);
            this.chkBox_radiatorFlush.TabIndex = 2;
            this.chkBox_radiatorFlush.Text = "Radiator Flush ($30.00)";
            this.chkBox_radiatorFlush.UseVisualStyleBackColor = true;
            // 
            // grpBox_misc
            // 
            this.grpBox_misc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBox_misc.Controls.Add(this.chkBox_tireRotation);
            this.grpBox_misc.Controls.Add(this.chkBox_replaceMuffler);
            this.grpBox_misc.Controls.Add(this.chkBox_inspection);
            this.grpBox_misc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBox_misc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grpBox_misc.Location = new System.Drawing.Point(12, 119);
            this.grpBox_misc.Name = "grpBox_misc";
            this.grpBox_misc.Size = new System.Drawing.Size(178, 100);
            this.grpBox_misc.TabIndex = 2;
            this.grpBox_misc.TabStop = false;
            this.grpBox_misc.Text = "Misc";
            // 
            // chkBox_tireRotation
            // 
            this.chkBox_tireRotation.AutoSize = true;
            this.chkBox_tireRotation.Location = new System.Drawing.Point(6, 65);
            this.chkBox_tireRotation.Name = "chkBox_tireRotation";
            this.chkBox_tireRotation.Size = new System.Drawing.Size(129, 17);
            this.chkBox_tireRotation.TabIndex = 6;
            this.chkBox_tireRotation.Text = "Tire Rotation ($20.00)";
            this.chkBox_tireRotation.UseVisualStyleBackColor = true;
            // 
            // chkBox_replaceMuffler
            // 
            this.chkBox_replaceMuffler.AutoSize = true;
            this.chkBox_replaceMuffler.Location = new System.Drawing.Point(6, 42);
            this.chkBox_replaceMuffler.Name = "chkBox_replaceMuffler";
            this.chkBox_replaceMuffler.Size = new System.Drawing.Size(149, 17);
            this.chkBox_replaceMuffler.TabIndex = 5;
            this.chkBox_replaceMuffler.Text = "Replace Muffler ($100.00)";
            this.chkBox_replaceMuffler.UseVisualStyleBackColor = true;
            // 
            // chkBox_inspection
            // 
            this.chkBox_inspection.AutoSize = true;
            this.chkBox_inspection.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkBox_inspection.Location = new System.Drawing.Point(6, 19);
            this.chkBox_inspection.Name = "chkBox_inspection";
            this.chkBox_inspection.Size = new System.Drawing.Size(117, 17);
            this.chkBox_inspection.TabIndex = 4;
            this.chkBox_inspection.Text = "Inspection ($15.00)";
            this.chkBox_inspection.UseVisualStyleBackColor = false;
            // 
            // grpBox_partsLabor
            // 
            this.grpBox_partsLabor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBox_partsLabor.Controls.Add(this.lbl_laborInput);
            this.grpBox_partsLabor.Controls.Add(this.txtBox_laborInput);
            this.grpBox_partsLabor.Controls.Add(this.lbl_partsInput);
            this.grpBox_partsLabor.Controls.Add(this.txtBox_partsInput);
            this.grpBox_partsLabor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBox_partsLabor.Location = new System.Drawing.Point(195, 119);
            this.grpBox_partsLabor.Name = "grpBox_partsLabor";
            this.grpBox_partsLabor.Size = new System.Drawing.Size(178, 100);
            this.grpBox_partsLabor.TabIndex = 3;
            this.grpBox_partsLabor.TabStop = false;
            this.grpBox_partsLabor.Text = "Parts and Labor";
            // 
            // lbl_laborInput
            // 
            this.lbl_laborInput.AutoSize = true;
            this.lbl_laborInput.Location = new System.Drawing.Point(20, 58);
            this.lbl_laborInput.Name = "lbl_laborInput";
            this.lbl_laborInput.Size = new System.Drawing.Size(49, 13);
            this.lbl_laborInput.TabIndex = 3;
            this.lbl_laborInput.Text = "Labor ($)";
            // 
            // txtBox_laborInput
            // 
            this.txtBox_laborInput.Location = new System.Drawing.Point(75, 55);
            this.txtBox_laborInput.Name = "txtBox_laborInput";
            this.txtBox_laborInput.Size = new System.Drawing.Size(64, 20);
            this.txtBox_laborInput.TabIndex = 2;
            this.txtBox_laborInput.TextChanged += new System.EventHandler(this.txtBox_laborInput_TextChanged);
            this.txtBox_laborInput.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_laborInput_Validating);
            this.txtBox_laborInput.Validated += new System.EventHandler(this.txtBox_laborInput_Validated);
            // 
            // lbl_partsInput
            // 
            this.lbl_partsInput.AutoSize = true;
            this.lbl_partsInput.Location = new System.Drawing.Point(38, 29);
            this.lbl_partsInput.Name = "lbl_partsInput";
            this.lbl_partsInput.Size = new System.Drawing.Size(31, 13);
            this.lbl_partsInput.TabIndex = 1;
            this.lbl_partsInput.Text = "Parts";
            // 
            // txtBox_partsInput
            // 
            this.laborValidationProvider.SetError(this.txtBox_partsInput, "Labor requires a none negative number.");
            this.partsValidationProvider.SetError(this.txtBox_partsInput, "Parts requires a none negative number.");
            this.txtBox_partsInput.Location = new System.Drawing.Point(75, 26);
            this.txtBox_partsInput.Name = "txtBox_partsInput";
            this.txtBox_partsInput.Size = new System.Drawing.Size(64, 20);
            this.txtBox_partsInput.TabIndex = 0;
            this.txtBox_partsInput.TextChanged += new System.EventHandler(this.txtBox_partsInput_TextChanged);
            this.txtBox_partsInput.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_partsInput_Validating);
            this.txtBox_partsInput.Validated += new System.EventHandler(this.txtBox_partsInput_Validated);
            // 
            // grpBox_Summary
            // 
            this.grpBox_Summary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBox_Summary.Controls.Add(this.lbl_totalFeesSummaryOut);
            this.grpBox_Summary.Controls.Add(this.lbl_taxSummaryOut);
            this.grpBox_Summary.Controls.Add(this.lbl_partsSummaryOut);
            this.grpBox_Summary.Controls.Add(this.lbl_serviceLaborSummaryOut);
            this.grpBox_Summary.Controls.Add(this.lbl_totalFeesSummary);
            this.grpBox_Summary.Controls.Add(this.lbl_taxSummary);
            this.grpBox_Summary.Controls.Add(this.lbl_partsSummary);
            this.grpBox_Summary.Controls.Add(this.lbl_laborSummary);
            this.grpBox_Summary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBox_Summary.Location = new System.Drawing.Point(12, 230);
            this.grpBox_Summary.Name = "grpBox_Summary";
            this.grpBox_Summary.Size = new System.Drawing.Size(361, 148);
            this.grpBox_Summary.TabIndex = 4;
            this.grpBox_Summary.TabStop = false;
            this.grpBox_Summary.Text = "Summary";
            // 
            // lbl_totalFeesSummaryOut
            // 
            this.lbl_totalFeesSummaryOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_totalFeesSummaryOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_totalFeesSummaryOut.Location = new System.Drawing.Point(106, 109);
            this.lbl_totalFeesSummaryOut.Name = "lbl_totalFeesSummaryOut";
            this.lbl_totalFeesSummaryOut.Size = new System.Drawing.Size(119, 24);
            this.lbl_totalFeesSummaryOut.TabIndex = 13;
            this.lbl_totalFeesSummaryOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_taxSummaryOut
            // 
            this.lbl_taxSummaryOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_taxSummaryOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_taxSummaryOut.Location = new System.Drawing.Point(106, 78);
            this.lbl_taxSummaryOut.Name = "lbl_taxSummaryOut";
            this.lbl_taxSummaryOut.Size = new System.Drawing.Size(119, 24);
            this.lbl_taxSummaryOut.TabIndex = 12;
            this.lbl_taxSummaryOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_partsSummaryOut
            // 
            this.lbl_partsSummaryOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_partsSummaryOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_partsSummaryOut.Location = new System.Drawing.Point(106, 45);
            this.lbl_partsSummaryOut.Name = "lbl_partsSummaryOut";
            this.lbl_partsSummaryOut.Size = new System.Drawing.Size(119, 24);
            this.lbl_partsSummaryOut.TabIndex = 11;
            this.lbl_partsSummaryOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_serviceLaborSummaryOut
            // 
            this.lbl_serviceLaborSummaryOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_serviceLaborSummaryOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_serviceLaborSummaryOut.Location = new System.Drawing.Point(106, 14);
            this.lbl_serviceLaborSummaryOut.Name = "lbl_serviceLaborSummaryOut";
            this.lbl_serviceLaborSummaryOut.Size = new System.Drawing.Size(119, 24);
            this.lbl_serviceLaborSummaryOut.TabIndex = 10;
            this.lbl_serviceLaborSummaryOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totalFeesSummary
            // 
            this.lbl_totalFeesSummary.AutoSize = true;
            this.lbl_totalFeesSummary.Location = new System.Drawing.Point(43, 119);
            this.lbl_totalFeesSummary.Name = "lbl_totalFeesSummary";
            this.lbl_totalFeesSummary.Size = new System.Drawing.Size(57, 13);
            this.lbl_totalFeesSummary.TabIndex = 5;
            this.lbl_totalFeesSummary.Text = "Total Fees";
            // 
            // lbl_taxSummary
            // 
            this.lbl_taxSummary.AutoSize = true;
            this.lbl_taxSummary.Location = new System.Drawing.Point(28, 87);
            this.lbl_taxSummary.Name = "lbl_taxSummary";
            this.lbl_taxSummary.Size = new System.Drawing.Size(72, 13);
            this.lbl_taxSummary.TabIndex = 4;
            this.lbl_taxSummary.Text = "Tax (on parts)";
            // 
            // lbl_partsSummary
            // 
            this.lbl_partsSummary.AutoSize = true;
            this.lbl_partsSummary.Location = new System.Drawing.Point(69, 52);
            this.lbl_partsSummary.Name = "lbl_partsSummary";
            this.lbl_partsSummary.Size = new System.Drawing.Size(31, 13);
            this.lbl_partsSummary.TabIndex = 3;
            this.lbl_partsSummary.Text = "Parts";
            // 
            // lbl_laborSummary
            // 
            this.lbl_laborSummary.AutoSize = true;
            this.lbl_laborSummary.Location = new System.Drawing.Point(6, 20);
            this.lbl_laborSummary.Name = "lbl_laborSummary";
            this.lbl_laborSummary.Size = new System.Drawing.Size(94, 13);
            this.lbl_laborSummary.TabIndex = 2;
            this.lbl_laborSummary.Text = "Service and Labor";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Calculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Calculate.Location = new System.Drawing.Point(37, 399);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(91, 36);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Clear.Location = new System.Drawing.Point(146, 399);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(91, 36);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Exit.Location = new System.Drawing.Point(267, 399);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(91, 36);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // partsValidationProvider
            // 
            this.partsValidationProvider.ContainerControl = this;
            // 
            // laborValidationProvider
            // 
            this.laborValidationProvider.ContainerControl = this;
            // 
            // frm_Automotive
            // 
            this.AcceptButton = this.btn_Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(383, 447);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.grpBox_Summary);
            this.Controls.Add(this.grpBox_partsLabor);
            this.Controls.Add(this.grpBox_misc);
            this.Controls.Add(this.grpBox_flushes);
            this.Controls.Add(this.grpBox_oilLube);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Automotive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automotive";
            this.Load += new System.EventHandler(this.frm_Automotive_Load);
            this.grpBox_oilLube.ResumeLayout(false);
            this.grpBox_oilLube.PerformLayout();
            this.grpBox_flushes.ResumeLayout(false);
            this.grpBox_flushes.PerformLayout();
            this.grpBox_misc.ResumeLayout(false);
            this.grpBox_misc.PerformLayout();
            this.grpBox_partsLabor.ResumeLayout(false);
            this.grpBox_partsLabor.PerformLayout();
            this.grpBox_Summary.ResumeLayout(false);
            this.grpBox_Summary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_oilLube;
        private System.Windows.Forms.GroupBox grpBox_flushes;
        private System.Windows.Forms.GroupBox grpBox_misc;
        private System.Windows.Forms.GroupBox grpBox_partsLabor;
        private System.Windows.Forms.GroupBox grpBox_Summary;
        private System.Windows.Forms.CheckBox chkBox_lubeJob;
        private System.Windows.Forms.CheckBox chkBox_oilChange;
        private System.Windows.Forms.CheckBox chkBox_transmissionFlush;
        private System.Windows.Forms.CheckBox chkBox_radiatorFlush;
        private System.Windows.Forms.CheckBox chkBox_tireRotation;
        private System.Windows.Forms.CheckBox chkBox_replaceMuffler;
        private System.Windows.Forms.CheckBox chkBox_inspection;
        private System.Windows.Forms.Label lbl_laborInput;
        private System.Windows.Forms.TextBox txtBox_laborInput;
        private System.Windows.Forms.Label lbl_partsInput;
        private System.Windows.Forms.TextBox txtBox_partsInput;
        private System.Windows.Forms.Label lbl_totalFeesSummary;
        private System.Windows.Forms.Label lbl_taxSummary;
        private System.Windows.Forms.Label lbl_partsSummary;
        private System.Windows.Forms.Label lbl_laborSummary;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ErrorProvider partsValidationProvider;
        private System.Windows.Forms.ErrorProvider laborValidationProvider;
        private System.Windows.Forms.Label lbl_serviceLaborSummaryOut;
        private System.Windows.Forms.Label lbl_totalFeesSummaryOut;
        private System.Windows.Forms.Label lbl_taxSummaryOut;
        private System.Windows.Forms.Label lbl_partsSummaryOut;
        private System.Windows.Forms.ToolTip lbl_isPartsLaborValidTip;
    }
}

