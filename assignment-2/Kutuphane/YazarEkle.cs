using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kutuphane
{
    public partial class YazarEkle : Form
    {
        AnaEkran anaEkran;
        public YazarEkle(AnaEkran GelenForm)
        {
            InitializeComponent(); 
            this.anaEkran = GelenForm;
        }

        ErrorProvider Error = new ErrorProvider();    
        private void button1_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("testing");

            /* foreach(string yazar in anaEkran.YazarlarDizisi)
             {

                 if (yazar==textBox1.Text)
                 { 
                     anaEkran.Show();
                     this.Close();
                 }
                 else
                 {

                     anaEkran.YazarlarDizisi.Add(textBox1.Text);

                     anaEkran.Show();
                     this.Close();
                 }  
             } */

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Error.SetError(textBox1,"LP boş bırakma");
            }
            else
            {
                if (anaEkran.YazarlarDizisi.IndexOf(textBox1.Text) >= 0)
                {
                    anaEkran.Show();
                    this.Close();
                }
                else
                {
                    anaEkran.YazarlarDizisi.Add(textBox1.Text);
                    anaEkran.Show();
                    this.Close();
                }
            }
          

        }
    }
}
