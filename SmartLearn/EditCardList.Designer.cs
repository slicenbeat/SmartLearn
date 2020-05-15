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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCardList));
            this.cListQA = new MetroFramework.Controls.MetroComboBox();
            this.bAddCard = new MetroFramework.Controls.MetroButton();
            this.bDeleteCard = new MetroFramework.Controls.MetroButton();
            this.bEditCard = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cListQA
            // 
            this.cListQA.DropDownHeight = 100;
            this.cListQA.FormattingEnabled = true;
            this.cListQA.IntegralHeight = false;
            this.cListQA.ItemHeight = 24;
            this.cListQA.Location = new System.Drawing.Point(31, 138);
            this.cListQA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cListQA.Name = "cListQA";
            this.cListQA.Size = new System.Drawing.Size(580, 30);
            this.cListQA.TabIndex = 0;
            this.cListQA.UseSelectable = true;
            this.cListQA.SelectedIndexChanged += new System.EventHandler(this.cListQA_SelectedIndexChanged);
            // 
            // bAddCard
            // 
            this.bAddCard.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bAddCard.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bAddCard.Location = new System.Drawing.Point(31, 196);
            this.bAddCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAddCard.Name = "bAddCard";
            this.bAddCard.Size = new System.Drawing.Size(173, 28);
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
            this.bDeleteCard.Location = new System.Drawing.Point(439, 196);
            this.bDeleteCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDeleteCard.Name = "bDeleteCard";
            this.bDeleteCard.Size = new System.Drawing.Size(173, 28);
            this.bDeleteCard.TabIndex = 2;
            this.bDeleteCard.TabStop = false;
            this.bDeleteCard.Text = "Удалить карточку";
            this.bDeleteCard.UseSelectable = true;
            this.bDeleteCard.Click += new System.EventHandler(this.bDeleteCard_Click);
            // 
            // bEditCard
            // 
            this.bEditCard.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bEditCard.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bEditCard.Location = new System.Drawing.Point(232, 196);
            this.bEditCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEditCard.Name = "bEditCard";
            this.bEditCard.Size = new System.Drawing.Size(173, 28);
            this.bEditCard.TabIndex = 3;
            this.bEditCard.TabStop = false;
            this.bEditCard.Text = "Изменить карточку";
            this.bEditCard.UseSelectable = true;
            this.bEditCard.Click += new System.EventHandler(this.ChangeCard_Click_1);
            // 
            // EditCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 249);
            this.Controls.Add(this.bEditCard);
            this.Controls.Add(this.bDeleteCard);
            this.Controls.Add(this.bAddCard);
            this.Controls.Add(this.cListQA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCardList";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Редактировать колоду";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCardList_FormClosing);
            this.Load += new System.EventHandler(this.EditCardList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cListQA;
        private MetroFramework.Controls.MetroButton bAddCard;
        private MetroFramework.Controls.MetroButton bDeleteCard;
        private MetroFramework.Controls.MetroButton bEditCard;
    }
}