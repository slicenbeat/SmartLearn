namespace SmartLearn
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.OpenCards = new System.Windows.Forms.OpenFileDialog();
            this.ShowAnswer = new MetroFramework.Controls.MetroButton();
            this.OpenFile = new MetroFramework.Controls.MetroButton();
            this.ShowNext = new MetroFramework.Controls.MetroButton();
            this.SaveFile = new MetroFramework.Controls.MetroButton();
            this.SaveCards = new System.Windows.Forms.SaveFileDialog();
            this.TestStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ViewerQuestions = new MetroFramework.Controls.MetroTextBox();
            this.ViewerAnswers = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TestStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCards
            // 
            this.OpenCards.FileName = "OpenFile";
            this.OpenCards.Filter = "\"Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowAnswer.Enabled = false;
            this.ShowAnswer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ShowAnswer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ShowAnswer.Location = new System.Drawing.Point(23, 362);
            this.ShowAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(120, 28);
            this.ShowAnswer.TabIndex = 1;
            this.ShowAnswer.Text = "Ответ";
            this.ShowAnswer.UseSelectable = true;
            this.ShowAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenFile.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.OpenFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.OpenFile.Location = new System.Drawing.Point(223, 362);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(167, 28);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.TabStop = false;
            this.OpenFile.Text = "Открыть файл";
            this.OpenFile.UseSelectable = true;
            this.OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowNext
            // 
            this.ShowNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowNext.Enabled = false;
            this.ShowNext.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ShowNext.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ShowNext.Location = new System.Drawing.Point(703, 362);
            this.ShowNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowNext.Name = "ShowNext";
            this.ShowNext.Size = new System.Drawing.Size(120, 28);
            this.ShowNext.TabIndex = 1;
            this.ShowNext.Text = "Следующий";
            this.ShowNext.UseSelectable = true;
            this.ShowNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveFile.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SaveFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.SaveFile.Location = new System.Drawing.Point(475, 362);
            this.SaveFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(167, 28);
            this.SaveFile.TabIndex = 3;
            this.SaveFile.TabStop = false;
            this.SaveFile.Text = "Сохранить файл";
            this.SaveFile.UseSelectable = true;
            this.SaveFile.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SaveCards
            // 
            this.SaveCards.Filter = "\"Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // TestStyle
            // 
            this.TestStyle.Owner = null;
            // 
            // ViewerQuestions
            // 
            // 
            // 
            // 
            this.ViewerQuestions.CustomButton.Image = null;
            this.ViewerQuestions.CustomButton.Location = new System.Drawing.Point(912, 2);
            this.ViewerQuestions.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewerQuestions.CustomButton.Name = "";
            this.ViewerQuestions.CustomButton.Size = new System.Drawing.Size(151, 139);
            this.ViewerQuestions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ViewerQuestions.CustomButton.TabIndex = 1;
            this.ViewerQuestions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ViewerQuestions.CustomButton.UseSelectable = true;
            this.ViewerQuestions.CustomButton.Visible = false;
            this.ViewerQuestions.DisplayIcon = true;
            this.ViewerQuestions.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ViewerQuestions.Lines = new string[0];
            this.ViewerQuestions.Location = new System.Drawing.Point(23, 78);
            this.ViewerQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewerQuestions.MaxLength = 32767;
            this.ViewerQuestions.Name = "ViewerQuestions";
            this.ViewerQuestions.PasswordChar = '\0';
            this.ViewerQuestions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ViewerQuestions.SelectedText = "";
            this.ViewerQuestions.SelectionLength = 0;
            this.ViewerQuestions.SelectionStart = 0;
            this.ViewerQuestions.ShortcutsEnabled = true;
            this.ViewerQuestions.Size = new System.Drawing.Size(800, 118);
            this.ViewerQuestions.TabIndex = 4;
            this.ViewerQuestions.UseSelectable = true;
            this.ViewerQuestions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ViewerQuestions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ViewerAnswers
            // 
            // 
            // 
            // 
            this.ViewerAnswers.CustomButton.Image = null;
            this.ViewerAnswers.CustomButton.Location = new System.Drawing.Point(912, 2);
            this.ViewerAnswers.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewerAnswers.CustomButton.Name = "";
            this.ViewerAnswers.CustomButton.Size = new System.Drawing.Size(151, 139);
            this.ViewerAnswers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ViewerAnswers.CustomButton.TabIndex = 1;
            this.ViewerAnswers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ViewerAnswers.CustomButton.UseSelectable = true;
            this.ViewerAnswers.CustomButton.Visible = false;
            this.ViewerAnswers.DisplayIcon = true;
            this.ViewerAnswers.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ViewerAnswers.Lines = new string[0];
            this.ViewerAnswers.Location = new System.Drawing.Point(23, 212);
            this.ViewerAnswers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewerAnswers.MaxLength = 32767;
            this.ViewerAnswers.Name = "ViewerAnswers";
            this.ViewerAnswers.PasswordChar = '\0';
            this.ViewerAnswers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ViewerAnswers.SelectedText = "";
            this.ViewerAnswers.SelectionLength = 0;
            this.ViewerAnswers.SelectionStart = 0;
            this.ViewerAnswers.ShortcutsEnabled = true;
            this.ViewerAnswers.Size = new System.Drawing.Size(800, 118);
            this.ViewerAnswers.TabIndex = 5;
            this.ViewerAnswers.UseSelectable = true;
            this.ViewerAnswers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ViewerAnswers.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ViewerAnswers.Click += new System.EventHandler(this.ViewerAnswers_Click);
            // 
            // Test
            // 
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 418);
            this.Controls.Add(this.ViewerAnswers);
            this.Controls.Add(this.ViewerQuestions);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.ShowNext);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.ShowAnswer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(853, 418);
            this.MinimumSize = new System.Drawing.Size(853, 418);
            this.Name = "Test";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Run_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestStyle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenCards;
        private MetroFramework.Controls.MetroButton ShowAnswer;
        private MetroFramework.Controls.MetroButton OpenFile;
        private MetroFramework.Controls.MetroButton ShowNext;
        private MetroFramework.Controls.MetroButton SaveFile;
        private System.Windows.Forms.SaveFileDialog SaveCards;
        protected MetroFramework.Components.MetroStyleManager TestStyle;
        private MetroFramework.Controls.MetroTextBox ViewerQuestions;
        private MetroFramework.Controls.MetroTextBox ViewerAnswers;
    }
}