using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace SmartLearn
{
    public partial class SmartLearn : MetroForm
    {
        public SmartLearn()
        {
            InitializeComponent();
            this.StyleManager = MainStyle;
        }
        
        private void metroLink1_Click(object sender, EventArgs e)
        {
            AboutApp ifrm = new AboutApp();
            ifrm.StyleManager = this.StyleManager;
            ifrm.ShowDialog();
        }
        private void SmartLearn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTheme.Checked)
            {
                MainStyle.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else MainStyle.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void LearningButton_Click(object sender, EventArgs e)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path_to_txt = Path.Combine(appDataPath, "SmartLearn", "NameOfLastDeck.txt");

            StreamReader read = new StreamReader(path_to_txt);
            string name;
            name = read.ReadLine();
            read.Close();
            if (name == null)
                MessageBox.Show("Вы ещё не открывали ни одну колоду");
            else
            {
                ReviewForm learning = new ReviewForm(name);
                learning.StyleManager = this.StyleManager;
                learning.ShowDialog();
            }
        }

        private void MyDecks_Click(object sender, EventArgs e)
        {
            MyCardLists mycardlists = new MyCardLists();
            mycardlists.StyleManager = this.StyleManager;
            mycardlists.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsrtuction_Click(object sender, EventArgs e)
        {
            Instruction ifrm = new Instruction();
            ifrm.StyleManager = this.StyleManager;
            ifrm.ShowDialog();
        }

        private void bPomodoro_Click(object sender, EventArgs e)
        {
            PomodoroForm pomodoroForm = new PomodoroForm();
            pomodoroForm.StyleManager = this.StyleManager;
            pomodoroForm.Show();

        }
    }
}
