﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyonu
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriKayit kayitekrani = new frmMusteriKayit();
            kayitekrani.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOdalarımız odakayit = new frmOdalarımız();
            odakayit.Show();
        }
    }
}
