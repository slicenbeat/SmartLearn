using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLearn
{
    public partial class SmartLearn : Form
    {
        public SmartLearn()
        {
            InitializeComponent();
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
    }
}
