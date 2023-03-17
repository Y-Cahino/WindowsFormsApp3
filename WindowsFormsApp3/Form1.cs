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
            public float prezzo;
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
            p[d].prezzo = float.Parse(textBox2.Text);
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
            cancella(p, textBox1.Text, textBox2.Text);
            aggiunta(p,newn.Text,ref d);
            aggiunta(p,newpr.Text,ref d);
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
        private void newn_TextChanged(object sender, EventArgs e)
        {

        }

        private void newpr_TextChanged(object sender, EventArgs e)
        {

        }

        //funzioni di servizio
        //funzione aggiunta
        public string proString(Prodotto p)
        {
            return "Nome: " + p.nome + " Prezzo: " + p.prezzo.ToString();
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
        public void cancella(Prodotto[]p, string nome, ref int d)
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
        public float som(Prodotto[]p)
        {
            float x = 0;
            for (int i = 0; i < d; i++)
            {
               x+=p[i].prezzo;
            }
            return x;
        }
       //funzione percentuale di sconto or sovrapprezzo
       public string per(Prodotto[]p)
        {
            float x=som(p);
            for (int i = 0; i < d; i++)
            {
                if (x < 0)
                {
                    x = (x / 100) * p[i].prezzo;
                }
                else
                {
                    x -= (x / 100) * p[i].prezzo;
                }
            }
            return ("Prezzo scontato: "+x);
        }
        //funzione massimo&minimo
        public string max(Prodotto[]p)
        {
            float mas = p[0].prezzo;
            for (int i = 0; i < d; i++)
            {
                if (p[i].prezzo > mas)
                {
                    mas= p[i].prezzo;
                }
            }
            return ("Prezzo maggiore: "+mas);
        }
        public string min(Prodotto[]p)
        {
            float minn = p[0].prezzo;
            for (int i = 0; i < d; i++)
            {
                if (p[i].prezzo > minn)
                {
                    minn = p[i].prezzo;
                }
            }
            return ("Prezzo minore: " + minn);
        }

        //funzione aggiunta
        public void aggiunta(Prodotto[] p, string nome, ref int d)
        {
            d++;
            for (int i = 0; i < d; i++)
            {
                if (p[i].nome != nome)
                {
                    p[d].nome = newn.Text;
                    p[d].prezzo = float.Parse(newpr.Text);
                    
                }
            }
            
        }
    }
}
