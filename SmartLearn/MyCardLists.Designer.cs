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
            this.bAddCardList = new MetroFramework.Controls.MetroButton();
            this.CardListComboBox = new MetroFramework.Controls.MetroComboBox();
            this.bLearnCardList = new MetroFramework.Controls.MetroButton();
            this.bDeleteCardList = new MetroFramework.Controls.MetroButton();
            this.bEditCardList = new MetroFramework.Controls.MetroButton();
            this.bImportCardList = new MetroFramework.Controls.MetroButton();
            this.bExportCardList = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bAddCardList
            // 
            this.bAddCardList.Location = new System.Drawing.Point(35, 155);
            this.bAddCardList.Name = "bAddCardList";
            this.bAddCardList.Size = new System.Drawing.Size(132, 35);
            this.bAddCardList.TabIndex = 0;
            this.bAddCardList.Text = "Создать колоду";
            this.bAddCardList.UseSelectable = true;
            this.bAddCardList.Click += new System.EventHandler(this.AddCardList_Click);
            // 
            // CardListComboBox
            // 
            this.CardListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CardListComboBox.FormattingEnabled = true;
            this.CardListComboBox.ItemHeight = 23;
            this.CardListComboBox.Location = new System.Drawing.Point(170, 104);
            this.CardListComboBox.Name = "CardListComboBox";
            this.CardListComboBox.Size = new System.Drawing.Size(273, 29);
            this.CardListComboBox.TabIndex = 1;
            this.CardListComboBox.UseSelectable = true;
            this.CardListComboBox.SelectedIndexChanged += new System.EventHandler(this.CardListComboBox_SelectedIndexChanged);
            // 
            // bLearnCardList
            // 
            this.bLearnCardList.Location = new System.Drawing.Point(242, 155);
            this.bLearnCardList.Name = "bLearnCardList";
            this.bLearnCardList.Size = new System.Drawing.Size(132, 35);
            this.bLearnCardList.TabIndex = 2;
            this.bLearnCardList.Text = "Учить колоду";
            this.bLearnCardList.UseSelectable = true;
            this.bLearnCardList.Click += new System.EventHandler(this.bLearnCardList_Click);
            // 
            // bDeleteCardList
            // 
            this.bDeleteCardList.Location = new System.Drawing.Point(35, 201);
            this.bDeleteCardList.Name = "bDeleteCardList";
            this.bDeleteCardList.Size = new System.Drawing.Size(132, 35);
            this.bDeleteCardList.TabIndex = 3;
            this.bDeleteCardList.Text = "Удалить колоду";
            this.bDeleteCardList.UseSelectable = true;
            this.bDeleteCardList.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bEditCardList
            // 
            this.bEditCardList.Location = new System.Drawing.Point(242, 201);
            this.bEditCardList.Name = "bEditCardList";
            this.bEditCardList.Size = new System.Drawing.Size(132, 35);
            this.bEditCardList.TabIndex = 4;
            this.bEditCardList.Text = "Редактировать колоду";
            this.bEditCardList.UseSelectable = true;
            // 
            // bImportCardList
            // 
            this.bImportCardList.Location = new System.Drawing.Point(442, 155);
            this.bImportCardList.Name = "bImportCardList";
            this.bImportCardList.Size = new System.Drawing.Size(132, 35);
            this.bImportCardList.TabIndex = 5;
            this.bImportCardList.Text = "Загрузить колоду";
            this.bImportCardList.UseSelectable = true;
            // 
            // bExportCardList
            // 
            this.bExportCardList.Location = new System.Drawing.Point(442, 201);
            this.bExportCardList.Name = "bExportCardList";
            this.bExportCardList.Size = new System.Drawing.Size(132, 35);
            this.bExportCardList.TabIndex = 6;
            this.bExportCardList.Text = "Выгрузить колоду";
            this.bExportCardList.UseSelectable = true;
            // 
            // MyCardLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 259);
            this.Controls.Add(this.bExportCardList);
            this.Controls.Add(this.bImportCardList);
            this.Controls.Add(this.bEditCardList);
            this.Controls.Add(this.bDeleteCardList);
            this.Controls.Add(this.bLearnCardList);
            this.Controls.Add(this.CardListComboBox);
            this.Controls.Add(this.bAddCardList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 259);
            this.MinimumSize = new System.Drawing.Size(609, 259);
            this.Name = "MyCardLists";
            this.Text = "Мои колоды";
            this.Load += new System.EventHandler(this.MyCardLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bAddCardList;
        public MetroFramework.Controls.MetroComboBox CardListComboBox;
        private MetroFramework.Controls.MetroButton bLearnCardList;
        private MetroFramework.Controls.MetroButton bDeleteCardList;
        private MetroFramework.Controls.MetroButton bEditCardList;
        private MetroFramework.Controls.MetroButton bImportCardList;
        private MetroFramework.Controls.MetroButton bExportCardList;
    }
}