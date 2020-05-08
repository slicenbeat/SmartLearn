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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutApp));
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
            this.CardListComboBox.FormattingEnabled = true;
            this.CardListComboBox.ItemHeight = 23;
            this.CardListComboBox.Location = new System.Drawing.Point(260, 160);
            this.CardListComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CardListComboBox.Name = "CardListComboBox";
            this.CardListComboBox.Size = new System.Drawing.Size(408, 29);
            this.CardListComboBox.TabIndex = 1;
            this.CardListComboBox.UseSelectable = true;
            this.CardListComboBox.SelectedIndexChanged += new System.EventHandler(this.CardListComboBox_SelectedIndexChanged);
            // 
            // bNewCardList
            // 
            this.bNewCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bNewCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bNewCardList.Location = new System.Drawing.Point(231, 50);
            this.bNewCardList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bNewCardList.Name = "bNewCardList";
            this.bNewCardList.Size = new System.Drawing.Size(183, 29);
            this.bNewCardList.TabIndex = 9;
            this.bNewCardList.Text = "Создать колоду";
            this.bNewCardList.UseSelectable = true;
            this.bNewCardList.Click += new System.EventHandler(this.bNewCardList_Click);
            // 
            // bEditCardList
            // 
            this.bEditCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bEditCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bEditCardList.Location = new System.Drawing.Point(281, 242);
            this.bEditCardList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEditCardList.Name = "bEditCardList";
            this.bEditCardList.Size = new System.Drawing.Size(165, 51);
            this.bEditCardList.TabIndex = 10;
            this.bEditCardList.Text = "Редактировать";
            this.bEditCardList.UseSelectable = true;
            this.bEditCardList.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // bLearnCardList
            // 
            this.bLearnCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLearnCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bLearnCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bLearnCardList.Location = new System.Drawing.Point(117, 160);
            this.bLearnCardList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bLearnCardList.Name = "bLearnCardList";
            this.bLearnCardList.Size = new System.Drawing.Size(135, 38);
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
            this.bDeleteCardList.Location = new System.Drawing.Point(453, 242);
            this.bDeleteCardList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDeleteCardList.Name = "bDeleteCardList";
            this.bDeleteCardList.Size = new System.Drawing.Size(205, 51);
            this.bDeleteCardList.TabIndex = 12;
            this.bDeleteCardList.Text = "Удалить";
            this.bDeleteCardList.UseSelectable = true;
            this.bDeleteCardList.Click += new System.EventHandler(this.bDeleteCardList_Click);
            // 
            // MyCardLists
            // 
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 399);
            this.Controls.Add(this.bDeleteCardList);
            this.Controls.Add(this.bLearnCardList);
            this.Controls.Add(this.bEditCardList);
            this.Controls.Add(this.bNewCardList);
            this.Controls.Add(this.CardListComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 399);
            this.MinimumSize = new System.Drawing.Size(844, 399);
            this.Name = "MyCardLists";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Мои колоды";
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