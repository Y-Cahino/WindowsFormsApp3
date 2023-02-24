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
        public Prodotto[] p;
        public int d;
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
            visualizza(p);
            
        }
        public string proString(Prodotto p)
        {
            return "Nome:" + p.nome + "Prezzo:" + p.prezzo.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //funzioni di servizio
        public void visualizza(Prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < d; i++)
            {
                listView1.Items.Add(proString(p[i]));
            }

        }
        public static bool cancella(Prodotto[] pp, string nome, ref int d)
        {
            bool esiste = false;
            for(int i = 0; i < d; i++)
            {
                if (pp[i].nome == nome)
                {
                    d--;
                    for(int j = i; j < pp.Length - 1; j++)
                    {
                        pp[i] = pp[i + 1];
                    }
                    esiste = true;
                    break;
                }
            }
            return esiste; 
        }
    }
}
