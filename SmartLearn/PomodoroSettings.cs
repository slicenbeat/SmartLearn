using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace SmartLearn
{
    public partial class PomodoroSettings : MetroForm
    {
        public int PomodoroTimer { private set; get; }
        public int ShortBreak { private set; get; }
        public int LongBreak { private set; get; }
        public bool Notify { private set; get; }
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
            PomodoroTimer = trackPomodoroLength.Value;
            ShortBreak = trackShortBreak.Value;
            LongBreak = trackLongBreak.Value;
            Notify = checkboxNotify.Checked;
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
            PomodoroTimer = trackPomodoroLength.Value;
            ShortBreak = trackShortBreak.Value;
            LongBreak = trackLongBreak.Value;
            Notify = checkboxNotify.Checked;
        }

        private void PomodoroSettings_DragOver(object sender, DragEventArgs e)
        {

        }
    }
}
