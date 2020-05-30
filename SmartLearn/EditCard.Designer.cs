namespace SmartLearn
{
    partial class EditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCard));
            this.lAnswer = new MetroFramework.Controls.MetroLabel();
            this.lQuestion = new MetroFramework.Controls.MetroLabel();
            this.bEditCard = new MetroFramework.Controls.MetroButton();
            this.tAnswer = new MetroFramework.Controls.MetroTextBox();
            this.tQuestion = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lAnswer.Location = new System.Drawing.Point(35, 121);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(46, 19);
            this.lAnswer.TabIndex = 9;
            this.lAnswer.Text = "Ответ";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lQuestion.Location = new System.Drawing.Point(35, 81);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(55, 19);
            this.lQuestion.TabIndex = 8;
            this.lQuestion.Text = "Вопрос";
            // 
            // bEditCard
            // 
            this.bEditCard.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bEditCard.Location = new System.Drawing.Point(418, 161);
            this.bEditCard.Name = "bEditCard";
            this.bEditCard.Size = new System.Drawing.Size(113, 23);
            this.bEditCard.TabIndex = 7;
            this.bEditCard.TabStop = false;
            this.bEditCard.Text = "Сохранить";
            this.bEditCard.UseSelectable = true;
            this.bEditCard.Click += new System.EventHandler(this.bEditCard_Click);
            this.bEditCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bEditCard_KeyDown);
            // 
            // tAnswer
            // 
            // 
            // 
            // 
            this.tAnswer.CustomButton.Image = null;
            this.tAnswer.CustomButton.Location = new System.Drawing.Point(378, 1);
            this.tAnswer.CustomButton.Name = "";
            this.tAnswer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tAnswer.CustomButton.TabIndex = 1;
            this.tAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tAnswer.CustomButton.UseSelectable = true;
            this.tAnswer.CustomButton.Visible = false;
            this.tAnswer.Lines = new string[0];
            this.tAnswer.Location = new System.Drawing.Point(131, 121);
            this.tAnswer.MaxLength = 32767;
            this.tAnswer.Name = "tAnswer";
            this.tAnswer.PasswordChar = '\0';
            this.tAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tAnswer.SelectedText = "";
            this.tAnswer.SelectionLength = 0;
            this.tAnswer.SelectionStart = 0;
            this.tAnswer.ShortcutsEnabled = true;
            this.tAnswer.Size = new System.Drawing.Size(400, 23);
            this.tAnswer.TabIndex = 6;
            this.tAnswer.UseSelectable = true;
            this.tAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tAnswer_KeyDown);
            // 
            // tQuestion
            // 
            // 
            // 
            // 
            this.tQuestion.CustomButton.Image = null;
            this.tQuestion.CustomButton.Location = new System.Drawing.Point(378, 1);
            this.tQuestion.CustomButton.Name = "";
            this.tQuestion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tQuestion.CustomButton.TabIndex = 1;
            this.tQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tQuestion.CustomButton.UseSelectable = true;
            this.tQuestion.CustomButton.Visible = false;
            this.tQuestion.Lines = new string[0];
            this.tQuestion.Location = new System.Drawing.Point(131, 81);
            this.tQuestion.MaxLength = 32767;
            this.tQuestion.Name = "tQuestion";
            this.tQuestion.PasswordChar = '\0';
            this.tQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tQuestion.SelectedText = "";
            this.tQuestion.SelectionLength = 0;
            this.tQuestion.SelectionStart = 0;
            this.tQuestion.ShortcutsEnabled = true;
            this.tQuestion.Size = new System.Drawing.Size(400, 23);
            this.tQuestion.TabIndex = 5;
            this.tQuestion.UseSelectable = true;
            this.tQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tQuestion_KeyDown);
            // 
            // EditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 202);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.bEditCard);
            this.Controls.Add(this.tAnswer);
            this.Controls.Add(this.tQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 202);
            this.MinimumSize = new System.Drawing.Size(571, 202);
            this.Name = "EditCard";
            this.Text = "Редактировать карту";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCard_FormClosing);
            this.Load += new System.EventHandler(this.EditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lAnswer;
        private MetroFramework.Controls.MetroLabel lQuestion;
        private MetroFramework.Controls.MetroButton bEditCard;
        private MetroFramework.Controls.MetroTextBox tAnswer;
        private MetroFramework.Controls.MetroTextBox tQuestion;
    }
}