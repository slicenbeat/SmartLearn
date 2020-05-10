namespace SmartLearn
{
    partial class MyCardLists
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
            this.CardListComboBox = new MetroFramework.Controls.MetroComboBox();
            this.bNewCardList = new MetroFramework.Controls.MetroLink();
            this.bEditCardList = new MetroFramework.Controls.MetroLink();
            this.bLearnCardList = new MetroFramework.Controls.MetroLink();
            this.bDeleteCardList = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // CardListComboBox
            // 
            this.CardListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CardListComboBox.DropDownHeight = 100;
            this.CardListComboBox.FormattingEnabled = true;
            this.CardListComboBox.IntegralHeight = false;
            this.CardListComboBox.ItemHeight = 23;
            this.CardListComboBox.Location = new System.Drawing.Point(23, 63);
            this.CardListComboBox.Name = "CardListComboBox";
            this.CardListComboBox.Size = new System.Drawing.Size(411, 29);
            this.CardListComboBox.TabIndex = 1;
            this.CardListComboBox.UseSelectable = true;
            this.CardListComboBox.SelectedIndexChanged += new System.EventHandler(this.CardListComboBox_SelectedIndexChanged);
            // 
            // bNewCardList
            // 
            this.bNewCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bNewCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bNewCardList.Location = new System.Drawing.Point(309, 28);
            this.bNewCardList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bNewCardList.Name = "bNewCardList";
            this.bNewCardList.Size = new System.Drawing.Size(60, 20);
            this.bNewCardList.TabIndex = 9;
            this.bNewCardList.Text = "Создать";
            this.bNewCardList.UseSelectable = true;
            this.bNewCardList.Click += new System.EventHandler(this.bNewCardList_Click);
            // 
            // bEditCardList
            // 
            this.bEditCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bEditCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bEditCardList.Location = new System.Drawing.Point(230, 28);
            this.bEditCardList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bEditCardList.Name = "bEditCardList";
            this.bEditCardList.Size = new System.Drawing.Size(75, 20);
            this.bEditCardList.TabIndex = 10;
            this.bEditCardList.Text = "Изменить";
            this.bEditCardList.UseSelectable = true;
            this.bEditCardList.Click += new System.EventHandler(this.bEditCardList_Click);
            // 
            // bLearnCardList
            // 
            this.bLearnCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLearnCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bLearnCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bLearnCardList.Location = new System.Drawing.Point(175, 28);
            this.bLearnCardList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bLearnCardList.Name = "bLearnCardList";
            this.bLearnCardList.Size = new System.Drawing.Size(51, 20);
            this.bLearnCardList.TabIndex = 11;
            this.bLearnCardList.Text = "Учить";
            this.bLearnCardList.UseSelectable = true;
            this.bLearnCardList.Click += new System.EventHandler(this.bLearnCardList_Click);
            // 
            // bDeleteCardList
            // 
            this.bDeleteCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bDeleteCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bDeleteCardList.Location = new System.Drawing.Point(373, 28);
            this.bDeleteCardList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bDeleteCardList.Name = "bDeleteCardList";
            this.bDeleteCardList.Size = new System.Drawing.Size(60, 20);
            this.bDeleteCardList.TabIndex = 12;
            this.bDeleteCardList.Text = "Удалить";
            this.bDeleteCardList.UseSelectable = true;
            this.bDeleteCardList.Click += new System.EventHandler(this.bDeleteCardList_Click);
            // 
            // MyCardLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 123);
            this.Controls.Add(this.bDeleteCardList);
            this.Controls.Add(this.bLearnCardList);
            this.Controls.Add(this.bEditCardList);
            this.Controls.Add(this.bNewCardList);
            this.Controls.Add(this.CardListComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 123);
            this.MinimumSize = new System.Drawing.Size(455, 123);
            this.Name = "MyCardLists";
            this.Text = "Мои колоды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyCardLists_FormClosing);
            this.Load += new System.EventHandler(this.MyCardLists_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroComboBox CardListComboBox;
        private MetroFramework.Controls.MetroLink bNewCardList;
        private MetroFramework.Controls.MetroLink bEditCardList;
        private MetroFramework.Controls.MetroLink bLearnCardList;
        private MetroFramework.Controls.MetroLink bDeleteCardList;
    }
}