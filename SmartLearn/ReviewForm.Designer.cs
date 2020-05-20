namespace SmartLearn
{
    partial class ReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm));
            this.bNext = new MetroFramework.Controls.MetroButton();
            this.LevelUp = new MetroFramework.Controls.MetroButton();
            this.LevelDown = new MetroFramework.Controls.MetroButton();
            this.LevelLabel = new MetroFramework.Controls.MetroLabel();
            this.tQA = new MetroFramework.Controls.MetroTextBox();
            this.bShowQA = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bNext
            // 
            this.bNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNext.Location = new System.Drawing.Point(717, 280);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(49, 37);
            this.bNext.TabIndex = 1;
            this.bNext.TabStop = false;
            this.bNext.Text = "→";
            this.bNext.UseSelectable = true;
            this.bNext.Visible = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // LevelUp
            // 
            this.LevelUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LevelUp.Location = new System.Drawing.Point(459, 280);
            this.LevelUp.Name = "LevelUp";
            this.LevelUp.Size = new System.Drawing.Size(49, 37);
            this.LevelUp.TabIndex = 3;
            this.LevelUp.TabStop = false;
            this.LevelUp.Text = "↑";
            this.LevelUp.UseSelectable = true;
            this.LevelUp.Visible = false;
            this.LevelUp.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LevelDown
            // 
            this.LevelDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LevelDown.Location = new System.Drawing.Point(277, 280);
            this.LevelDown.Name = "LevelDown";
            this.LevelDown.Size = new System.Drawing.Size(49, 37);
            this.LevelDown.TabIndex = 4;
            this.LevelDown.TabStop = false;
            this.LevelDown.Text = "↓";
            this.LevelDown.UseSelectable = true;
            this.LevelDown.Visible = false;
            this.LevelDown.Click += new System.EventHandler(this.LevelDown_Click);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LevelLabel.Location = new System.Drawing.Point(321, 25);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(132, 19);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Уровень карточки: ";
            this.LevelLabel.Click += new System.EventHandler(this.LevelLabel_Click);
            // 
            // tQA
            // 
            // 
            // 
            // 
            this.tQA.CustomButton.Image = null;
            this.tQA.CustomButton.Location = new System.Drawing.Point(554, 2);
            this.tQA.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tQA.CustomButton.Name = "";
            this.tQA.CustomButton.Size = new System.Drawing.Size(185, 185);
            this.tQA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tQA.CustomButton.TabIndex = 1;
            this.tQA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tQA.CustomButton.UseSelectable = true;
            this.tQA.CustomButton.Visible = false;
            this.tQA.DisplayIcon = true;
            this.tQA.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tQA.Lines = new string[] {
        "Текст по центру"};
            this.tQA.Location = new System.Drawing.Point(23, 63);
            this.tQA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tQA.MaxLength = 32767;
            this.tQA.Multiline = true;
            this.tQA.Name = "tQA";
            this.tQA.PasswordChar = '\0';
            this.tQA.ReadOnly = true;
            this.tQA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tQA.SelectedText = "";
            this.tQA.SelectionLength = 0;
            this.tQA.SelectionStart = 0;
            this.tQA.ShortcutsEnabled = true;
            this.tQA.Size = new System.Drawing.Size(742, 190);
            this.tQA.TabIndex = 6;
            this.tQA.TabStop = false;
            this.tQA.Text = "Текст по центру";
            this.tQA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tQA.UseSelectable = true;
            this.tQA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tQA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tQA.Click += new System.EventHandler(this.tQA_Click);
            // 
            // bShowQA
            // 
            this.bShowQA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowQA.Location = new System.Drawing.Point(332, 280);
            this.bShowQA.Name = "bShowQA";
            this.bShowQA.Size = new System.Drawing.Size(121, 37);
            this.bShowQA.TabIndex = 7;
            this.bShowQA.TabStop = false;
            this.bShowQA.Text = "Показать ответ";
            this.bShowQA.UseSelectable = true;
            this.bShowQA.Click += new System.EventHandler(this.bShowQA_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 340);
            this.Controls.Add(this.bShowQA);
            this.Controls.Add(this.tQA);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelDown);
            this.Controls.Add(this.LevelUp);
            this.Controls.Add(this.bNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReviewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviewForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewForm_FormClosed);
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton bNext;
        private MetroFramework.Controls.MetroButton LevelUp;
        private MetroFramework.Controls.MetroButton LevelDown;
        private MetroFramework.Controls.MetroLabel LevelLabel;
        private MetroFramework.Controls.MetroTextBox tQA;
        private MetroFramework.Controls.MetroButton bShowQA;
    }
}