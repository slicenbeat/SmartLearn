namespace SmartLearn
{
    partial class EditCardList
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
            this.cListQA = new MetroFramework.Controls.MetroComboBox();
            this.bAddCard = new MetroFramework.Controls.MetroButton();
            this.bDeleteCard = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cListQA
            // 
            this.cListQA.FormattingEnabled = true;
            this.cListQA.ItemHeight = 24;
            this.cListQA.Location = new System.Drawing.Point(31, 138);
            this.cListQA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cListQA.Name = "cListQA";
            this.cListQA.Size = new System.Drawing.Size(580, 30);
            this.cListQA.TabIndex = 0;
            this.cListQA.UseSelectable = true;
            // 
            // bAddCard
            // 
            this.bAddCard.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bAddCard.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bAddCard.Location = new System.Drawing.Point(31, 230);
            this.bAddCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAddCard.Name = "bAddCard";
            this.bAddCard.Size = new System.Drawing.Size(199, 28);
            this.bAddCard.TabIndex = 1;
            this.bAddCard.TabStop = false;
            this.bAddCard.Text = "Добавить карточку";
            this.bAddCard.UseSelectable = true;
            this.bAddCard.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bDeleteCard
            // 
            this.bDeleteCard.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bDeleteCard.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bDeleteCard.Location = new System.Drawing.Point(413, 230);
            this.bDeleteCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDeleteCard.Name = "bDeleteCard";
            this.bDeleteCard.Size = new System.Drawing.Size(199, 28);
            this.bDeleteCard.TabIndex = 2;
            this.bDeleteCard.TabStop = false;
            this.bDeleteCard.Text = "Удалить карточку";
            this.bDeleteCard.UseSelectable = true;
            // 
            // EditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 293);
            this.Controls.Add(this.bDeleteCard);
            this.Controls.Add(this.bAddCard);
            this.Controls.Add(this.cListQA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(631, 293);
            this.Name = "EditCardList";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Редактировать колоду";
            this.Load += new System.EventHandler(this.EditCardList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cListQA;
        private MetroFramework.Controls.MetroButton bAddCard;
        private MetroFramework.Controls.MetroButton bDeleteCard;
    }
}