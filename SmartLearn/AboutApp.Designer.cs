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
            this.GitHubLink = new MetroFramework.Controls.MetroLink();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.AboutAppStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AboutAppStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // GitHubLink
            // 
            this.GitHubLink.Location = new System.Drawing.Point(306, 351);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(211, 51);
            this.GitHubLink.TabIndex = 0;
            this.GitHubLink.Text = "Приложение на GitHub";
            this.GitHubLink.UseSelectable = true;
            this.GitHubLink.Click += new System.EventHandler(this.GitHubLink_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(128, 26);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(75, 84);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(646, 261);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "Тут будет инфа ....";
            // 
            // AboutAppStyleManager
            // 
            this.AboutAppStyleManager.Owner = null;
            // 
            // AboutApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.GitHubLink);
            this.Name = "AboutApp";
            this.Text = "AboutApp";
            this.Load += new System.EventHandler(this.AboutApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AboutAppStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
     
        private MetroFramework.Controls.MetroLink GitHubLink;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        protected MetroFramework.Components.MetroStyleManager AboutAppStyleManager;
    }
}