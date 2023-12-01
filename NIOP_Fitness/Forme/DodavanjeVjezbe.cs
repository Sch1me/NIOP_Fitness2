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
    public partial class DodavanjeVjezbe : Form
    {
        public DodavanjeVjezbe()
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
            //dodaj vjezbu button
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //unesi ime vjezbe TextBox
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //unesi btoj ponavljanja textBox
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //unesi btoj serija TextBox
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //unesi vrstu vjezbe textBox
        }
    }
}
