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
    public partial class Productcard : UserControl
    {
        public Productcard()
        {
            InitializeComponent();
        }

        private String _product;

        public String Product
        {
            get { return _product; }
            set { _product = value; label1.Text = value; }
        }

        private String _price;
        public String Price
        {
            get { return _price; }
            set { _price = value; label2.Text = value; }
        }
        private String _count;

        public String Count
        {
            get { return _count; }
            set { _count = value; label3.Text = value; }
        }

    }
}
