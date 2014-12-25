namespace InfixToPostfix
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.AboutPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelCompany = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AboutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutPictureBox
            // 
            this.AboutPictureBox.Image = global::InfixToPostfix.Properties.Resources.whowhatwhen;
            this.AboutPictureBox.Location = new System.Drawing.Point(12, 12);
            this.AboutPictureBox.Name = "AboutPictureBox";
            this.AboutPictureBox.Size = new System.Drawing.Size(278, 186);
            this.AboutPictureBox.TabIndex = 0;
            this.AboutPictureBox.TabStop = false;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelHeader.Location = new System.Drawing.Point(297, 22);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(106, 16);
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Text = "Product Name";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelAuthor.Location = new System.Drawing.Point(297, 60);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(51, 13);
            this.LabelAuthor.TabIndex = 2;
            this.LabelAuthor.Text = "Copyright";
            // 
            // LabelCompany
            // 
            this.LabelCompany.AutoSize = true;
            this.LabelCompany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelCompany.Location = new System.Drawing.Point(297, 85);
            this.LabelCompany.Name = "LabelCompany";
            this.LabelCompany.Size = new System.Drawing.Size(82, 13);
            this.LabelCompany.TabIndex = 3;
            this.LabelCompany.Text = "Company Name";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("News Gothic MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelVersion.Location = new System.Drawing.Point(12, 219);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(62, 19);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "Version: ";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DescriptionTextBox.Location = new System.Drawing.Point(300, 149);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(182, 89);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelDescription.Location = new System.Drawing.Point(297, 133);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(63, 13);
            this.LabelDescription.TabIndex = 6;
            this.LabelDescription.Text = "Description:";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(494, 260);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelCompany);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.AboutPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.AboutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AboutPictureBox;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelCompany;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label LabelDescription;
    }
}