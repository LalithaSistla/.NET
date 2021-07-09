namespace TestCommand
{
    partial class ClaimForm
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
            this.lblInputFile = new System.Windows.Forms.Label();
            this.txtBoxInputFile = new System.Windows.Forms.TextBox();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.lblRecFile = new System.Windows.Forms.Label();
            this.txtBoxRecFile = new System.Windows.Forms.TextBox();
            this.btnRecFIle = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(4, 28);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(65, 17);
            this.lblInputFile.TabIndex = 0;
            this.lblInputFile.Text = "Input File";
            // 
            // txtBoxInputFile
            // 
            this.txtBoxInputFile.Location = new System.Drawing.Point(75, 25);
            this.txtBoxInputFile.Name = "txtBoxInputFile";
            this.txtBoxInputFile.Size = new System.Drawing.Size(278, 22);
            this.txtBoxInputFile.TabIndex = 1;
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(359, 25);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(45, 23);
            this.btnInputFile.TabIndex = 2;
            this.btnInputFile.Text = "...";
            this.btnInputFile.UseVisualStyleBackColor = true;
            // 
            // lblRecFile
            // 
            this.lblRecFile.AutoSize = true;
            this.lblRecFile.Location = new System.Drawing.Point(4, 68);
            this.lblRecFile.Name = "lblRecFile";
            this.lblRecFile.Size = new System.Drawing.Size(59, 17);
            this.lblRecFile.TabIndex = 3;
            this.lblRecFile.Text = "Rec File";
            // 
            // txtBoxRecFile
            // 
            this.txtBoxRecFile.Location = new System.Drawing.Point(75, 68);
            this.txtBoxRecFile.Name = "txtBoxRecFile";
            this.txtBoxRecFile.Size = new System.Drawing.Size(278, 22);
            this.txtBoxRecFile.TabIndex = 4;
            // 
            // btnRecFIle
            // 
            this.btnRecFIle.Location = new System.Drawing.Point(359, 68);
            this.btnRecFIle.Name = "btnRecFIle";
            this.btnRecFIle.Size = new System.Drawing.Size(45, 25);
            this.btnRecFIle.TabIndex = 5;
            this.btnRecFIle.Text = "...";
            this.btnRecFIle.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(278, 105);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 33);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ClaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 150);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnRecFIle);
            this.Controls.Add(this.txtBoxRecFile);
            this.Controls.Add(this.lblRecFile);
            this.Controls.Add(this.btnInputFile);
            this.Controls.Add(this.txtBoxInputFile);
            this.Controls.Add(this.lblInputFile);
            this.Name = "ClaimForm";
            this.Text = "Custom Command";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox txtBoxInputFile;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Label lblRecFile;
        private System.Windows.Forms.TextBox txtBoxRecFile;
        private System.Windows.Forms.Button btnRecFIle;
        private System.Windows.Forms.Button btnProcess;
    }
}

