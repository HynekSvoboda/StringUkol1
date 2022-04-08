using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringUkol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiouyáéěíóúůý" ;
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            string veta = textBox1.Text;
            int pocetpismen = veta.Length, pocetsamohlasek = 0, pocetsouhlasek = 0, pocetjiny = 0;
            veta = veta.ToLower();
            foreach (char ch in veta)
            {
                if (samohlasky.Contains(ch))
                {
                    pocetsamohlasek++;
                }
                else
                {
                    if(souhlasky.Contains(ch))
                    {
                        pocetsouhlasek++;
                    }
                    else
                    {
                        pocetjiny++;
                    }
                }

            }
            label4.Text = Convert.ToString(pocetsamohlasek);
            label5.Text = Convert.ToString(pocetsouhlasek);
            label6.Text = Convert.ToString(pocetjiny);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte projekt, který pro zadanou větu spočítá počet samohlásek, souhlásek a počet nepísmenných znaků(např.mezera nebo!).\n\n(Definujte si samohlásky a souhlásky \nstring samohlasky = \"aeiouyáéěíóúůý\"\nstring souhlasky = \"bcčdďfghjklmnpqrřsštťvwxzž\"\n\nPoužijte cyklus foreach a metodu Contains, ToLower a vlastnost Lenght)", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
