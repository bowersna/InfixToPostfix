namespace InfixToPostfix
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListBox = new System.Windows.Forms.ListBox();
            this.InfixTextbox = new System.Windows.Forms.TextBox();
            this.PostfixTextbox = new System.Windows.Forms.TextBox();
            this.InfixExpressionLabel = new System.Windows.Forms.Label();
            this.PostfixExpressionLabel = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputInfixDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutInfixToPostfixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.GeneratePostfixButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(34, 41);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(762, 180);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // InfixTextbox
            // 
            this.InfixTextbox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfixTextbox.Location = new System.Drawing.Point(192, 262);
            this.InfixTextbox.Name = "InfixTextbox";
            this.InfixTextbox.Size = new System.Drawing.Size(583, 22);
            this.InfixTextbox.TabIndex = 1;
            // 
            // PostfixTextbox
            // 
            this.PostfixTextbox.BackColor = System.Drawing.Color.Khaki;
            this.PostfixTextbox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostfixTextbox.ForeColor = System.Drawing.Color.MediumBlue;
            this.PostfixTextbox.Location = new System.Drawing.Point(192, 297);
            this.PostfixTextbox.Name = "PostfixTextbox";
            this.PostfixTextbox.ReadOnly = true;
            this.PostfixTextbox.Size = new System.Drawing.Size(583, 22);
            this.PostfixTextbox.TabIndex = 2;
            // 
            // InfixExpressionLabel
            // 
            this.InfixExpressionLabel.AutoSize = true;
            this.InfixExpressionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfixExpressionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfixExpressionLabel.Location = new System.Drawing.Point(48, 263);
            this.InfixExpressionLabel.Name = "InfixExpressionLabel";
            this.InfixExpressionLabel.Size = new System.Drawing.Size(105, 19);
            this.InfixExpressionLabel.TabIndex = 6;
            this.InfixExpressionLabel.Text = "Infix Expression";
            // 
            // PostfixExpressionLabel
            // 
            this.PostfixExpressionLabel.AutoSize = true;
            this.PostfixExpressionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostfixExpressionLabel.Location = new System.Drawing.Point(48, 298);
            this.PostfixExpressionLabel.Name = "PostfixExpressionLabel";
            this.PostfixExpressionLabel.Size = new System.Drawing.Size(120, 19);
            this.PostfixExpressionLabel.TabIndex = 7;
            this.PostfixExpressionLabel.Text = "Postfix Expression";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputInfixDataFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inputInfixDataFileToolStripMenuItem
            // 
            this.inputInfixDataFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputInfixDataFileToolStripMenuItem.Name = "inputInfixDataFileToolStripMenuItem";
            this.inputInfixDataFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.inputInfixDataFileToolStripMenuItem.Text = "Input Infix Data File";
            this.inputInfixDataFileToolStripMenuItem.Click += new System.EventHandler(this.inputInfixDataFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInfixToPostfixToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutInfixToPostfixToolStripMenuItem
            // 
            this.aboutInfixToPostfixToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.aboutInfixToPostfixToolStripMenuItem.Name = "aboutInfixToPostfixToolStripMenuItem";
            this.aboutInfixToPostfixToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aboutInfixToPostfixToolStripMenuItem.Text = "About Infix To Postfix";
            this.aboutInfixToPostfixToolStripMenuItem.Click += new System.EventHandler(this.aboutInfixToPostfixToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuStrip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(843, 24);
            this.MenuStrip.TabIndex = 8;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(522, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(172, 31);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(261, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(172, 31);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // GeneratePostfixButton
            // 
            this.GeneratePostfixButton.Location = new System.Drawing.Point(3, 3);
            this.GeneratePostfixButton.Name = "GeneratePostfixButton";
            this.GeneratePostfixButton.Size = new System.Drawing.Size(172, 31);
            this.GeneratePostfixButton.TabIndex = 3;
            this.GeneratePostfixButton.Text = "Generate Postfix";
            this.GeneratePostfixButton.UseVisualStyleBackColor = true;
            this.GeneratePostfixButton.Click += new System.EventHandler(this.GeneratePostfixButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GeneratePostfixButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(76, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 37);
            this.panel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PostfixExpressionLabel);
            this.Controls.Add(this.InfixExpressionLabel);
            this.Controls.Add(this.PostfixTextbox);
            this.Controls.Add(this.InfixTextbox);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infix To Postfix Converter";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox InfixTextbox;
        private System.Windows.Forms.TextBox PostfixTextbox;
        private System.Windows.Forms.Label InfixExpressionLabel;
        private System.Windows.Forms.Label PostfixExpressionLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputInfixDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutInfixToPostfixToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button GeneratePostfixButton;
        private System.Windows.Forms.Panel panel1;
    }
}

