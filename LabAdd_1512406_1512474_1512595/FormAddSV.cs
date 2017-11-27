using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LabAdd_1512406_1512474_1512595
{
    public partial class FormAddSV : Form
    {
        public FormAddSV()
        {
            InitializeComponent();
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            string mssv = tbMSSV.Text;
            string name = tbHoTN.Text;
            string hocLop = tbHocLop.Text;
            string ngSinh = tbNgSinh.Text;
            string email = tbEmail.Text;
            string dtb = tbDTB.Text;

            string connectionString = "";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string editClassQuery = "";
            SqlCommand sqlcom = new SqlCommand(editClassQuery);
            sqlcom.ExecuteNonQuery();

            sqlcon.Close();
        }

        private void FormAddSV_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
