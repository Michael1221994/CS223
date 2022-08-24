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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var text = InventoryModel.findALL(textBox_search.Text);
            if(text.Count == 0)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Search product not found","Error");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = InventoryModel.findALL(textBox_search.Text);
            }
        }
    }
}
