using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOP_Fitness.Forme
{
    public partial class DodavanjeOsoba : Form
    {
        public DodavanjeOsoba()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //nazad button
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dodaj osobu button
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //unesi ime textBox
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //unesi prezime textBox
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //unesi OIB textBox
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //unesi godine textBNox
        }
    }
}
