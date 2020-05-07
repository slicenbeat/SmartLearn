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
            this.bImportCardList = new MetroFramework.Controls.MetroLink();
            this.bExportCardList = new MetroFramework.Controls.MetroLink();
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
            this.CardListComboBox.ItemHeight = 24;
            this.CardListComboBox.Location = new System.Drawing.Point(231, 128);
            this.CardListComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CardListComboBox.Name = "CardListComboBox";
            this.CardListComboBox.Size = new System.Drawing.Size(363, 30);
            this.CardListComboBox.TabIndex = 1;
            this.CardListComboBox.UseSelectable = true;
            this.CardListComboBox.SelectedIndexChanged += new System.EventHandler(this.CardListComboBox_SelectedIndexChanged);
            // 
            // bImportCardList
            // 
            this.bImportCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bImportCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bImportCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bImportCardList.Location = new System.Drawing.Point(349, 40);
            this.bImportCardList.Name = "bImportCardList";
            this.bImportCardList.Size = new System.Drawing.Size(194, 23);
            this.bImportCardList.TabIndex = 7;
            this.bImportCardList.Text = "Загрузить колоду";
            this.bImportCardList.UseSelectable = true;
            this.bImportCardList.Click += new System.EventHandler(this.bImportCardList_Click);
            // 
            // bExportCardList
            // 
            this.bExportCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExportCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bExportCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bExportCardList.Location = new System.Drawing.Point(521, 40);
            this.bExportCardList.Name = "bExportCardList";
            this.bExportCardList.Size = new System.Drawing.Size(209, 23);
            this.bExportCardList.TabIndex = 8;
            this.bExportCardList.Text = "Выгрузить колоду";
            this.bExportCardList.UseSelectable = true;
            this.bExportCardList.Click += new System.EventHandler(this.bExportCardList_Click);
            // 
            // bNewCardList
            // 
            this.bNewCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bNewCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bNewCardList.Location = new System.Drawing.Point(205, 40);
            this.bNewCardList.Name = "bNewCardList";
            this.bNewCardList.Size = new System.Drawing.Size(163, 23);
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
            this.bEditCardList.Location = new System.Drawing.Point(250, 194);
            this.bEditCardList.Name = "bEditCardList";
            this.bEditCardList.Size = new System.Drawing.Size(147, 41);
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
            this.bLearnCardList.Location = new System.Drawing.Point(104, 128);
            this.bLearnCardList.Name = "bLearnCardList";
            this.bLearnCardList.Size = new System.Drawing.Size(120, 30);
            this.bLearnCardList.TabIndex = 11;
            this.bLearnCardList.Text = "Учить";
            this.bLearnCardList.UseSelectable = true;
            // 
            // bDeleteCardList
            // 
            this.bDeleteCardList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteCardList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bDeleteCardList.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.bDeleteCardList.Location = new System.Drawing.Point(403, 194);
            this.bDeleteCardList.Name = "bDeleteCardList";
            this.bDeleteCardList.Size = new System.Drawing.Size(182, 41);
            this.bDeleteCardList.TabIndex = 12;
            this.bDeleteCardList.Text = "Удалить";
            this.bDeleteCardList.UseSelectable = true;
            this.bDeleteCardList.Click += new System.EventHandler(this.bDeleteCardList_Click);
            // 
            // MyCardLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 319);
            this.Controls.Add(this.bDeleteCardList);
            this.Controls.Add(this.bLearnCardList);
            this.Controls.Add(this.bEditCardList);
            this.Controls.Add(this.bNewCardList);
            this.Controls.Add(this.bExportCardList);
            this.Controls.Add(this.bImportCardList);
            this.Controls.Add(this.CardListComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 319);
            this.MinimumSize = new System.Drawing.Size(750, 319);
            this.Name = "MyCardLists";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Мои колоды";
            this.Load += new System.EventHandler(this.MyCardLists_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroComboBox CardListComboBox;
        private MetroFramework.Controls.MetroLink bImportCardList;
        private MetroFramework.Controls.MetroLink bExportCardList;
        private MetroFramework.Controls.MetroLink bNewCardList;
        private MetroFramework.Controls.MetroLink bEditCardList;
        private MetroFramework.Controls.MetroLink bLearnCardList;
        private MetroFramework.Controls.MetroLink bDeleteCardList;
    }
}