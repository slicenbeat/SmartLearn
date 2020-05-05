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
            this.bQA = new MetroFramework.Controls.MetroButton();
            this.bNext = new MetroFramework.Controls.MetroButton();
            this.bPrev = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bQA
            // 
            this.bQA.Location = new System.Drawing.Point(110, 74);
            this.bQA.Name = "bQA";
            this.bQA.Size = new System.Drawing.Size(565, 179);
            this.bQA.TabIndex = 0;
            this.bQA.TabStop = false;
            this.bQA.UseSelectable = true;
            this.bQA.Click += new System.EventHandler(this.bQA_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(626, 280);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(49, 37);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "→";
            this.bNext.UseSelectable = true;
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(110, 280);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(49, 37);
            this.bPrev.TabIndex = 2;
            this.bPrev.Text = "←";
            this.bPrev.UseSelectable = true;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 340);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bQA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(789, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(789, 340);
            this.Name = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bQA;
        private MetroFramework.Controls.MetroButton bNext;
        private MetroFramework.Controls.MetroButton bPrev;
    }
}