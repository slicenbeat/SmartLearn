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
using MetroFramework.Components;

namespace SmartLearn
{
    public partial class SmartLearn : MetroForm
    {
        public SmartLearn()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void add_deck_Click(object sender, EventArgs e)
        {
            EditDeck editdeck = new EditDeck();
            editdeck.Show();

        }

        private void add_card_Click(object sender, EventArgs e)
        {

        }

        private void SmartLearn_Load(object sender, EventArgs e)
        {

        }

        private void view_deck_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run runner = new Run();
            runner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void mbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mbTheme.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
            }
        }
    }
}
