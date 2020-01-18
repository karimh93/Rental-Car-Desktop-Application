using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class RentList : Form
    {
        public RentList()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRent;Integrated Security=True");
        DataSet ds = new DataSet();

     

        private void getBackMenuBtn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Close();
            form.Show();
        }

        private void RentList_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from CarRentRegister", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
