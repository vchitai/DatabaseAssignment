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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string connectionString = "";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string classListQuery = "";
            SqlCommand sqlcom = new SqlCommand(classListQuery);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            cbDanhSachLop.DataSource = ds.Tables[0].DataSet;
            cbDanhSachLop.ValueMember = "";
            cbDanhSachLop.DisplayMember = "";

            sqlcon.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string classAddName = classAddNameTB.Text;

            string connectionString = "";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string addClassQuery = "";
            SqlCommand sqlcom = new SqlCommand(addClassQuery);
            sqlcom.ExecuteNonQuery();

            string classListQuery = "";
            SqlCommand sqlcom2 = new SqlCommand(classListQuery);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom2);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            cbDanhSachLop.DataSource = ds.Tables[0].DataSet;
            cbDanhSachLop.ValueMember = "";
            cbDanhSachLop.DisplayMember = "";
            sqlcon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string classDeleteName = cbDanhSachLop.SelectedValue.ToString();
            string connectionString = "";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string deleteClassQuery = "";
            SqlCommand sqlcom = new SqlCommand(deleteClassQuery);
            sqlcom.ExecuteNonQuery();

            string classListQuery = "";
            SqlCommand sqlcom2 = new SqlCommand(classListQuery);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom2);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            cbDanhSachLop.DataSource = ds.Tables[0].DataSet;
            cbDanhSachLop.ValueMember = "";
            cbDanhSachLop.DisplayMember = "";
            sqlcon.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string classEditName = cbDanhSachLop.SelectedValue.ToString();
            string classNewName = classEditNameTB.Text;
            string connectionString = "";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string editClassQuery = "";
            SqlCommand sqlcom = new SqlCommand(editClassQuery);
            sqlcom.ExecuteNonQuery();

            string classListQuery = "";
            SqlCommand sqlcom2 = new SqlCommand(classListQuery);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom2);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            cbDanhSachLop.DataSource = ds.Tables[0].DataSet;
            cbDanhSachLop.ValueMember = "";
            cbDanhSachLop.DisplayMember = "";
            sqlcon.Close();

        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            FormAddSV fas = new FormAddSV();
            fas.ShowDialog();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string classListQuery = "";
            SqlCommand sqlcom = new SqlCommand(classListQuery);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            dgvSinhVien.DataSource = ds.Tables[0].DataSet;

            sqlcon.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string findName = SVFindNameTB.Text;
            string connectionString = "";
            SqlConnection sqlcon = new SqlConnection(connectionString);

            string classListQuery = "";
            SqlCommand sqlcom = new SqlCommand(classListQuery);
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);

            DataSet ds = new DataSet();
            sqlda.Fill(ds);

            dgvSinhVien.DataSource = ds.Tables[0].DataSet;

            sqlcon.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
