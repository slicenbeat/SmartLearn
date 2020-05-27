namespace SmartLearn
{
    partial class PomodoroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoroForm));
            this.lTimeNow = new MetroFramework.Controls.MetroLabel();
            this.bStartPomodoro = new MetroFramework.Controls.MetroButton();
            this.bStopPomodoro = new MetroFramework.Controls.MetroButton();
            this.bResetPomodoro = new MetroFramework.Controls.MetroButton();
            this.notifyPomodoro = new System.Windows.Forms.NotifyIcon(this.components);
            this.lStatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lTimeNow
            // 
            this.lTimeNow.AutoSize = true;
            this.lTimeNow.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lTimeNow.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lTimeNow.Location = new System.Drawing.Point(68, 61);
            this.lTimeNow.Name = "lTimeNow";
            this.lTimeNow.Size = new System.Drawing.Size(46, 25);
            this.lTimeNow.TabIndex = 0;
            this.lTimeNow.Text = "0:00";
            // 
            // bStartPomodoro
            // 
            this.bStartPomodoro.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.bStartPomodoro.Location = new System.Drawing.Point(185, 34);
            this.bStartPomodoro.Name = "bStartPomodoro";
            this.bStartPomodoro.Size = new System.Drawing.Size(58, 23);
            this.bStartPomodoro.TabIndex = 1;
            this.bStartPomodoro.TabStop = false;
            this.bStartPomodoro.Text = "Старт";
            this.bStartPomodoro.UseSelectable = true;
            this.bStartPomodoro.Click += new System.EventHandler(this.bStartPomodoro_Click);
            // 
            // bStopPomodoro
            // 
            this.bStopPomodoro.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.bStopPomodoro.Location = new System.Drawing.Point(185, 63);
            this.bStopPomodoro.Name = "bStopPomodoro";
            this.bStopPomodoro.Size = new System.Drawing.Size(58, 23);
            this.bStopPomodoro.TabIndex = 2;
            this.bStopPomodoro.TabStop = false;
            this.bStopPomodoro.Text = "Стоп";
            this.bStopPomodoro.UseSelectable = true;
            this.bStopPomodoro.Click += new System.EventHandler(this.bStopPomodoro_Click);
            // 
            // bResetPomodoro
            // 
            this.bResetPomodoro.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.bResetPomodoro.Location = new System.Drawing.Point(185, 92);
            this.bResetPomodoro.Name = "bResetPomodoro";
            this.bResetPomodoro.Size = new System.Drawing.Size(58, 23);
            this.bResetPomodoro.TabIndex = 3;
            this.bResetPomodoro.TabStop = false;
            this.bResetPomodoro.Text = "Сброс";
            this.bResetPomodoro.UseSelectable = true;
            this.bResetPomodoro.Click += new System.EventHandler(this.bResetPomodoro_Click);
            // 
            // notifyPomodoro
            // 
            this.notifyPomodoro.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyPomodoro.Icon")));
            this.notifyPomodoro.Text = "notify";
            this.notifyPomodoro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyPomodoro_MouseDoubleClick);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(12, 19);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 0);
            this.lStatus.TabIndex = 4;
            // 
            // PomodoroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 135);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bResetPomodoro);
            this.Controls.Add(this.bStopPomodoro);
            this.Controls.Add(this.bStartPomodoro);
            this.Controls.Add(this.lTimeNow);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 135);
            this.MinimumSize = new System.Drawing.Size(266, 135);
            this.Name = "PomodoroForm";
            this.Load += new System.EventHandler(this.PomodoroForm_Load);
            this.Resize += new System.EventHandler(this.PomodoroForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lTimeNow;
        private MetroFramework.Controls.MetroButton bStartPomodoro;
        private MetroFramework.Controls.MetroButton bStopPomodoro;
        private MetroFramework.Controls.MetroButton bResetPomodoro;
        private System.Windows.Forms.NotifyIcon notifyPomodoro;
        private MetroFramework.Controls.MetroLabel lStatus;
    }
}