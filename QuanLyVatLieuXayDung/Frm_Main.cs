﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            Frm_DM_ChatLieu ChatLieu = new Frm_DM_ChatLieu();
            ChatLieu.ShowDialog();
        }
    }
}
