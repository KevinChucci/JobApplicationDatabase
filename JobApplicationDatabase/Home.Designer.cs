
namespace JobApplicationDatabase
{
    partial class Home
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
            this.addJob = new System.Windows.Forms.Button();
            this.searchJobs = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.count_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addJob
            // 
            this.addJob.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addJob.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addJob.Location = new System.Drawing.Point(52, 34);
            this.addJob.Margin = new System.Windows.Forms.Padding(2);
            this.addJob.Name = "addJob";
            this.addJob.Size = new System.Drawing.Size(144, 30);
            this.addJob.TabIndex = 0;
            this.addJob.Text = "Add Job";
            this.addJob.UseVisualStyleBackColor = true;
            this.addJob.Click += new System.EventHandler(this.addJob_Click);
            // 
            // searchJobs
            // 
            this.searchJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchJobs.Location = new System.Drawing.Point(52, 87);
            this.searchJobs.Margin = new System.Windows.Forms.Padding(2);
            this.searchJobs.Name = "searchJobs";
            this.searchJobs.Size = new System.Drawing.Size(144, 30);
            this.searchJobs.TabIndex = 1;
            this.searchJobs.Text = "Search Jobs";
            this.searchJobs.UseVisualStyleBackColor = true;
            this.searchJobs.Click += new System.EventHandler(this.searchJobs_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(0, 177);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(243, 39);
            this.errorMessage.TabIndex = 3;
            this.errorMessage.Text = "errorMessage";
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_Label
            // 
            this.count_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.count_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_Label.Location = new System.Drawing.Point(0, 140);
            this.count_Label.Name = "count_Label";
            this.count_Label.Size = new System.Drawing.Size(243, 37);
            this.count_Label.TabIndex = 4;
            this.count_Label.Text = "count";
            this.count_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 216);
            this.Controls.Add(this.count_Label);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.searchJobs);
            this.Controls.Add(this.addJob);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addJob;
        private System.Windows.Forms.Button searchJobs;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label count_Label;
    }
}

