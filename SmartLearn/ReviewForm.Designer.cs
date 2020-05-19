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
            this.bQA.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bQA.Location = new System.Drawing.Point(23, 63);
            this.bQA.Name = "bQA";
            this.bQA.Size = new System.Drawing.Size(743, 190);
            this.bQA.TabIndex = 0;
            this.bQA.TabStop = false;
            this.bQA.UseSelectable = true;
            this.bQA.Click += new System.EventHandler(this.bQA_Click);
            // 
            // bNext
            // 
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
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(110, 280);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(49, 37);
            this.bPrev.TabIndex = 2;
            this.bPrev.TabStop = false;
            this.bPrev.Text = "←";
            this.bPrev.UseSelectable = true;
            this.bPrev.Visible = false;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // LevelUp
            // 
            this.LevelUp.Location = new System.Drawing.Point(391, 280);
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
            this.LevelDown.Location = new System.Drawing.Point(336, 280);
            this.LevelDown.Name = "LevelDown";
            this.LevelDown.Size = new System.Drawing.Size(49, 37);
            this.LevelDown.TabIndex = 4;
            this.LevelDown.TabStop = false;
            this.LevelDown.Text = "↓";
            this.LevelDown.UseSelectable = true;
            this.LevelDown.Visible = false;
            this.LevelDown.Click += new System.EventHandler(this.LevelDown_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 340);
            this.Controls.Add(this.LevelDown);
            this.Controls.Add(this.LevelUp);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bQA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(789, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(789, 340);
            this.Name = "ReviewForm";
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