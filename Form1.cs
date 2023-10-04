using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void citaj_Click(object sender, EventArgs e)
        {
            ispis.LoadFile(@"C:Tempproba.rtf");

        }

        private void spremi_Click(object sender, EventArgs e)
        {
            ispis.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            ispis.Clear();
        }
    }
}
