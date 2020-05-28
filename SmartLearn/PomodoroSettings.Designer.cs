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
            this.bStartPomodoroForm = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // trackPomodoroLength
            // 
            this.trackPomodoroLength.BackColor = System.Drawing.Color.Transparent;
            this.trackPomodoroLength.Location = new System.Drawing.Point(279, 89);
            this.trackPomodoroLength.Maximum = 120;
            this.trackPomodoroLength.Minimum = 10;
            this.trackPomodoroLength.Name = "trackPomodoroLength";
            this.trackPomodoroLength.Size = new System.Drawing.Size(162, 23);
            this.trackPomodoroLength.TabIndex = 0;
            this.trackPomodoroLength.Value = 25;
            this.trackPomodoroLength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackPomodoroLength_Scroll);
            // 
            // trackShortBreak
            // 
            this.trackShortBreak.BackColor = System.Drawing.Color.Transparent;
            this.trackShortBreak.Location = new System.Drawing.Point(279, 127);
            this.trackShortBreak.Maximum = 30;
            this.trackShortBreak.Minimum = 5;
            this.trackShortBreak.Name = "trackShortBreak";
            this.trackShortBreak.Size = new System.Drawing.Size(162, 23);
            this.trackShortBreak.TabIndex = 1;
            this.trackShortBreak.Value = 5;
            this.trackShortBreak.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackShortBreak_Scroll);
            // 
            // trackLongBreak
            // 
            this.trackLongBreak.BackColor = System.Drawing.Color.Transparent;
            this.trackLongBreak.Location = new System.Drawing.Point(279, 167);
            this.trackLongBreak.Maximum = 60;
            this.trackLongBreak.Minimum = 15;
            this.trackLongBreak.Name = "trackLongBreak";
            this.trackLongBreak.Size = new System.Drawing.Size(162, 23);
            this.trackLongBreak.TabIndex = 2;
            this.trackLongBreak.Value = 15;
            this.trackLongBreak.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackLongBreak_Scroll);
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
            this.lPomodoroLength.Size = new System.Drawing.Size(149, 19);
            this.lPomodoroLength.TabIndex = 4;
            this.lPomodoroLength.Text = "Время помидорки: 25";
            this.lPomodoroLength.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lShortBreak
            // 
            this.lShortBreak.AutoSize = true;
            this.lShortBreak.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lShortBreak.Location = new System.Drawing.Point(23, 127);
            this.lShortBreak.Name = "lShortBreak";
            this.lShortBreak.Size = new System.Drawing.Size(199, 19);
            this.lShortBreak.TabIndex = 5;
            this.lShortBreak.Text = "Время короткого перерыва: 5";
            this.lShortBreak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLongBreak
            // 
            this.lLongBreak.AutoSize = true;
            this.lLongBreak.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lLongBreak.Location = new System.Drawing.Point(23, 167);
            this.lLongBreak.Name = "lLongBreak";
            this.lLongBreak.Size = new System.Drawing.Size(202, 19);
            this.lLongBreak.TabIndex = 6;
            this.lLongBreak.Text = "Время длинного перерыва: 15";
            this.lLongBreak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bStartPomodoroForm
            // 
            this.bStartPomodoroForm.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bStartPomodoroForm.Location = new System.Drawing.Point(356, 211);
            this.bStartPomodoroForm.Name = "bStartPomodoroForm";
            this.bStartPomodoroForm.Size = new System.Drawing.Size(75, 26);
            this.bStartPomodoroForm.TabIndex = 7;
            this.bStartPomodoroForm.Text = "Сохранить";
            this.bStartPomodoroForm.UseSelectable = true;
            this.bStartPomodoroForm.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PomodoroSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 266);
            this.Controls.Add(this.bStartPomodoroForm);
            this.Controls.Add(this.lLongBreak);
            this.Controls.Add(this.lShortBreak);
            this.Controls.Add(this.lPomodoroLength);
            this.Controls.Add(this.checkboxNotify);
            this.Controls.Add(this.trackLongBreak);
            this.Controls.Add(this.trackShortBreak);
            this.Controls.Add(this.trackPomodoroLength);
            this.DoubleBuffered = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(464, 266);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(464, 266);
            this.Movable = false;
            this.Name = "PomodoroSettings";
            this.Text = "Настройки помидорки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PomodoroSettings_FormClosing);
            this.Load += new System.EventHandler(this.PomodoroSettings_Load);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.PomodoroSettings_DragOver);
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
        private MetroFramework.Controls.MetroButton bStartPomodoroForm;
    }
}