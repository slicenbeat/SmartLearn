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
            this.AddCardList = new MetroFramework.Controls.MetroButton();
            this.CardListComboBox = new MetroFramework.Controls.MetroComboBox();
            this.bLearnCardList = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // AddCardList
            // 
            this.AddCardList.Location = new System.Drawing.Point(40, 182);
            this.AddCardList.Name = "AddCardList";
            this.AddCardList.Size = new System.Drawing.Size(132, 35);
            this.AddCardList.TabIndex = 0;
            this.AddCardList.Text = "Создать колоду";
            this.AddCardList.UseSelectable = true;
            this.AddCardList.Click += new System.EventHandler(this.AddCardList_Click);
            // 
            // CardListComboBox
            // 
            this.CardListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CardListComboBox.FormattingEnabled = true;
            this.CardListComboBox.ItemHeight = 23;
            this.CardListComboBox.Location = new System.Drawing.Point(170, 98);
            this.CardListComboBox.Name = "CardListComboBox";
            this.CardListComboBox.Size = new System.Drawing.Size(273, 29);
            this.CardListComboBox.TabIndex = 1;
            this.CardListComboBox.UseSelectable = true;
            this.CardListComboBox.SelectedIndexChanged += new System.EventHandler(this.CardListComboBox_SelectedIndexChanged);
            // 
            // bLearnCardList
            // 
            this.bLearnCardList.Location = new System.Drawing.Point(178, 182);
            this.bLearnCardList.Name = "bLearnCardList";
            this.bLearnCardList.Size = new System.Drawing.Size(132, 35);
            this.bLearnCardList.TabIndex = 2;
            this.bLearnCardList.Text = "Учить колоду";
            this.bLearnCardList.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(454, 182);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(132, 35);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Удалить колоду";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(316, 182);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(132, 35);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Редактировать колоду";
            this.metroButton2.UseSelectable = true;
            // 
            // MyCardLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 259);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.bLearnCardList);
            this.Controls.Add(this.CardListComboBox);
            this.Controls.Add(this.AddCardList);
            this.Name = "MyCardLists";
            this.Text = "Мои колоды";
            this.Load += new System.EventHandler(this.MyCardLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton AddCardList;
        public MetroFramework.Controls.MetroComboBox CardListComboBox;
        private MetroFramework.Controls.MetroButton bLearnCardList;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}