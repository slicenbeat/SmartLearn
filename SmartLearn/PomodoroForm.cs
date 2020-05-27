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
    public partial class PomodoroForm : MetroForm
    {
        Timer PomodoroTimer = new Timer();

        int time_keep;
        int number_of_pomodoro;
        int next_break;
        bool breaking = true;
        PomodoroSettings Settings;

        public PomodoroForm()
        {
            InitializeComponent();
        }

        private void PomodoroForm_Load(object sender, EventArgs e)
        {
            PomodoroTimer.Interval = 1000;
            PomodoroTimer.Tick += TimeEventProcessor;

            bResetPomodoro.StyleManager = this.StyleManager;
            bStartPomodoro.StyleManager = this.StyleManager;
            bStopPomodoro.StyleManager = this.StyleManager;
            lTimeNow.StyleManager = this.StyleManager;
            lStatus.StyleManager = this.StyleManager;

            notifyPomodoro.Text = "SmartLearn: Pomodoro-Timer";
            
            Settings = new PomodoroSettings();
            Settings.StyleManager = this.StyleManager;

            Settings.ShowDialog();

            next_break = Settings.PomodoroTimer * 60;
            lTimeNow.Text = @"0:00";
        }

        private void TimeEventProcessor (object obj, EventArgs args)
        {
            time_keep += 1;
            UpdateTimerLabel();
            PomodoroCheck();
        }

        private void UpdateTimerLabel()
        {
            var minutes = time_keep / 60;
            var seconds = time_keep % 60;

            var timer_string = seconds < 10 ? $"{minutes}:0{seconds}" : $"{minutes}:{seconds}";
            lTimeNow.Text = timer_string;
        }

        private void PomodoroCheck()
        {
            if (time_keep != next_break) return;

            PomodoroTimer.Stop();
            time_keep = 0;
            UpdateTimerLabel();
            PomodoroTimer.Start();

            if (breaking)
            {
                number_of_pomodoro += 1;
                //переключение перерывов
                if (number_of_pomodoro < 4)
                {
                    next_break = Settings.ShortBreak * 60;
                }
                else
                {
                    next_break = Settings.LongBreak * 60;
                    number_of_pomodoro = 0;
                }
                breaking = false;
                lStatus.Text = "Отдыхай! Ты заслужил :–)";
            }
            else
            {
                next_break = Settings.PomodoroTimer * 60;
                breaking = true;
                lStatus.Text = "Работай!";
            }

            if (Settings.Notify)
            {
                Notify();
            }
        }

        private void Notify()
        {
            var text = !breaking ? "Сделай перерыв. Выпей стакан воды или посмотри в окно." : "Перерыв окончен, возвращайся к работе";
            var title = "Напоминание";
            MessageBox.Show(text, title);
        }

        private void bStartPomodoro_Click(object sender, EventArgs e)
        {
            PomodoroTimer.Start();
            lStatus.Text = "Работай!";
            bResetPomodoro.Enabled = false;
            bStopPomodoro.Enabled = true;
            bStartPomodoro.Enabled = false;
            WindowState = FormWindowState.Minimized;
        }

        private void bStopPomodoro_Click(object sender, EventArgs e)
        {
            lStatus.Text = "";
            PomodoroTimer.Stop();
            bResetPomodoro.Enabled = true;
            bStopPomodoro.Enabled = false;
            bStartPomodoro.Enabled = true;
        }

        private void bResetPomodoro_Click(object sender, EventArgs e)
        {
            lStatus.Text = "";
            time_keep = 0;
            UpdateTimerLabel();
            number_of_pomodoro = 0;
        }

        private void notifyPomodoro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyPomodoro.Visible = false;
        }

        private void PomodoroForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) return;
            Hide();
            notifyPomodoro.Visible = true;
        }
    }
}
