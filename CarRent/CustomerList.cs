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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRent;Integrated Security=True");
        DataSet ds = new DataSet();
        
        private void CustomerList_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Customers", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void getBackMenuBtn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Close();
            form.Show();
        }
    }
}
