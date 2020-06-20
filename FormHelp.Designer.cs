namespace ARP_Spoofer
{
    partial class FormHelp
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
            this.lbl_will_be_updated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_will_be_updated
            // 
            this.lbl_will_be_updated.AutoSize = true;
            this.lbl_will_be_updated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_will_be_updated.Location = new System.Drawing.Point(51, 17);
            this.lbl_will_be_updated.Name = "lbl_will_be_updated";
            this.lbl_will_be_updated.Size = new System.Drawing.Size(169, 20);
            this.lbl_will_be_updated.TabIndex = 0;
            this.lbl_will_be_updated.Text = "Will be updated soon...";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 57);
            this.Controls.Add(this.lbl_will_be_updated);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.Text = "ARP Spoofer  -  Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_will_be_updated;
    }
}