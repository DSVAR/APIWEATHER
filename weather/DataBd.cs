using System;
using System.Windows.Forms;
using weather.sop;

namespace weather
{
    public partial class DataBd : Form
    {
        private temperatures temp = new temperatures();
        public DataBd()
        {
            InitializeComponent();
        }

    
        private void DataBd_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = temp.GetDS();
        }
    }
}