using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Media;


namespace SmartLearn
{
    public partial class PomodoroForm : MetroForm
    {
        Timer PomodoroTimer = new Timer();
        int count_of_pomodoro = 0;
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
            //Задаем интервал в 1 секунду
            PomodoroTimer.Interval = 1000;
            //каждую секунду вызываем TimeEventProcessor
            PomodoroTimer.Tick += TimeEventProcessor;

            //Устнановка темы формы
            bResetPomodoro.StyleManager = this.StyleManager;
            bStartPomodoro.StyleManager = this.StyleManager;
            bStopPomodoro.StyleManager = this.StyleManager;
            lTimeNow.StyleManager = this.StyleManager;
            lStatus.StyleManager = this.StyleManager;

            notifyPomodoro.Text = "Помидорка";
            
            //Создаем объект формы настроек помидорки и настраиваем стиль
            Settings = new PomodoroSettings();
            Settings.StyleManager = this.StyleManager;

            //Вызываем окно настроек модально
            Settings.ShowDialog();

            //время следующего перерыва получаем из объекта формы настроек
            next_break = Settings.PomodoroTimer * 60;

            lTimeNow.Text = @"0:00";
            lStatus.Text = "«Старт», чтобы начать";
        }
        
        //Функция ежесекундной проверки
        private void TimeEventProcessor (object obj, EventArgs args)
        {
            //Увеличиваем на 1 текущее время
            time_keep += 1;
            
            //Вызываем функции для обновления Label с текущим временем
            UpdateTimerLabel();
            
            //Вызываем функцию для сравнения текущего времени и времени перерыва
            PomodoroCheck();
        }

        //Функция обновления Label, хранящий текущее время
        private void UpdateTimerLabel()
        {
            var minutes = time_keep / 60;
            var seconds = time_keep % 60;

            var timer_string = seconds < 10 ? $"{minutes}:0{seconds}" : $"{minutes}:{seconds}";
            lTimeNow.Text = timer_string;
        }

        //Функция проверки готовности помидорки
        private void PomodoroCheck()
        {
            //Если текущее время не равно времени следующего перерыва или следующей помидорки, выходим из функции
            if (time_keep != next_break) return;

            //иначе помидорку останавливаем и сбрасываем время
            PomodoroTimer.Stop();
            time_keep = 0;
            UpdateTimerLabel();
            //стартуем
            PomodoroTimer.Start();

            //если настало время для перерыва. иначе время для перерыва закончилось
            if (breaking)
            {
                //увеличиваем количество помидорок и проверяем, какой отдых пользователь заслужил
                number_of_pomodoro += 1;
                count_of_pomodoro += 1;
                if (number_of_pomodoro < 4)
                {
                    next_break = Settings.ShortBreak * 60;
                    notifyPomodoro.Text = "Отдыхай! Короткий перерыв";
                }
                else
                {
                    next_break = Settings.LongBreak * 60;
                    notifyPomodoro.Text = "Отдыхай! Длинный перерыв";
                    number_of_pomodoro = 0;
                }
                lStatus.Text = "Отдыхай! Ты заслужил :–)";
                //флаг отдыха сбрасываем
                breaking = false;
            }
            //устанавливаем время для работы
            else
            {
                lStatus.Text = "Работай!";
                notifyPomodoro.Text = "За работу!";

                next_break = Settings.PomodoroTimer * 60;
                breaking = true;

            }

            //если пользователь оставил чекбокс включенным, то вызываем функцию уведомления
            if (Settings.Notify)
            {
                Notify();
            }
        }
        //Функция уведомления пользователя
        private void Notify()
        {
            var text = !breaking ? "Сделай перерыв. Выпей стакан воды или посмотри в окно." : "Перерыв окончен, возвращайся к работе";
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
            notifyPomodoro.Text = "За работу!";

            PomodoroTimer.Start();
            bResetPomodoro.Enabled = false;
            bStopPomodoro.Enabled = true;
            bStartPomodoro.Enabled = false;
        }
        //Функция обработки нажатия на кнопку «Стоп»
        private void bStopPomodoro_Click(object sender, EventArgs e)
        {
            bStartPomodoro.Text = "Продолжить";
            notifyPomodoro.Text = "Помидорка приостановлена";
            lStatus.Text = "";

            PomodoroTimer.Stop();
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
            time_keep = 0;
            UpdateTimerLabel();
            number_of_pomodoro = 0;

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
            if (count_of_pomodoro == 0)
            {

            }
            else if (count_of_pomodoro > 0 && count_of_pomodoro < 4)
            {
                MessageBox.Show("Ты сегодня хорошо поработал! Возвращайся скорее к помидорке :–)", "Молодец!");
            }
            else
            {
                MessageBox.Show("Ого! Целых " + count_of_pomodoro.ToString() + " помидорок, да тебя не остановить!\nВозвращайся скорее к помидорке :–)", "Молодец!");
            }
        }
    }
}
