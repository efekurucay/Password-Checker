using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifrekontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ctrl_Click(object sender, EventArgs e)
        {
         if (txt_sifre.Text == String.Empty) {
                btndeneme.Text = "0";
                MessageBox.Show("Şifre Kısmı Boş Olamaz !"); }
          
            
          int a = txt_sifre.Text.Length;
            int buyukharf = 0;
            int kucukharf = 0;
            int ozelkarakter = 0;
            int rakam = 0;
            int sayac = 0;

            for (int i = 0; i < a; i++) { btndeneme.Text = a.ToString();
                char car = Convert.ToChar(txt_sifre.Text.Substring(i, 1));
                if (char.IsLower(car)) { kucukharf++; }
                if (char.IsUpper(car)) { buyukharf++; }
                if (char.IsNumber(car)) {rakam++; }
                if (char.IsPunctuation(car)) { ozelkarakter++; }
                if (char.IsSymbol(car)) { ozelkarakter++; }
                  }
            lbl_buyukharf.Text = buyukharf.ToString();
            lbl_kucukharf.Text = kucukharf.ToString();
            lbl_ozelkarakter.Text = ozelkarakter.ToString();
            lbl_rakam.Text = rakam.ToString();
          





        }
    }
}
