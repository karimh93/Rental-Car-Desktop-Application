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
    public partial class AvailableCarList : Form
    {
        public AvailableCarList()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
         (@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRent;Integrated Security=True");

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Close();
            form.Show();
        }

        private void AvailableCarList_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Cars", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
