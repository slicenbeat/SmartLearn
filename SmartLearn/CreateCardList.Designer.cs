namespace SmartLearn
{
    partial class CreateCardList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCardList));
            this.NameOfCardList = new MetroFramework.Controls.MetroTextBox();
            this.lNameCardList = new MetroFramework.Controls.MetroLabel();
            this.bCreateCardList = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // NameOfCardList
            // 
            // 
            // 
            // 
            this.NameOfCardList.CustomButton.Image = null;
            this.NameOfCardList.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.NameOfCardList.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameOfCardList.CustomButton.Name = "";
            this.NameOfCardList.CustomButton.Size = new System.Drawing.Size(39, 36);
            this.NameOfCardList.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameOfCardList.CustomButton.TabIndex = 1;
            this.NameOfCardList.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameOfCardList.CustomButton.UseSelectable = true;
            this.NameOfCardList.CustomButton.Visible = false;
            this.NameOfCardList.Lines = new string[0];
            this.NameOfCardList.Location = new System.Drawing.Point(269, 42);
            this.NameOfCardList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameOfCardList.MaxLength = 32767;
            this.NameOfCardList.Name = "NameOfCardList";
            this.NameOfCardList.PasswordChar = '\0';
            this.NameOfCardList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameOfCardList.SelectedText = "";
            this.NameOfCardList.SelectionLength = 0;
            this.NameOfCardList.SelectionStart = 0;
            this.NameOfCardList.ShortcutsEnabled = true;
            this.NameOfCardList.Size = new System.Drawing.Size(404, 31);
            this.NameOfCardList.TabIndex = 0;
            this.NameOfCardList.UseSelectable = true;
            this.NameOfCardList.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameOfCardList.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameOfCardList.Click += new System.EventHandler(this.NameOfCardList_Click);
            // 
            // lNameCardList
            // 
            this.lNameCardList.AutoSize = true;
            this.lNameCardList.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lNameCardList.Location = new System.Drawing.Point(31, 43);
            this.lNameCardList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNameCardList.Name = "lNameCardList";
            this.lNameCardList.Size = new System.Drawing.Size(133, 20);
            this.lNameCardList.TabIndex = 1;
            this.lNameCardList.Text = "Название колоды";
            // 
            // bCreateCardList
            // 
            this.bCreateCardList.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bCreateCardList.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bCreateCardList.Location = new System.Drawing.Point(429, 108);
            this.bCreateCardList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCreateCardList.Name = "bCreateCardList";
            this.bCreateCardList.Size = new System.Drawing.Size(244, 28);
            this.bCreateCardList.TabIndex = 2;
            this.bCreateCardList.Text = "Создать";
            this.bCreateCardList.UseSelectable = true;
            this.bCreateCardList.Click += new System.EventHandler(this.bCreateCardList_Click);
            // 
            // CreateCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 165);
            this.Controls.Add(this.bCreateCardList);
            this.Controls.Add(this.lNameCardList);
            this.Controls.Add(this.NameOfCardList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(748, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 165);
            this.Name = "CreateCardList";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.CreateCardList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox NameOfCardList;
        private MetroFramework.Controls.MetroLabel lNameCardList;
        private MetroFramework.Controls.MetroButton bCreateCardList;
    }
}