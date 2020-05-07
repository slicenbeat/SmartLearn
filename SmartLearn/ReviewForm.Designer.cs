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
            this.bQA.Location = new System.Drawing.Point(147, 91);
            this.bQA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bQA.Name = "bQA";
            this.bQA.Size = new System.Drawing.Size(753, 220);
            this.bQA.TabIndex = 0;
            this.bQA.TabStop = false;
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
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 418);
            this.Controls.Add(this.bPrev);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bQA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1052, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1052, 418);
            this.Name = "ReviewForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bQA;
        private MetroFramework.Controls.MetroButton bNext;
        private MetroFramework.Controls.MetroButton bPrev;
    }
}