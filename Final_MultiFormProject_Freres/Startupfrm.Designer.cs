namespace Final_MultiFormProject_Freres
{
    partial class Startupfrm
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
            this.openMathFrmBtn = new System.Windows.Forms.Button();
            this.openParmaFrmBtn = new System.Windows.Forms.Button();
            this.appinstructionsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openMathFrmBtn
            // 
            this.openMathFrmBtn.Location = new System.Drawing.Point(12, 22);
            this.openMathFrmBtn.Name = "openMathFrmBtn";
            this.openMathFrmBtn.Size = new System.Drawing.Size(137, 44);
            this.openMathFrmBtn.TabIndex = 1;
            this.openMathFrmBtn.Text = "Open Math Query";
            this.openMathFrmBtn.UseVisualStyleBackColor = true;
            this.openMathFrmBtn.Click += new System.EventHandler(this.openMathFrmBtn_Click);
            // 
            // openParmaFrmBtn
            // 
            this.openParmaFrmBtn.Location = new System.Drawing.Point(172, 22);
            this.openParmaFrmBtn.Name = "openParmaFrmBtn";
            this.openParmaFrmBtn.Size = new System.Drawing.Size(137, 44);
            this.openParmaFrmBtn.TabIndex = 2;
            this.openParmaFrmBtn.Text = "Open Paramertized Query";
            this.openParmaFrmBtn.UseVisualStyleBackColor = true;
            this.openParmaFrmBtn.Click += new System.EventHandler(this.openParmaFrmBtn_Click);
            // 
            // appinstructionsLbl
            // 
            this.appinstructionsLbl.AutoSize = true;
            this.appinstructionsLbl.Location = new System.Drawing.Point(12, 13);
            this.appinstructionsLbl.Name = "appinstructionsLbl";
            this.appinstructionsLbl.Size = new System.Drawing.Size(0, 13);
            this.appinstructionsLbl.TabIndex = 3;
            // 
            // Startupfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 80);
            this.Controls.Add(this.appinstructionsLbl);
            this.Controls.Add(this.openParmaFrmBtn);
            this.Controls.Add(this.openMathFrmBtn);
            this.Name = "Startupfrm";
            this.Text = "MultiForm Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openMathFrmBtn;
        private System.Windows.Forms.Button openParmaFrmBtn;
        private System.Windows.Forms.Label appinstructionsLbl;
    }
}

