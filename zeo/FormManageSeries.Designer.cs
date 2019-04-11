namespace Zeo {
    partial class FormManageSeries {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxFollowingSeries = new System.Windows.Forms.ListBox();
            this.buttonEditSeries = new System.Windows.Forms.Button();
            this.buttonAddSeries = new System.Windows.Forms.Button();
            this.buttonDeleteSeries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFollowingSeries
            // 
            this.listBoxFollowingSeries.FormattingEnabled = true;
            this.listBoxFollowingSeries.Location = new System.Drawing.Point(12, 12);
            this.listBoxFollowingSeries.Name = "listBoxFollowingSeries";
            this.listBoxFollowingSeries.Size = new System.Drawing.Size(250, 160);
            this.listBoxFollowingSeries.TabIndex = 0;
            // 
            // buttonEditSeries
            // 
            this.buttonEditSeries.Location = new System.Drawing.Point(12, 207);
            this.buttonEditSeries.Name = "buttonEditSeries";
            this.buttonEditSeries.Size = new System.Drawing.Size(250, 23);
            this.buttonEditSeries.TabIndex = 1;
            this.buttonEditSeries.Text = "Edit Series";
            this.buttonEditSeries.UseVisualStyleBackColor = true;
            this.buttonEditSeries.Click += new System.EventHandler(this.buttonEditSeries_Click);
            // 
            // buttonAddSeries
            // 
            this.buttonAddSeries.Location = new System.Drawing.Point(12, 178);
            this.buttonAddSeries.Name = "buttonAddSeries";
            this.buttonAddSeries.Size = new System.Drawing.Size(250, 23);
            this.buttonAddSeries.TabIndex = 2;
            this.buttonAddSeries.Text = "Add New Series";
            this.buttonAddSeries.UseVisualStyleBackColor = true;
            this.buttonAddSeries.Click += new System.EventHandler(this.buttonAddSeries_Click);
            // 
            // buttonDeleteSeries
            // 
            this.buttonDeleteSeries.Location = new System.Drawing.Point(12, 236);
            this.buttonDeleteSeries.Name = "buttonDeleteSeries";
            this.buttonDeleteSeries.Size = new System.Drawing.Size(250, 23);
            this.buttonDeleteSeries.TabIndex = 3;
            this.buttonDeleteSeries.Text = "Delete Series";
            this.buttonDeleteSeries.UseVisualStyleBackColor = true;
            this.buttonDeleteSeries.Click += new System.EventHandler(this.buttonDeleteSeries_Click);
            // 
            // FormManageSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 269);
            this.Controls.Add(this.buttonDeleteSeries);
            this.Controls.Add(this.buttonAddSeries);
            this.Controls.Add(this.buttonEditSeries);
            this.Controls.Add(this.listBoxFollowingSeries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageSeries";
            this.Text = "Manage Series";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageSeries_FormClosed);
            this.Load += new System.EventHandler(this.FormManageSeries_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFollowingSeries;
        private System.Windows.Forms.Button buttonEditSeries;
        private System.Windows.Forms.Button buttonAddSeries;
        private System.Windows.Forms.Button buttonDeleteSeries;
    }
}