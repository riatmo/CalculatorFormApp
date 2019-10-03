using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizCalkulator
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
