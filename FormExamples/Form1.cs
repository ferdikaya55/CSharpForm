using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int kelimeSayisi = 0;
            
            string paragraf = "ferdi kaya merhaba hosgeldin ferdi";
            string[] kelimeler = paragraf.Split(' ');
            string[] benzersizKelimeler = new string[kelimeler.Length];
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (benzersizKelimeler[i]!= kelimeler[i])
                {
                    benzersizKelimeler[i] = kelimeler[i];
                }
            }
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (kelimeler[i]!=kelimeler[i+1])
                {
                    listSonuc.Items.Add(kelimeler[i]);
                }
            }
            for (int i = 0; i < listSonuc.Items.Count; i++)
            {
                if (listSonuc.Items[i]==listSonuc.Items[i+1])
                {
                    kelimeSayisi++;
                }
                
            }

        }

        public void Kontrol()
        {

           
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
          
        }
    }
}
