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
            this.SuspendLayout();
            // 
            // AddCardList
            // 
            this.AddCardList.Location = new System.Drawing.Point(255, 566);
            this.AddCardList.Name = "AddCardList";
            this.AddCardList.Size = new System.Drawing.Size(139, 60);
            this.AddCardList.TabIndex = 0;
            this.AddCardList.Text = "Добавить колоду";
            this.AddCardList.UseSelectable = true;
            this.AddCardList.Click += new System.EventHandler(this.AddCardList_Click);
            // 
            // MyCardLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.AddCardList);
            this.MaximumSize = new System.Drawing.Size(640, 640);
            this.MinimumSize = new System.Drawing.Size(640, 640);
            this.Name = "MyCardLists";
            this.Text = "Мои колоды";
            this.Load += new System.EventHandler(this.MyCardLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton AddCardList;
    }
}