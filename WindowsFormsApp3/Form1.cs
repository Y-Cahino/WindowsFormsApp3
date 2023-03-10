using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public struct Prodotto
        {
            public string prezzo;
            public string nome;
        }
        public static Prodotto[] p;
        public static int d;
        public Form1()
        {
            InitializeComponent();
            p=new Prodotto[100];
            d=0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p[d].nome = textBox1.Text;
            p[d].prezzo = textBox2.Text;
            d++;
            vis(p);
            
        }
        
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Modifica_Click(object sender, EventArgs e)
        {
            int pos;
            pos = search(p, textBox1.Text);
            cancella(p, textBox1.Text, ref d);
           
            vis(p);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search(p, textBox1.Text);
            cancella(p, textBox1.Text, ref d);
            vis(p);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int i=0;i<d;i++)
            {
                vis(p);
            }
        }
        private void Somma_Click(object sender, EventArgs e)
        {
            float x;
            x=som(p);
            listView1.Items.Add(Convert.ToString(x));
        }
        private void Percentuale_Click(object sender, EventArgs e)
        {
            float x;
            x = float.Parse(per(p));
            listView1.Items.Add(Convert.ToString(x));
        }
        private void maxs_Click(object sender, EventArgs e)
        {
            float mas;
            mas = float.Parse(max(p));
            listView1.Items.Add(Convert.ToString(mas));
        }

        private void mini_Click(object sender, EventArgs e)
        {
            float minn;
            minn = float.Parse(min(p));
            listView1.Items.Add(Convert.ToString(minn));
        }

        //funzioni di servizio
        //funzione aggiunta
        public string proString(Prodotto p)
        {
            return "Nome: " + p.nome + "Prezzo: " + p.prezzo.ToString();
        }
        //funzione visualizza
        public void vis(Prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < d; i++)
            {
                listView1.Items.Add(proString(p[i]));
            }

        }
        //ricerca reale
        int search(Prodotto[] p, string nome)
        {
            int pos;
            for(int i=0; i<d; i++)
            {
                if(p[i].nome == nome)
                {
                    pos = i;
                    return pos;
                }
                
            }
            pos = -1;
            return pos;

        }
        //funzione cancellazione
        public static void cancella(Prodotto[]p, string nome, ref int d)
        {
            for(int i = 0; i < d; i++)
            {
                if (p[i].nome == nome)
                {
                    for(int j = i; j < p.Length - 1; j++)
                    {
                        p[i] = p[i + 1];
                    }
                    d--;
                }
            }
        }
        //funzione somma
        public static float som(Prodotto[]p)
        {
            float x = 0;
            for (int i = 0; i < d; i++)
            {
               x+=float.Parse(p[i].prezzo);
            }
            return x;
        }
       //funzione percentuale di sconto or sovrapprezzo
       public static string per(Prodotto[]p)
        {
            float x=som(p);
            for (int i = 0; i < d; i++)
            {
                if (x < 0)
                {
                    x = (x / 100) * float.Parse(p[i].prezzo);
                }
                else
                {
                    x -= (x / 100) * float.Parse(p[i].prezzo);
                }
            }
            return ("Prezzo scontato: "+x);
        }
        //funzione massimo&minimo
        public static string max(Prodotto[]p)
        {
            float mas = 0;
            for (int i = 0; i < d; i++)
            {
                mas=p[i].prezzo.Max();
            }
            return ("Prezzo maggiore: "+mas);
        }
        public static string min(Prodotto[]p)
        {
            float minn = 0;
            for (int i = 0; i < d; i++)
            {
                minn=p[i].prezzo.Min();
            }
            return ("Prezzo minore: " + minn);
        }

        
    }
}
