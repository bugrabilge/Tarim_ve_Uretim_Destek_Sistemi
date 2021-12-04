using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HackathonProje1
{
    
    public partial class Form1 : Form
    {

        public decimal Hasilat;
        
        public Form1()
        {
            InitializeComponent();
        }

        Adana a = new Adana();
        Adıyaman ad = new Adıyaman();
        Afyonkarahisar af = new Afyonkarahisar();
        Ağrı ag = new Ağrı();
        Amasya am = new Amasya();
        Ankara an = new Ankara();
        Antalya ant = new Antalya();
        Artvin ar = new Artvin();
        Aydın ay = new Aydın();
        Balıkesir b = new Balıkesir();
        Onerilenler o = new Onerilenler();


        public void Form1_Load(object sender, EventArgs e)
        {

        }
        Onerilenler deger;
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                
                case 0:
                    {
                        Doldur(a);
                        deger = a;
                        break;
                    }
                case 1:
                    {
                        Doldur(ad);
                        deger = ad;
                        break;
                    }
                case 2:
                    {
                        Doldur(af);
                        deger = af;
                        break;
                    }
                case 3:
                    {
                        Doldur(ag);
                        deger = ag;
                        break;
                    }
                case 4:
                    {
                        Doldur(am);
                        deger = am;
                        break;
                    }
                case 5:
                    {
                        Doldur(an);
                        deger = an;
                        break;
                    }
                case 6:
                    {
                        Doldur(ant);
                        deger = ant;  
                        break;
                    }
                case 7:
                    {
                        Doldur(ar);
                        deger = ar;
                        break;
                    }
                case 8:
                    {
                        Doldur(ay);
                        deger = ay;
                        break;
                    }
                case 9:
                    {
                        Doldur(b);
                        deger = b;
                        break;
                    }

            }
            
        }

        public void Doldur(Onerilenler f)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add(f.Öneri1);
            comboBox2.Items.Add(f.Öneri2);
            comboBox2.Items.Add(f.Öneri3);

        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex) 
            {
                case 0:
                    {
                        Doldur1(deger);
                        break;
                    }
                case 1:
                    {
                        Doldur2(deger);
                        break;
                    }
                case 2:
                    {
                        Doldur3(deger);
                        break;
                    }

                
            }

        }

        public void Doldur1(Onerilenler x)
        {
            txtSu.Text = x.Öneri1Su.ToString();
            txtEkim.Text = x.Öneri1Ekim;
            txtHasat.Text = x.Öneri1Hasat.ToString();
            txtTürkiyeDegeri.Text = x.TürkiyeFiyatı1.ToString();
            txtAvrupa.Text = x.AvrupaOrtalamaFiyatı1.ToString();
            
        }
        public void Doldur2(Onerilenler x)
        {
            txtSu.Text = x.Öneri2Su.ToString();
            txtEkim.Text = x.Öneri2Ekim;
            txtHasat.Text = x.Öneri2Hasat.ToString();
            txtTürkiyeDegeri.Text = x.TürkiyeFiyatı2.ToString();
            txtAvrupa.Text = x.AvrupaOrtalamaFiyatı2.ToString();
        }
        public void Doldur3(Onerilenler x)
        {
            txtSu.Text = x.Öneri3Su.ToString();
            txtEkim.Text = x.Öneri3Ekim;
            txtHasat.Text = x.Öneri3Hasat.ToString();
            txtTürkiyeDegeri.Text = x.TürkiyeFiyatı3.ToString();
            txtAvrupa.Text = x.AvrupaOrtalamaFiyatı3.ToString();

        }


    }
}
