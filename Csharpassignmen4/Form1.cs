namespace Csharpassignmen4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Class1 object1 = new Class1
            {
                Number = int.Parse(name_tb.Text),
                Date = dateTimePicker1.Value,
                inventorynumber = int.Parse(Inventory_tb.Text),
                objectname = objectname_tb.Text,
                count = int.Parse(count_tb.Text),
                price = double.Parse(price_tb.Text)
            };
            MessageBox.Show($"Product \" {objectname_tb.Text} \"Added Successfuly","Success");
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}