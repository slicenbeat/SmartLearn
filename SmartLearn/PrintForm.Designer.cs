namespace SmartLearn
{
    partial class PrintForm
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
            this.tPrintText = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // tPrintText
            // 
            // 
            // 
            // 
            this.tPrintText.CustomButton.Image = null;
            this.tPrintText.CustomButton.Location = new System.Drawing.Point(1103, 1);
            this.tPrintText.CustomButton.Name = "";
            this.tPrintText.CustomButton.Size = new System.Drawing.Size(187, 187);
            this.tPrintText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tPrintText.CustomButton.TabIndex = 1;
            this.tPrintText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tPrintText.CustomButton.UseSelectable = true;
            this.tPrintText.CustomButton.Visible = false;
            this.tPrintText.Lines = new string[0];
            this.tPrintText.Location = new System.Drawing.Point(5, 27);
            this.tPrintText.MaxLength = 32767;
            this.tPrintText.Multiline = true;
            this.tPrintText.Name = "tPrintText";
            this.tPrintText.PasswordChar = '\0';
            this.tPrintText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tPrintText.SelectedText = "";
            this.tPrintText.SelectionLength = 0;
            this.tPrintText.SelectionStart = 0;
            this.tPrintText.ShortcutsEnabled = true;
            this.tPrintText.Size = new System.Drawing.Size(694, 189);
            this.tPrintText.TabIndex = 0;
            this.tPrintText.UseSelectable = true;
            this.tPrintText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tPrintText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tPrintText.Click += new System.EventHandler(this.tPrintText_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(260, 236);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(165, 43);
            this.metroLink1.TabIndex = 14;
            this.metroLink1.TabStop = false;
            this.metroLink1.Text = "Распечатать колоду";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 290);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tPrintText);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tPrintText;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}