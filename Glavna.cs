using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kucni_b_4_9
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik novi = new sifarnik("osoba");
            novi.Show();       
        }

        private void novcaniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik novi = new sifarnik("novcanik");
            novi.Show();
        }

        private void troskoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik novi = new sifarnik("trosak");
            novi.Show();
        }

        private void oRGoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik novi = new sifarnik("org");
            novi.Show();
        }

        private void firmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik novi = new sifarnik("firma");
            novi.Show();
        }
    }
}
