using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartLearn
{
    public class Pomodoro
    {
        int pomodoro_time;//время помидорки
        int short_break;//время короткого перерыва
        int long_break; //время длинного перерыва
        int number_of_pomodoro; //номер помидорки

        int next_break_or_work;//время следующего отдыха или перерыва
        bool notify;//флаг уведомления
        
        bool breaking; //флаг отдыха
        int count_of_pomodoro; //количество помидоров
        string status; //статус помидорки

        int time_keep; //текущее время

        string notify_pomodoro; //уведомление

        public Timer pomodoro_timer;//таймер

        public Pomodoro(int pomodoro_time, int short_break, int long_break, bool notify)
        {
            this.pomodoro_time = pomodoro_time *60;
            this.short_break = short_break * 60;
            this.long_break = long_break * 60;
            this.notify = notify;
            this.breaking = true;
            this.pomodoro_timer = new Timer();
            this.pomodoro_timer.Interval = 1000;
            this.next_break_or_work = this.pomodoro_time;
            this.time_keep = 0;
            this.number_of_pomodoro = 0;
            this.count_of_pomodoro = 0;
            this.status = "Работай!";
            this.notify_pomodoro = "Работай!";
        }

        public void ResetPomodoro()//сброс помидорки
        {
            time_keep = 0;
            number_of_pomodoro = 0;
        } 

        public void StartPomodoro() //запустить помидорку
        {
            pomodoro_timer.Start();
        }
        public void StopPomodoro()//остановить помидорку
        {
            pomodoro_timer.Stop();
        }
        public string GetNotifyPomodoro()
        {
            return notify_pomodoro;
        }//получить текущее уведомление для программы, свернутой в трей 

        public string GetStatus()
        {
            return status;
        } //текущий статус помидорки

        public bool GetBreaking()
        {
            return breaking;
        } //получить состояние для отдыха

        public void UpdateTimeKeep()
        {
            time_keep += 1;
        } //обновить текущее время

        public string UpdateTimerLabel()
        {
            var minutes = time_keep / 60;
            var seconds = time_keep % 60;
            var timer_string = seconds < 10 ? $"{minutes}:0{seconds}" : $"{minutes}:{seconds}";
            return timer_string;
        } //обновить надпись о текущем времени

        public bool PomodoroCheck()
        {
            //Если текущее время не равно времени следующего перерыва или следующей помидорки, выходим из функции
            if (time_keep != next_break_or_work) return false;

            //иначе помидорку останавливаем и сбрасываем время
            pomodoro_timer.Stop();
            time_keep = 0;
            UpdateTimerLabel();
            //стартуем
            pomodoro_timer.Start();

            //если настало время для перерыва. иначе время для перерыва закончилось
            if (breaking)
            {
                //увеличиваем количество помидорок и проверяем, какой отдых пользователь заслужил
                number_of_pomodoro += 1;
                count_of_pomodoro += 1;
                if (number_of_pomodoro % 4 != 0)
                {
                    next_break_or_work = short_break;
                    notify_pomodoro = "Отдыхай! Короткий перерыв";
                }
                else
                {
                    next_break_or_work = long_break;
                    notify_pomodoro = "Отдыхай! Длинный перерыв";
                    number_of_pomodoro = 0;
                }
                status = "Отдыхай! Ты заслужил :–)";
                //флаг отдыха сбрасываем
                breaking = false;
            }
            //устанавливаем время для работы
            else
            {
                status = "Работай!";
                notify_pomodoro = "За работу!";
                next_break_or_work = pomodoro_time;
                breaking = true;
            }
            return notify;
        } // метод проверки помидорки
        public string GetMessage()
        {
            if (count_of_pomodoro == 0)
            {
                return "";
            }
            else if (count_of_pomodoro > 0 && count_of_pomodoro < 4)
            {
                return "Ты сегодня хорошо поработал! Возвращайся скорее к помидорке :–)";
            }
            else
            {
                return "Ого! Целых " + count_of_pomodoro.ToString() + " помидорок, да тебя не остановить!\nВозвращайся скорее к помидорке :–)";
            }
        } //метод получения сообщения перед выходом
    }
}
