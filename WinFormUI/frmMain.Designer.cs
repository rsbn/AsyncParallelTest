namespace WinFormUI
{
    partial class frmMain
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
            this.btnNormalCall = new System.Windows.Forms.Button();
            this.btnAsyncCall = new System.Windows.Forms.Button();
            this.btnParallelCall = new System.Windows.Forms.Button();
            this.ricLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNormalCall
            // 
            this.btnNormalCall.Location = new System.Drawing.Point(12, 12);
            this.btnNormalCall.Name = "btnNormalCall";
            this.btnNormalCall.Size = new System.Drawing.Size(221, 55);
            this.btnNormalCall.TabIndex = 0;
            this.btnNormalCall.Text = "Normal call";
            this.btnNormalCall.UseVisualStyleBackColor = true;
            this.btnNormalCall.Click += new System.EventHandler(this.btnNormalCall_Click);
            // 
            // btnAsyncCall
            // 
            this.btnAsyncCall.Location = new System.Drawing.Point(12, 73);
            this.btnAsyncCall.Name = "btnAsyncCall";
            this.btnAsyncCall.Size = new System.Drawing.Size(221, 55);
            this.btnAsyncCall.TabIndex = 1;
            this.btnAsyncCall.Text = "Async call";
            this.btnAsyncCall.UseVisualStyleBackColor = true;
            this.btnAsyncCall.Click += new System.EventHandler(this.btnAsyncCall_ClickAsync);
            // 
            // btnParallelCall
            // 
            this.btnParallelCall.Location = new System.Drawing.Point(12, 134);
            this.btnParallelCall.Name = "btnParallelCall";
            this.btnParallelCall.Size = new System.Drawing.Size(221, 55);
            this.btnParallelCall.TabIndex = 2;
            this.btnParallelCall.Text = "Parallel call";
            this.btnParallelCall.UseVisualStyleBackColor = true;
            this.btnParallelCall.Click += new System.EventHandler(this.btnParallelCall_Click);
            // 
            // ricLog
            // 
            this.ricLog.Location = new System.Drawing.Point(239, 12);
            this.ricLog.Name = "ricLog";
            this.ricLog.Size = new System.Drawing.Size(280, 177);
            this.ricLog.TabIndex = 3;
            this.ricLog.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 203);
            this.Controls.Add(this.ricLog);
            this.Controls.Add(this.btnParallelCall);
            this.Controls.Add(this.btnAsyncCall);
            this.Controls.Add(this.btnNormalCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASync & Parallel test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormalCall;
        private System.Windows.Forms.Button btnAsyncCall;
        private System.Windows.Forms.Button btnParallelCall;
        private System.Windows.Forms.RichTextBox ricLog;
    }
}

