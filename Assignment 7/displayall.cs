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
    public partial class displayall : Form
    {
        public displayall()
        {
            InitializeComponent();
            dataGrid_displayall.DataSource = null;
            dataGrid_displayall.DataSource = InventoryModel.GetAllProduct();
        }

        private void dataGrid_displayall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
