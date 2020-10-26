using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_madenciligi_odev
{ public partial class Form1 : Form
    {
        private int min = 1;
        private int max = 20;
        private List<double> dizi = new List<double>();
        private List<double> d1 = new List<double>();
        private List<double> d2 = new List<double>();
        private List<double> d3 = new List<double>();
        private List<double> yeniDizi = new List<double>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            dizi.Clear();
            lblDizi.Text = "";
            Random rnd = new Random();
            for (int i = 0; i < sayi.Value; i++)
            {
                dizi.Add(rnd.Next(min, max));
            }

            foreach (var item in dizi)
            {
                lblDizi.Text += item.ToString() + " ";
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            lblSiraliDizi.Text = " ";
            dizi.Sort();
            foreach (var item in dizi)
            {
                lblSiraliDizi.Text += item.ToString() + " ";
            }
        }

        private void btnOrtDuzg_Click(object sender, EventArgs e)
        {
            lblOrtDuzgn.Text = "";
            double ortd1 = 0;
            double ortd2 = 0;
            double ortd3 = 0;
            d1.Clear();
            d2.Clear();
            d3.Clear();
            yeniDizi.Clear();

            List<double> yd1 = new List<double>();
            List<double> yd2 = new List<double>();
            List<double> yd3 = new List<double>();

            int bolum = (int)sayi.Value;
            bolum = bolum / 3;
            for (int i = 0; i < bolum; i++)
            {
                d1.Add(dizi[i]);
            }

            for (int i = bolum; i < dizi.Count - bolum; i++)
            {
                d2.Add(dizi[i]);
            }

            for (int i = dizi.Count - bolum; i < dizi.Count; i++)
            {
                d3.Add(dizi[i]);
            }

            yd1 = d1;
            yd2 = d2;
            yd3 = d3;

            yd1.ForEach(x => ortd1 += x);
            ortd1 = ortd1 / bolum;
            ortd1 = Math.Round(ortd1, 2);
            yd1.Clear();
            for (int i = 0; i < bolum; i++)
            {
                yd1.Add(ortd1);
            }

            yd2.ForEach(x => ortd2 += x);
            ortd2 = ortd2 / bolum;
            ortd2 = Math.Round(ortd2, 2);
            yd2.Clear();
            for (int i = 0; i < bolum; i++)
            {
                yd2.Add(ortd2);
            }

            yd3.ForEach(x => ortd3 += x);
            ortd3 = ortd3 / bolum;
            ortd3 = Math.Round(ortd3, 2);
            yd3.Clear();
            for (int i = 0; i < bolum; i++)
            {
                yd3.Add(ortd3);
            }

            yeniDizi = yd1.Concat(yd2).Concat(yd3).ToList();
            yeniDizi.ForEach(x => lblOrtDuzgn.Text += x.ToString() + " ");
        }
    }
}
