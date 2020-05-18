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
            this.bQA = new MetroFramework.Controls.MetroButton();
            this.bNext = new MetroFramework.Controls.MetroButton();
            this.bPrev = new MetroFramework.Controls.MetroButton();
            this.LevelUp = new MetroFramework.Controls.MetroButton();
            this.LevelDown = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bQA
            // 
            this.bQA.Location = new System.Drawing.Point(147, 91);
            this.bQA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bQA.Name = "bQA";
            this.bQA.Size = new System.Drawing.Size(753, 220);
            this.bQA.TabIndex = 0;
            this.bQA.TabStop = false;
            this.bQA.Text = " ";
            this.bQA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bQA.UseSelectable = true;
            this.bQA.Click += new System.EventHandler(this.bQA_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(835, 345);
            this.bNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(65, 46);
            this.bNext.TabIndex = 1;
            this.bNext.TabStop = false;
            this.bNext.Text = "→";
            this.bNext.UseSelectable = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(147, 345);
            this.bPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(65, 46);
            this.bPrev.TabIndex = 2;
            this.bPrev.TabStop = false;
            this.bPrev.Text = "←";
            this.bPrev.UseSelectable = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // LevelUp
            // 
            this.LevelUp.Location = new System.Drawing.Point(936, 178);
            this.LevelUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LevelUp.Name = "LevelUp";
            this.LevelUp.Size = new System.Drawing.Size(65, 46);
            this.LevelUp.TabIndex = 3;
            this.LevelUp.TabStop = false;
            this.LevelUp.Text = "↑";
            this.LevelUp.UseSelectable = true;
            this.LevelUp.Visible = false;
            this.LevelUp.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LevelDown
            // 
            this.LevelDown.Location = new System.Drawing.Point(31, 178);
            this.LevelDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LevelDown.Name = "LevelDown";
            this.LevelDown.Size = new System.Drawing.Size(65, 46);
            this.LevelDown.TabIndex = 4;
            this.LevelDown.TabStop = false;
            this.LevelDown.Text = "↓";
            this.LevelDown.UseSelectable = true;
            this.LevelDown.Visible = false;
            this.LevelDown.Click += new System.EventHandler(this.LevelDown_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 418);
            this.Controls.Add(this.LevelDown);
            this.Controls.Add(this.LevelUp);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bQA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1052, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1052, 418);
            this.Name = "ReviewForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviewForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewForm_FormClosed);
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bQA;
        private MetroFramework.Controls.MetroButton bNext;
        private MetroFramework.Controls.MetroButton bPrev;
        private MetroFramework.Controls.MetroButton LevelUp;
        private MetroFramework.Controls.MetroButton LevelDown;
    }
}