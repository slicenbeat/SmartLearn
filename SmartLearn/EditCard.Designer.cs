﻿namespace SmartLearn
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
            this.lAnswer.Location = new System.Drawing.Point(47, 149);
            this.lAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(48, 20);
            this.lAnswer.TabIndex = 9;
            this.lAnswer.Text = "Ответ";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lQuestion.Location = new System.Drawing.Point(47, 100);
            this.lQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(61, 20);
            this.lQuestion.TabIndex = 8;
            this.lQuestion.Text = "Вопрос";
            // 
            // bEditCard
            // 
            this.bEditCard.Location = new System.Drawing.Point(557, 198);
            this.bEditCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEditCard.Name = "bEditCard";
            this.bEditCard.Size = new System.Drawing.Size(151, 28);
            this.bEditCard.TabIndex = 7;
            this.bEditCard.Text = "Сохранить";
            this.bEditCard.UseSelectable = true;
            this.bEditCard.Click += new System.EventHandler(this.bEditCard_Click);
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
            this.tAnswer.Location = new System.Drawing.Point(175, 149);
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
            this.tAnswer.TabIndex = 6;
            this.tAnswer.UseSelectable = true;
            this.tAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tQuestion.Location = new System.Drawing.Point(175, 100);
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
            this.tQuestion.TabIndex = 5;
            this.tQuestion.UseSelectable = true;
            this.tQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 249);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.bEditCard);
            this.Controls.Add(this.tAnswer);
            this.Controls.Add(this.tQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(761, 249);
            this.MinimumSize = new System.Drawing.Size(761, 249);
            this.Name = "EditCard";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Редактировать карту";
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