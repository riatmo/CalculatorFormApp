using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int penjumlahan(int a, int b)
        {
            return a + b;
        }

        private int pengurangan(int a, int b)
        {
            return a - b;
        }

        private int perkalian(int a, int b)
        {
            return a * b;
        }

        private int pembagian(int a, int b)
        {
            return a / b;
        }



        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            lstHasil.Items.Clear();

            lstHasil.Items.Add(string.Format("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b)));
        }
    }
}
