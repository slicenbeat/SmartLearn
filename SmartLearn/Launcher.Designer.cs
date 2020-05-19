using MetroFramework.Forms;
using MetroFramework.Components;
namespace SmartLearn
{
    partial class SmartLearn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartLearn));
            this.MainStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CheckTheme = new MetroFramework.Controls.MetroCheckBox();
            this.LearningButton = new MetroFramework.Controls.MetroButton();
            this.ButtonHelp = new MetroFramework.Controls.MetroLink();
            this.MyDecks = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // MainStyle
            // 
            this.MainStyle.Owner = this;
            // 
            // CheckTheme
            // 
            this.CheckTheme.AutoSize = true;
            this.CheckTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckTheme.Location = new System.Drawing.Point(319, 396);
            this.CheckTheme.Name = "CheckTheme";
            this.CheckTheme.Size = new System.Drawing.Size(93, 15);
            this.CheckTheme.TabIndex = 7;
            this.CheckTheme.Text = "Тёмная тема";
            this.CheckTheme.UseSelectable = true;
            this.CheckTheme.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // LearningButton
            // 
            this.LearningButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LearningButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LearningButton.Enabled = false;
            this.LearningButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.LearningButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LearningButton.Location = new System.Drawing.Point(152, 63);
            this.LearningButton.Name = "LearningButton";
            this.LearningButton.Size = new System.Drawing.Size(130, 48);
            this.LearningButton.TabIndex = 10;
            this.LearningButton.TabStop = false;
            this.LearningButton.Text = "Учить";
            this.LearningButton.UseSelectable = true;
            this.LearningButton.Visible = false;
            this.LearningButton.Click += new System.EventHandler(this.LearningButton_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHelp.Location = new System.Drawing.Point(17, 391);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(110, 19);
            this.ButtonHelp.TabIndex = 11;
            this.ButtonHelp.Text = "О программе";
            this.ButtonHelp.UseSelectable = true;
            this.ButtonHelp.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // MyDecks
            // 
            this.MyDecks.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MyDecks.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.MyDecks.Location = new System.Drawing.Point(152, 189);
            this.MyDecks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyDecks.Name = "MyDecks";
            this.MyDecks.Size = new System.Drawing.Size(130, 48);
            this.MyDecks.TabIndex = 12;
            this.MyDecks.TabStop = false;
            this.MyDecks.Text = "Мои колоды";
            this.MyDecks.UseSelectable = true;
            this.MyDecks.Click += new System.EventHandler(this.MyDecks_Click);
            // 
            // SmartLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.MyDecks);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.LearningButton);
            this.Controls.Add(this.CheckTheme);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 430);
            this.MinimumSize = new System.Drawing.Size(430, 430);
            this.Name = "SmartLearn";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "SmartLearn";
            this.Load += new System.EventHandler(this.SmartLearn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainStyle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroStyleManager MainStyle;
        private MetroFramework.Controls.MetroCheckBox CheckTheme;
        private MetroFramework.Controls.MetroButton LearningButton;
        private MetroFramework.Controls.MetroLink ButtonHelp;
        private MetroFramework.Controls.MetroButton MyDecks;
    }
}

