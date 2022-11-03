using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stachtestdatetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        DateTime treba;
        private void button1_Click(object sender, EventArgs e)
        {

            
                
                treba = dateTimePicker1.Value;
                treba = treba.Date;


                int mesic = treba.Month;
                int den = treba.Day;
                string pomocna;
                string pomocnaden;
                if (mesic < 10)
                {
                    pomocna = mesic.ToString().Replace(mesic.ToString(), "0" + mesic.ToString());
                }
                else { pomocna = mesic.ToString(); }

                if (den < 10)
                {
                    pomocnaden = den.ToString().Replace(den.ToString(), "0" + den.ToString());
                }
                else
                { pomocnaden = den.ToString(); }
                Random rng = new Random();
                int poslednirandom = rng.Next(100, 999);
                maskedTextBox1.Text = treba.Year.ToString().Substring(2) + pomocna + pomocnaden + poslednirandom.ToString();
                int rodnecislo = int.Parse(maskedTextBox1.Text.Replace(".", ""));
                

                bool ukonceni = false;
                long help = 0;
            int naposled = 0;
                Random last = new Random();
                do
                {
                    naposled = last.Next(0, 10);
                string konec = rodnecislo.ToString() + naposled;

                    help = long.Parse(konec);
                    if (help % 11 == 0)
                    {
                        ukonceni = true;

                    }


                } while (ukonceni == false);



            maskedTextBox2.Text = maskedTextBox1.Text + naposled.ToString();
            }

        
    }
}
