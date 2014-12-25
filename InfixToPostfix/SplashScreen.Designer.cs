namespace InfixToPostfix
{
    partial class SplashScreen
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
            this.SplashScreenPicBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelProductVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreenPicBox
            // 
            this.SplashScreenPicBox.Image = global::InfixToPostfix.Properties.Resources.moneyIMG;
            this.SplashScreenPicBox.ImageLocation = "";
            this.SplashScreenPicBox.Location = new System.Drawing.Point(12, 12);
            this.SplashScreenPicBox.Name = "SplashScreenPicBox";
            this.SplashScreenPicBox.Size = new System.Drawing.Size(212, 243);
            this.SplashScreenPicBox.TabIndex = 0;
            this.SplashScreenPicBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(22, 258);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(90, 17);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "ProductTitle";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 3500;
            this.TickTimer.Tick += new System.EventHandler(this.TickTimer_Tick);
            // 
            // LabelProductVersion
            // 
            this.LabelProductVersion.AutoSize = true;
            this.LabelProductVersion.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductVersion.Location = new System.Drawing.Point(64, 279);
            this.LabelProductVersion.Name = "LabelProductVersion";
            this.LabelProductVersion.Size = new System.Drawing.Size(96, 15);
            this.LabelProductVersion.TabIndex = 3;
            this.LabelProductVersion.Text = "ProductVersion";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(235, 303);
            this.Controls.Add(this.LabelProductVersion);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SplashScreenPicBox);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashScreenPicBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Timer TickTimer;
        private System.Windows.Forms.Label LabelProductVersion;
    }
}