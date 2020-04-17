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
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.OpenCards = new System.Windows.Forms.OpenFileDialog();
            this.ShowAnswer = new MetroFramework.Controls.MetroButton();
            this.OpenFile = new MetroFramework.Controls.MetroButton();
            this.ShowNext = new MetroFramework.Controls.MetroButton();
            this.SaveFile = new MetroFramework.Controls.MetroButton();
            this.SaveCards = new System.Windows.Forms.SaveFileDialog();
            this.TestStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TestStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuestion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(17, 63);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(600, 96);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "";
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnswer.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtAnswer.Location = new System.Drawing.Point(17, 165);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(600, 96);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.Text = "";
            this.txtAnswer.Visible = false;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            
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
            this.ShowAnswer.Location = new System.Drawing.Point(17, 274);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(90, 23);
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
            this.OpenFile.Location = new System.Drawing.Point(166, 274);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(125, 23);
            this.OpenFile.TabIndex = 2;
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
            this.ShowNext.Location = new System.Drawing.Point(527, 274);
            this.ShowNext.Name = "ShowNext";
            this.ShowNext.Size = new System.Drawing.Size(90, 23);
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
            this.SaveFile.Location = new System.Drawing.Point(359, 274);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(125, 23);
            this.SaveFile.TabIndex = 3;
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
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.ShowNext);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.ShowAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 320);
            this.MinimumSize = new System.Drawing.Size(640, 320);
            this.Name = "Test";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Run_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestStyle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.OpenFileDialog OpenCards;
        private MetroFramework.Controls.MetroButton ShowAnswer;
        private MetroFramework.Controls.MetroButton OpenFile;
        private MetroFramework.Controls.MetroButton ShowNext;
        private MetroFramework.Controls.MetroButton SaveFile;
        private System.Windows.Forms.SaveFileDialog SaveCards;
        protected MetroFramework.Components.MetroStyleManager TestStyle;
    }
}