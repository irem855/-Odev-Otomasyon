using System;
using System.Collections;
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
    public partial class frmOdalarımız : Form
    {
        public frmOdalarımız()
        {
            InitializeComponent();
        }
        ArrayList odalarımız = new ArrayList();
        private void frmOdalarımız_Load(object sender, EventArgs e)
        {
            string odaAdi = "";
            string yeniDeger = "";

            for (int i = 1; i < this.Controls.Count + 1; i++)
            {
                odaAdi = Convert.ToString(this.Controls.Find("oda" + i.ToString(), true).FirstOrDefault() as Button);
                yeniDeger = odaAdi.Split(':').Last();
                odalarımız.Add(yeniDeger);

            }

            odalarinDurumu();
            
        }
        void odalarinDurumu()
        {
            string yeniOda = "";
            csOdalarımız oda = new csOdalarımız();
            try
            {
                foreach (string odaninAdi in odalarımız)
                {
                    oda.odaDegerleri(odaninAdi, "Dolu");
                    if (oda.durum_oku == "Dolu")
                    {
                        yeniOda = odaninAdi;
                        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Red;
                        this.Controls.Find(oda.butonAdi, true)[0].Text = yeniOda + " \n" + oda.alanKisi;
                        oda.durum_oku = "";
                    }
                    if (oda.durum_oku == "Boş")
                    {
                        this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Green;
                    }
                }
            }
            catch { }
        }

        private void frmOdalarımız_KeyDown(object sender, KeyEventArgs e)
        {
            anaEkran main = new anaEkran();
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                main.StartPosition = FormStartPosition.CenterScreen;
            }
        }
    }
}
