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
            this.Test = new MetroFramework.Controls.MetroButton();
            this.MainStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CheckTheme = new MetroFramework.Controls.MetroCheckBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ButtonHelp = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Test
            // 
            this.Test.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Test.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Test.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Test.Location = new System.Drawing.Point(256, 194);
            this.Test.Margin = new System.Windows.Forms.Padding(4);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(328, 144);
            this.Test.TabIndex = 3;
            this.Test.TabStop = false;
            this.Test.Text = "Тест";
            this.Test.UseSelectable = true;
            this.Test.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainStyle
            // 
            this.MainStyle.Owner = this;
            // 
            // CheckTheme
            // 
            this.CheckTheme.AutoSize = true;
            this.CheckTheme.Location = new System.Drawing.Point(699, 489);
            this.CheckTheme.Margin = new System.Windows.Forms.Padding(4);
            this.CheckTheme.Name = "CheckTheme";
            this.CheckTheme.Size = new System.Drawing.Size(100, 17);
            this.CheckTheme.TabIndex = 7;
            this.CheckTheme.Text = "Тёмная тема";
            this.CheckTheme.UseSelectable = true;
            this.CheckTheme.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.Enabled = false;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(197, 22);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(43, 39);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonHelp.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ButtonHelp.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonHelp.Location = new System.Drawing.Point(23, 489);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(102, 25);
            this.ButtonHelp.TabIndex = 9;
            this.ButtonHelp.TabStop = false;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseSelectable = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // SmartLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 530);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.CheckTheme);
            this.Controls.Add(this.Test);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(847, 530);
            this.MinimumSize = new System.Drawing.Size(847, 530);
            this.Name = "SmartLearn";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "SmartLearn";
            this.Load += new System.EventHandler(this.SmartLearn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton Test;
        public MetroStyleManager MainStyle;
        private MetroFramework.Controls.MetroCheckBox CheckTheme;
        private System.Windows.Forms.PictureBox Logo;
        private MetroFramework.Controls.MetroButton ButtonHelp;
    }
}

