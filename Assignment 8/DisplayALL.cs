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
    public partial class DisplayALL : Form
    {
        public DisplayALL()
        {
            InitializeComponent();
        }

        private void DisplayALL_Load(object sender, EventArgs e)
        {
            foreach(var item in InventoryModel.GetAllProduct())
            {
                Productcard pr = new Productcard();
                pr.Product = item.objectName;
                pr.Count = item.count.ToString();
                pr.Price = item.price.ToString();
                flowLayoutPanel1.Controls.Add(pr);
            }
        }
    }
}
