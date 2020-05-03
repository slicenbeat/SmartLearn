﻿using System;
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
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Data.SQLite;

namespace SmartLearn
{
    public partial class MyCardLists : MetroForm
    {
        public MyCardLists()
        {
            InitializeComponent();
        }

        private void MyCardLists_Load(object sender, EventArgs e)
        {
            AddCardList.StyleManager = this.StyleManager;
        }


        private void AddCardList_Click(object sender, EventArgs e)
        {
            CreateCardList createcardlist = new CreateCardList();
            createcardlist.StyleManager = this.StyleManager;
            createcardlist.Show();
        }
    }
}