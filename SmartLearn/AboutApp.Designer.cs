namespace SmartLearn
{
    partial class AboutApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutApp));
            this.GitHubLink = new MetroFramework.Controls.MetroLink();
            this.AboutAppStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TextAboutApp = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AboutAppStyleManager)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GitHubLink
            // 
            this.GitHubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHubLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.GitHubLink.Location = new System.Drawing.Point(0, 13);
            this.GitHubLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(144, 28);
            this.GitHubLink.TabIndex = 0;
            this.GitHubLink.Text = "GitHub проекта";
            this.GitHubLink.UseSelectable = true;
            this.GitHubLink.Click += new System.EventHandler(this.GitHubLink_Click);
            // 
            // AboutAppStyleManager
            // 
            this.AboutAppStyleManager.Owner = null;
            // 
            // TextAboutApp
            // 
            // 
            // 
            // 
            this.TextAboutApp.CustomButton.Image = null;
            this.TextAboutApp.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.TextAboutApp.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextAboutApp.CustomButton.Name = "";
            this.TextAboutApp.CustomButton.Size = new System.Drawing.Size(161, 175);
            this.TextAboutApp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextAboutApp.CustomButton.TabIndex = 1;
            this.TextAboutApp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextAboutApp.CustomButton.UseSelectable = true;
            this.TextAboutApp.CustomButton.Visible = false;
            this.TextAboutApp.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TextAboutApp.Lines = new string[] {
        "",
        "SmartLearn — это программа для улучшения запоминания информации, основанная на ме" +
            "тоде интервальных повторений. Бесплатная и с открытым исходным кодом.",
        "",
        "Над приложением работали: Дамир Иваев, Данил Шеренков, Алексей Альгашев, Вероника" +
            " Прудовская"};
            this.TextAboutApp.Location = new System.Drawing.Point(38, 83);
            this.TextAboutApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextAboutApp.MaxLength = 32767;
            this.TextAboutApp.Multiline = true;
            this.TextAboutApp.Name = "TextAboutApp";
            this.TextAboutApp.PasswordChar = '\0';
            this.TextAboutApp.ReadOnly = true;
            this.TextAboutApp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextAboutApp.SelectedText = "";
            this.TextAboutApp.SelectionLength = 0;
            this.TextAboutApp.SelectionStart = 0;
            this.TextAboutApp.ShortcutsEnabled = true;
            this.TextAboutApp.Size = new System.Drawing.Size(530, 220);
            this.TextAboutApp.TabIndex = 11;
            this.TextAboutApp.TabStop = false;
            this.TextAboutApp.Text = resources.GetString("TextAboutApp.Text");
            this.TextAboutApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextAboutApp.UseSelectable = true;
            this.TextAboutApp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextAboutApp.WaterMarkFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAboutApp.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GitHubLink);
            this.panel1.Location = new System.Drawing.Point(231, 272);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 57);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AboutApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextAboutApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutApp";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.AboutApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AboutAppStyleManager)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
     
        private MetroFramework.Controls.MetroLink GitHubLink;
        protected MetroFramework.Components.MetroStyleManager AboutAppStyleManager;
        private MetroFramework.Controls.MetroTextBox TextAboutApp;
        private System.Windows.Forms.Panel panel1;
    }
}