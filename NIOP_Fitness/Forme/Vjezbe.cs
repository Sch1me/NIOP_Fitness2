using NIOP_Fitness.Objektni_Model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOP_Fitness.Forme
{
    public partial class Vjezbe : Form
    {
        public Vjezbe()
        {
            InitializeComponent();
            PodatkovniKontekst podatkovniKontekstVjezbe = new PodatkovniKontekst();
           /* if (podatkovniKontekstVjezbe.linijaVjezbe[0] !=null ) {
                listBox1.Items.Add(podatkovniKontekstVjezbe.linijaVjezbe[0]);
            }*/
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dodaj vjezbu button
            new DodavanjeVjezbe().ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //obrisi button
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //izmjeni button
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //nazad button
            Close();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista, popis vjezbi
        }
    }
}
