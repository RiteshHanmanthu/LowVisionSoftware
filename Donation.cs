using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowVisionSoftware
{
    public partial class Donation : Form
    {
        public Donation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '___Ritesh_Blind_LowVisionDBDataSet.NewDonor' table. You can move, or remove it, as needed.
            this.newDonorTableAdapter.Fill(this.___Ritesh_Blind_LowVisionDBDataSet.NewDonor);

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DonorGridView.DataSource;
            bs.Filter = "Email like'%" + txtEmail + "%'";
            DonorGridView.DataSource = bs;
        }

        private void DonorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
