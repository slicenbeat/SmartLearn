using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;


namespace SmartLearn
{
    public partial class PomodoroSettings : MetroForm
    {
        Thread th;
        public Pomodoro pomodoro;
        bool Save;
        public PomodoroSettings()
        {
            InitializeComponent();
        }
        private void PomodoroSettings_Load(object sender, EventArgs e)
        {
            checkboxNotify.Checked = true;
            lLongBreak.StyleManager = this.StyleManager;
            lShortBreak.StyleManager = this.StyleManager;
            lPomodoroLength.StyleManager = this.StyleManager;
            trackLongBreak.StyleManager = this.StyleManager;
            trackPomodoroLength.StyleManager = this.StyleManager;
            trackShortBreak.StyleManager = this.StyleManager;
            checkboxNotify.StyleManager = this.StyleManager;
            bStartPomodoroForm.StyleManager = this.StyleManager;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Save = true;
            pomodoro = new Pomodoro(trackPomodoroLength.Value, trackShortBreak.Value, trackLongBreak.Value, checkboxNotify.Checked);
            Close();
        }

        private void trackPomodoroLength_Scroll(object sender, ScrollEventArgs e)
        {
            var now = trackPomodoroLength.Value.ToString();
            lPomodoroLength.Text = "Время помидорки: " + now;
        }

        private void trackShortBreak_Scroll(object sender, ScrollEventArgs e)
        {
            var now = trackShortBreak.Value.ToString();
            lShortBreak.Text = "Время короткого перерыва: " + now;
        }

        private void trackLongBreak_Scroll(object sender, ScrollEventArgs e)
        {
            var now = trackLongBreak.Value.ToString();
            lLongBreak.Text = "Время длинного перерыва: " + now;
            
        }

        private void PomodoroSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save) { }
            else 
            {
                pomodoro = new Pomodoro(trackPomodoroLength.Value, trackShortBreak.Value, trackLongBreak.Value, checkboxNotify.Checked);
            }

        }

        private void PomodoroSettings_DragOver(object sender, DragEventArgs e)
        {

        }

        private void checkboxNotify_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
