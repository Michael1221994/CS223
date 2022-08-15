using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_InventoryProject
{
    public partial class main_container : Form
    {
        String username;
        public main_container(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;

            if(active != null)
            {
                active.Close();
            }

            Form1 mainform = new Form1(username);
            mainform.MdiParent = this;
            mainform.Show();

        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                active.Close();
            }
            Search search = new Search();
            search.MdiParent = this;
            search.Show();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;

            if (active != null)
            {
                active.Close();
            }

            Search src = new Search();
            src.MdiParent = this;
            src.Show();

        }

        private void displayProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                active.Close();
            }
            displayall da = new displayall();
            da.MdiParent = this;
            da.Show();
        }
    }
}
