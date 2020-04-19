namespace SmartLearn
{
    partial class LearningForm
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
            this.LeShowAnswer = new MetroFramework.Controls.MetroButton();
            this.LeNextQuestion = new MetroFramework.Controls.MetroButton();
            this.LePrevQuestion = new MetroFramework.Controls.MetroButton();
            this.LeOpenCards = new MetroFramework.Controls.MetroButton();
            this.LeViewer = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // LeShowAnswer
            // 
            this.LeShowAnswer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LeShowAnswer.Location = new System.Drawing.Point(459, 596);
            this.LeShowAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.LeShowAnswer.Name = "LeShowAnswer";
            this.LeShowAnswer.Size = new System.Drawing.Size(197, 54);
            this.LeShowAnswer.TabIndex = 1;
            this.LeShowAnswer.TabStop = false;
            this.LeShowAnswer.Text = "Показать ответ";
            this.LeShowAnswer.UseSelectable = true;
            // 
            // LeNextQuestion
            // 
            this.LeNextQuestion.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LeNextQuestion.Location = new System.Drawing.Point(696, 596);
            this.LeNextQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.LeNextQuestion.Name = "LeNextQuestion";
            this.LeNextQuestion.Size = new System.Drawing.Size(197, 54);
            this.LeNextQuestion.TabIndex = 3;
            this.LeNextQuestion.TabStop = false;
            this.LeNextQuestion.Text = "Следующий вопрос";
            this.LeNextQuestion.UseSelectable = true;
            // 
            // LePrevQuestion
            // 
            this.LePrevQuestion.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LePrevQuestion.Location = new System.Drawing.Point(221, 596);
            this.LePrevQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.LePrevQuestion.Name = "LePrevQuestion";
            this.LePrevQuestion.Size = new System.Drawing.Size(197, 54);
            this.LePrevQuestion.TabIndex = 4;
            this.LePrevQuestion.TabStop = false;
            this.LePrevQuestion.Text = "Предыдущий вопрос";
            this.LePrevQuestion.UseSelectable = true;
            // 
            // LeOpenCards
            // 
            this.LeOpenCards.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LeOpenCards.Location = new System.Drawing.Point(459, 16);
            this.LeOpenCards.Margin = new System.Windows.Forms.Padding(4);
            this.LeOpenCards.Name = "LeOpenCards";
            this.LeOpenCards.Size = new System.Drawing.Size(197, 54);
            this.LeOpenCards.TabIndex = 0;
            this.LeOpenCards.TabStop = false;
            this.LeOpenCards.Text = "Открыть колоду";
            this.LeOpenCards.UseSelectable = true;
            this.LeOpenCards.Click += new System.EventHandler(this.LeOpenCards_Click);
            // 
            // LeViewer
            // 
            // 
            // 
            // 
            this.LeViewer.CustomButton.Image = null;
            this.LeViewer.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.LeViewer.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.LeViewer.CustomButton.Name = "";
            this.LeViewer.CustomButton.Size = new System.Drawing.Size(487, 487);
            this.LeViewer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LeViewer.CustomButton.TabIndex = 1;
            this.LeViewer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LeViewer.CustomButton.UseSelectable = true;
            this.LeViewer.CustomButton.Visible = false;
            this.LeViewer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LeViewer.Lines = new string[0];
            this.LeViewer.Location = new System.Drawing.Point(221, 78);
            this.LeViewer.Margin = new System.Windows.Forms.Padding(4);
            this.LeViewer.MaxLength = 32767;
            this.LeViewer.Name = "LeViewer";
            this.LeViewer.PasswordChar = '\0';
            this.LeViewer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LeViewer.SelectedText = "";
            this.LeViewer.SelectionLength = 0;
            this.LeViewer.SelectionStart = 0;
            this.LeViewer.ShortcutsEnabled = true;
            this.LeViewer.Size = new System.Drawing.Size(672, 492);
            this.LeViewer.TabIndex = 5;
            this.LeViewer.UseSelectable = true;
            this.LeViewer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LeViewer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 716);
            this.Controls.Add(this.LeViewer);
            this.Controls.Add(this.LePrevQuestion);
            this.Controls.Add(this.LeNextQuestion);
            this.Controls.Add(this.LeShowAnswer);
            this.Controls.Add(this.LeOpenCards);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1109, 716);
            this.MinimumSize = new System.Drawing.Size(1109, 716);
            this.Name = "LearningForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.LearningForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton LeShowAnswer;
        private MetroFramework.Controls.MetroButton LeNextQuestion;
        private MetroFramework.Controls.MetroButton LePrevQuestion;
        private MetroFramework.Controls.MetroButton LeOpenCards;
        private MetroFramework.Controls.MetroTextBox LeViewer;
    }
}