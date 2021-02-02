using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satiş_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt32(txtmisir.Text);
            su = Convert.ToInt32(txtsu.Text);
            cay = Convert.ToInt32(txtcay.Text);
            bilet = Convert.ToInt32(txtbilet.Text);
            toplam = ((misir*4)+(su*2)+(cay*3)+(bilet*20));
            lbtoplam.Text = toplam.ToString() +" TL";

            kasatutar =kasatutar + toplam;
            lbkasa.Text = kasatutar.ToString()+" TL";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtmisir.Text = "";
            txtcay.Text = "";
            txtsu.Text = "";
            txtbilet.Text = "";
            txtmisir.Focus();
        }   
    }
}
