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

        private float Penambahan(float a, float b)
        {
            return a + b;
        }

        private float Pengurangan(float a, float b)
        {
            return a - b;
        }

        private float Perkalian(float a, float b)
        {
            return a * b;
        }

        private float Pembagian(float a, float b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = float.Parse(txtNilaiA.Text);
            var b = Convert.ToSingle(txtNilaiB.Text);

            lstHasil.Items.Clear();

            if (combobox.SelectedIndex == 0)
            {
                lstHasil.Items.Add(string.Format("{0}", Penambahan(a, b)));
            }

            if (combobox.SelectedIndex == 1)
            {
                lstHasil.Items.Add(string.Format("{0}", Pengurangan(a, b)));
            }
            
            if (combobox.SelectedIndex == 2)
            {
                lstHasil.Items.Add(string.Format("{0}", Perkalian(a, b)));
            }
           
            if (combobox.SelectedIndex == 3)
            {
                lstHasil.Items.Add(string.Format("{0}", Pembagian(a, b)));
            }
        }
    }
}