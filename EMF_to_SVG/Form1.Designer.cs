namespace EMF_to_SVG
{
    partial class Form1
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
            this.openEmfBtn = new System.Windows.Forms.Button();
            this.selectedEMFBox = new System.Windows.Forms.TextBox();
            this.saveSVGBtn = new System.Windows.Forms.Button();
            this.outputSVGFileBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openEmfBtn
            // 
            this.openEmfBtn.Location = new System.Drawing.Point(12, 12);
            this.openEmfBtn.Name = "openEmfBtn";
            this.openEmfBtn.Size = new System.Drawing.Size(75, 23);
            this.openEmfBtn.TabIndex = 0;
            this.openEmfBtn.Text = "Select EMF";
            this.openEmfBtn.UseVisualStyleBackColor = true;
            this.openEmfBtn.Click += new System.EventHandler(this.openEmfBtn_Click);
            // 
            // selectedEMFBox
            // 
            this.selectedEMFBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedEMFBox.Location = new System.Drawing.Point(93, 15);
            this.selectedEMFBox.Name = "selectedEMFBox";
            this.selectedEMFBox.ReadOnly = true;
            this.selectedEMFBox.Size = new System.Drawing.Size(310, 20);
            this.selectedEMFBox.TabIndex = 1;
            // 
            // saveSVGBtn
            // 
            this.saveSVGBtn.Location = new System.Drawing.Point(12, 41);
            this.saveSVGBtn.Name = "saveSVGBtn";
            this.saveSVGBtn.Size = new System.Drawing.Size(75, 23);
            this.saveSVGBtn.TabIndex = 2;
            this.saveSVGBtn.Text = "Save SVG";
            this.saveSVGBtn.UseVisualStyleBackColor = true;
            this.saveSVGBtn.Click += new System.EventHandler(this.saveSVGBtn_Click);
            // 
            // outputSVGFileBox
            // 
            this.outputSVGFileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputSVGFileBox.Location = new System.Drawing.Point(93, 41);
            this.outputSVGFileBox.Name = "outputSVGFileBox";
            this.outputSVGFileBox.ReadOnly = true;
            this.outputSVGFileBox.Size = new System.Drawing.Size(310, 20);
            this.outputSVGFileBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 78);
            this.Controls.Add(this.outputSVGFileBox);
            this.Controls.Add(this.saveSVGBtn);
            this.Controls.Add(this.selectedEMFBox);
            this.Controls.Add(this.openEmfBtn);
            this.Name = "Form1";
            this.Text = "EMF to SVG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openEmfBtn;
        private System.Windows.Forms.TextBox selectedEMFBox;
        private System.Windows.Forms.Button saveSVGBtn;
        private System.Windows.Forms.TextBox outputSVGFileBox;
    }
}

