namespace SmartLearn
{
    partial class AddCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCard));
            this.tQuestion = new MetroFramework.Controls.MetroTextBox();
            this.tAnswer = new MetroFramework.Controls.MetroTextBox();
            this.bCreateCard = new MetroFramework.Controls.MetroButton();
            this.lQuestion = new MetroFramework.Controls.MetroLabel();
            this.lAnswer = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tQuestion
            // 
            // 
            // 
            // 
            this.tQuestion.CustomButton.Image = null;
            this.tQuestion.CustomButton.Location = new System.Drawing.Point(676, 2);
            this.tQuestion.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tQuestion.CustomButton.Name = "";
            this.tQuestion.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.tQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tQuestion.CustomButton.TabIndex = 1;
            this.tQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tQuestion.CustomButton.UseSelectable = true;
            this.tQuestion.CustomButton.Visible = false;
            this.tQuestion.Lines = new string[0];
            this.tQuestion.Location = new System.Drawing.Point(177, 92);
            this.tQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tQuestion.MaxLength = 32767;
            this.tQuestion.Name = "tQuestion";
            this.tQuestion.PasswordChar = '\0';
            this.tQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tQuestion.SelectedText = "";
            this.tQuestion.SelectionLength = 0;
            this.tQuestion.SelectionStart = 0;
            this.tQuestion.ShortcutsEnabled = true;
            this.tQuestion.Size = new System.Drawing.Size(533, 28);
            this.tQuestion.TabIndex = 0;
            this.tQuestion.UseSelectable = true;
            this.tQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tQuestion.Click += new System.EventHandler(this.tQuestion_Click);
            // 
            // tAnswer
            // 
            // 
            // 
            // 
            this.tAnswer.CustomButton.Image = null;
            this.tAnswer.CustomButton.Location = new System.Drawing.Point(676, 2);
            this.tAnswer.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tAnswer.CustomButton.Name = "";
            this.tAnswer.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.tAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tAnswer.CustomButton.TabIndex = 1;
            this.tAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tAnswer.CustomButton.UseSelectable = true;
            this.tAnswer.CustomButton.Visible = false;
            this.tAnswer.Lines = new string[0];
            this.tAnswer.Location = new System.Drawing.Point(177, 142);
            this.tAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tAnswer.MaxLength = 32767;
            this.tAnswer.Name = "tAnswer";
            this.tAnswer.PasswordChar = '\0';
            this.tAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tAnswer.SelectedText = "";
            this.tAnswer.SelectionLength = 0;
            this.tAnswer.SelectionStart = 0;
            this.tAnswer.ShortcutsEnabled = true;
            this.tAnswer.Size = new System.Drawing.Size(533, 28);
            this.tAnswer.TabIndex = 1;
            this.tAnswer.UseSelectable = true;
            this.tAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bCreateCard
            // 
            this.bCreateCard.Location = new System.Drawing.Point(560, 191);
            this.bCreateCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCreateCard.Name = "bCreateCard";
            this.bCreateCard.Size = new System.Drawing.Size(151, 28);
            this.bCreateCard.TabIndex = 2;
            this.bCreateCard.Text = "Добавить";
            this.bCreateCard.UseSelectable = true;
            this.bCreateCard.Click += new System.EventHandler(this.bAddCard_Click);
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lQuestion.Location = new System.Drawing.Point(49, 92);
            this.lQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(61, 20);
            this.lQuestion.TabIndex = 3;
            this.lQuestion.Text = "Вопрос";
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lAnswer.Location = new System.Drawing.Point(49, 142);
            this.lAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(48, 20);
            this.lAnswer.TabIndex = 4;
            this.lAnswer.Text = "Ответ";
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 249);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.bCreateCard);
            this.Controls.Add(this.tAnswer);
            this.Controls.Add(this.tQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(761, 249);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(761, 249);
            this.Name = "AddCard";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Создать карточку";
            this.Load += new System.EventHandler(this.EditCardList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tQuestion;
        private MetroFramework.Controls.MetroTextBox tAnswer;
        private MetroFramework.Controls.MetroButton bCreateCard;
        private MetroFramework.Controls.MetroLabel lQuestion;
        private MetroFramework.Controls.MetroLabel lAnswer;
    }
}