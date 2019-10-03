using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int penambahan(int a, int b)
        {
            return a + b;
        }

        private int pengurangan(int a, int b)
        {
            return a - b;
        }

        private void cekHasil_Click(object sender, EventArgs e)
        {
            var a = int.Parse(NilaiA.Text);
            var b = int.Parse(NilaiB.Text);


            lstHasil.Items.Clear();

            if (model.Text == "Penjumlahan")
            {
                lstHasil.Items.Add(penambahan(a, b));
                iki.Text = Convert.ToString(penambahan(a, b));
            }

            else if (model.Text == "Pengurangan")
            {
                lstHasil.Items.Add(pengurangan(a, b));
            }


        }
    }
}
