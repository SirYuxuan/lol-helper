namespace LOLHelper.Debug
{
    partial class Debug
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
            this.txtBox_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_log
            // 
            this.txtBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_log.Location = new System.Drawing.Point(0, 0);
            this.txtBox_log.Multiline = true;
            this.txtBox_log.Name = "txtBox_log";
            this.txtBox_log.ReadOnly = true;
            this.txtBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_log.Size = new System.Drawing.Size(662, 454);
            this.txtBox_log.TabIndex = 0;
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 453);
            this.ControlBox = false;
            this.Controls.Add(this.txtBox_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Debug";
            this.ShowIcon = false;
            this.Text = "Debug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Debug_FormClosing);
            this.Load += new System.EventHandler(this.Debug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox_log;
    }
}