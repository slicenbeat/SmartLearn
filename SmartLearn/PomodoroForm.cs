using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Media;


namespace SmartLearn
{
    public partial class PomodoroForm : MetroForm
    {
        Pomodoro pomodoro;
        PomodoroSettings pomodoroSettings;
        public PomodoroForm(PomodoroSettings pomodoroSettings)
        {
            InitializeComponent();
            this.pomodoroSettings = pomodoroSettings;
            this.pomodoro = pomodoroSettings.pomodoro;
        }

        private void PomodoroForm_Load(object sender, EventArgs e)
        {
            pomodoro.pomodoro_timer.Tick += TimeEventProcessor;
            //Установка темы формы
            bResetPomodoro.StyleManager = this.StyleManager;
            bStartPomodoro.StyleManager = this.StyleManager;
            bStopPomodoro.StyleManager = this.StyleManager;
            lTimeNow.StyleManager = this.StyleManager;
            lStatus.StyleManager = this.StyleManager;

            notifyPomodoro.Text = "Помидорка";
            lTimeNow.Text = @"0:00";
            lStatus.Text = "«Старт», чтобы начать";
        }
        
        //Функция ежесекундной проверки
        private void TimeEventProcessor (object obj, EventArgs args)
        {
            pomodoro.UpdateTimeKeep();
            lTimeNow.Text = pomodoro.UpdateTimerLabel();
            if (pomodoro.PomodoroCheck())
            {
                Notify();
            }
            notifyPomodoro.Text = pomodoro.GetNotifyPomodoro();
            lStatus.Text = pomodoro.GetStatus();

        }

        //Функция уведомления пользователя
        private void Notify()
        {
            WindowState = FormWindowState.Normal;
            var text = !pomodoro.GetBreaking() ? "Сделай перерыв. Выпей стакан воды или посмотри в окно." : "Перерыв окончен, возвращайся к работе";
            var title = "Соообщение от Помидорки";
            SoundPlayer simpleSound = new SoundPlayer("notify_sound.wav");
            simpleSound.Play();
            MessageBox.Show(text, title);
        }
        //Функция обработки нажатия на кнопку «Старт»
        private void bStartPomodoro_Click(object sender, EventArgs e)
        {
            bStartPomodoro.Text = "Старт";
            lStatus.Text = "Работай!";
            notifyPomodoro.Text = "Работай!";

            pomodoro.StartPomodoro();

            bResetPomodoro.Enabled = false;
            bStopPomodoro.Enabled = true;
            bStartPomodoro.Enabled = false;
        }
        //Функция обработки нажатия на кнопку «Стоп»
        private void bStopPomodoro_Click(object sender, EventArgs e)
        {
            bStartPomodoro.Text = "Продолжить";
            notifyPomodoro.Text = "Помидорка приостановлена";
            lStatus.Text = "Помидорка приостановлена";
            pomodoro.StopPomodoro();
            bResetPomodoro.Enabled = true;
            bStopPomodoro.Enabled = false;
            bStartPomodoro.Enabled = true;

        }
        //Функция обработки нажатия на кнопку «Сброс»
        private void bResetPomodoro_Click(object sender, EventArgs e)
        {
            lStatus.Text = "«Старт», чтобы начать";
            bStartPomodoro.Text = "Старт";
            notifyPomodoro.Text = "Помидорка";

            pomodoro.ResetPomodoro();
            pomodoro.UpdateTimerLabel();

        }
        //Функция обработки двойного нажатия на иконку Помидорки в трее
        private void notifyPomodoro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyPomodoro.Visible = false;
        }
        
        //Функция обработки события изменения размера окна Помидорки
        private void PomodoroForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) return;
            Hide();
            notifyPomodoro.Visible = true;
        }

        private void PomodoroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pomodoro.GetMessage() == "")
            {

            }
            else MessageBox.Show(pomodoro.GetMessage(), "Сообщение от Помидорки");
        }
    }
}
