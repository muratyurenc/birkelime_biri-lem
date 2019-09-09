using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace birkelime_bir_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rst = new Random();
        int hrf = 0;
        int ıslm = 0;
        private void HARFGETİR_Click(object sender, EventArgs e)
        {
            hrf++;
            string harf1, harf2, harf3, harf4, harf5, harf6, harf7;
            int harf;
            string[] dizi1 = { "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ş", "İ", "Z", "C", "V", "B", "N", "M", "Ö", "Ç", "E", "R", "T", "Y", "U", "I", "P", "Ğ", "Ü" };
            if(hrf==1)
            {
                harf = rst.Next(0, dizi1.Length);
                harf1 = (dizi1[harf]);
                button1.Text = harf1.ToString();
                button1.Visible = true;
            }
            if (hrf == 2)
            {
                harf = rst.Next(0, dizi1.Length);
                harf2 = (dizi1[harf]);
                button2.Text = harf2.ToString();
                button2.Visible = true;
            }
            if (hrf == 3)
            {
                harf = rst.Next(0, dizi1.Length);
                harf3 = (dizi1[harf]);
                button3.Text = harf3.ToString();
                button3.Visible = true;
            }
            if (hrf == 4)
            {
                harf = rst.Next(0, dizi1.Length);
                harf4 = (dizi1[harf]);
                button4.Text = harf4.ToString();
                button4.Visible = true;
            }
            if (hrf == 5)
            {
                harf = rst.Next(0, dizi1.Length);
                harf5 = (dizi1[harf]);
                button5.Text = harf5.ToString();
                button5.Visible = true;
            }
            if (hrf == 6)
            {
                harf = rst.Next(0, dizi1.Length);
                harf6 = (dizi1[harf]);
                button6.Text = harf6.ToString();
                button6.Visible = true;
            }
            if (hrf == 7)
            {
                harf = rst.Next(0, dizi1.Length);
                harf7 = (dizi1[harf]);
                button7.Text = harf7.ToString();
                button7.Visible = true;
            }

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            ıslm++;
            string say1, say2, say3, say4, say5, say6, say7;
            int deger;
            string [] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi3 = { "15", "25", "35" };
            if (ıslm==1)
            {
                deger = rst.Next(0, dizi2.Length);
                say1 = (dizi2[deger]);
                button8.Text = say1.ToString();
                button8.Visible = true;
            }
            if (ıslm == 2)
            {
                deger = rst.Next(0, dizi2.Length);
                say2 = (dizi2[deger]);
                button9.Text = say2.ToString();
                button9.Visible = true;
            }
            if (ıslm ==3)
            {
                deger = rst.Next(0, dizi2.Length);
                say3 = (dizi2[deger]);
                button10.Text = say3.ToString();
                button10.Visible = true;
            }
            if (ıslm == 4)
            {
                deger = rst.Next(0, dizi2.Length);
                say4 = (dizi2[deger]);
                button11.Text = say4.ToString();
                button11.Visible = true;
            }
            if (ıslm ==5)
            {
                deger = rst.Next(0, dizi3.Length);
                say5 = (dizi3[deger]);
                button12.Text = say5.ToString();
                button12.Visible = true;
            }
            if (ıslm == 6)
            {
                deger = rst.Next(0, dizi3.Length);
                say6 = (dizi3[deger]);
                button13.Text = say6.ToString();
                button13.Visible = true;
            }
            if (ıslm == 7)
            {
                deger = rst.Next(100,1000);
                say7 = deger.ToString();
                button14.Text = say7.ToString();
                button12.Visible = true;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
        }
    }
}
