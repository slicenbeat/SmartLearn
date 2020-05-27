namespace SmartLearn
{
    partial class PomodoroSettings
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
            this.trackPomodoroLength = new MetroFramework.Controls.MetroTrackBar();
            this.trackShortBreak = new MetroFramework.Controls.MetroTrackBar();
            this.trackLongBreak = new MetroFramework.Controls.MetroTrackBar();
            this.checkboxNotify = new MetroFramework.Controls.MetroCheckBox();
            this.lPomodoroLength = new MetroFramework.Controls.MetroLabel();
            this.lShortBreak = new MetroFramework.Controls.MetroLabel();
            this.lLongBreak = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // trackPomodoroLength
            // 
            this.trackPomodoroLength.BackColor = System.Drawing.Color.Transparent;
            this.trackPomodoroLength.Location = new System.Drawing.Point(269, 89);
            this.trackPomodoroLength.Maximum = 120;
            this.trackPomodoroLength.Minimum = 10;
            this.trackPomodoroLength.Name = "trackPomodoroLength";
            this.trackPomodoroLength.Size = new System.Drawing.Size(162, 23);
            this.trackPomodoroLength.TabIndex = 0;
            this.trackPomodoroLength.Value = 25;
            // 
            // trackShortBreak
            // 
            this.trackShortBreak.BackColor = System.Drawing.Color.Transparent;
            this.trackShortBreak.Location = new System.Drawing.Point(269, 127);
            this.trackShortBreak.Maximum = 30;
            this.trackShortBreak.Minimum = 5;
            this.trackShortBreak.Name = "trackShortBreak";
            this.trackShortBreak.Size = new System.Drawing.Size(162, 23);
            this.trackShortBreak.TabIndex = 1;
            this.trackShortBreak.Value = 5;
            // 
            // trackLongBreak
            // 
            this.trackLongBreak.BackColor = System.Drawing.Color.Transparent;
            this.trackLongBreak.Location = new System.Drawing.Point(269, 163);
            this.trackLongBreak.Maximum = 60;
            this.trackLongBreak.Minimum = 15;
            this.trackLongBreak.Name = "trackLongBreak";
            this.trackLongBreak.Size = new System.Drawing.Size(162, 23);
            this.trackLongBreak.TabIndex = 2;
            this.trackLongBreak.Value = 15;
            // 
            // checkboxNotify
            // 
            this.checkboxNotify.AutoSize = true;
            this.checkboxNotify.Location = new System.Drawing.Point(23, 222);
            this.checkboxNotify.Name = "checkboxNotify";
            this.checkboxNotify.Size = new System.Drawing.Size(75, 15);
            this.checkboxNotify.TabIndex = 3;
            this.checkboxNotify.Text = "Напомни";
            this.checkboxNotify.UseSelectable = true;
            // 
            // lPomodoroLength
            // 
            this.lPomodoroLength.AutoSize = true;
            this.lPomodoroLength.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lPomodoroLength.Location = new System.Drawing.Point(23, 89);
            this.lPomodoroLength.Name = "lPomodoroLength";
            this.lPomodoroLength.Size = new System.Drawing.Size(129, 19);
            this.lPomodoroLength.TabIndex = 4;
            this.lPomodoroLength.Text = "Время помидорки:";
            this.lPomodoroLength.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lShortBreak
            // 
            this.lShortBreak.AutoSize = true;
            this.lShortBreak.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lShortBreak.Location = new System.Drawing.Point(23, 127);
            this.lShortBreak.Name = "lShortBreak";
            this.lShortBreak.Size = new System.Drawing.Size(187, 19);
            this.lShortBreak.TabIndex = 5;
            this.lShortBreak.Text = "Время короткого перерыва:";
            this.lShortBreak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLongBreak
            // 
            this.lLongBreak.AutoSize = true;
            this.lLongBreak.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lLongBreak.Location = new System.Drawing.Point(23, 167);
            this.lLongBreak.Name = "lLongBreak";
            this.lLongBreak.Size = new System.Drawing.Size(182, 19);
            this.lLongBreak.TabIndex = 6;
            this.lLongBreak.Text = "Время длинного перерыва:";
            this.lLongBreak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(356, 211);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 26);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Старт";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PomodoroSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 266);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lLongBreak);
            this.Controls.Add(this.lShortBreak);
            this.Controls.Add(this.lPomodoroLength);
            this.Controls.Add(this.checkboxNotify);
            this.Controls.Add(this.trackLongBreak);
            this.Controls.Add(this.trackShortBreak);
            this.Controls.Add(this.trackPomodoroLength);
            this.Name = "PomodoroSettings";
            this.Text = "Настройки помидорки";
            this.Load += new System.EventHandler(this.PomodoroSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTrackBar trackPomodoroLength;
        private MetroFramework.Controls.MetroTrackBar trackShortBreak;
        private MetroFramework.Controls.MetroTrackBar trackLongBreak;
        private MetroFramework.Controls.MetroCheckBox checkboxNotify;
        private MetroFramework.Controls.MetroLabel lPomodoroLength;
        private MetroFramework.Controls.MetroLabel lShortBreak;
        private MetroFramework.Controls.MetroLabel lLongBreak;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}