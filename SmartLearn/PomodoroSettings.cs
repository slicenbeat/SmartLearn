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
            PomodoroTimer = trackPomodoroLength.Value;
            ShortBreak = trackShortBreak.Value;
            LongBreak = trackLongBreak.Value;
            Notify = checkboxNotify.Checked;
            Close();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }
    }
}
