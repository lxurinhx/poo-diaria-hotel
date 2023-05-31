using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3D27Ex09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int numdias = 0;
            double taxa = 0, totaldiarias = 0;
            string nome;

            nome = txtnome.Text;
            numdias = int.Parse(txtdiarias.Text);

            if (numdias > 15)
            {
                taxa = 10;
            }
            else if (numdias == 15)
            {
                taxa = 12;
            }
            else if (numdias < 15)
            {
                taxa = 15;
            }

            totaldiarias = (180 + taxa) * numdias;

            lblnome.Text = nome;
            lblresult.Text = totaldiarias.ToString(); 

        }
    }
}
