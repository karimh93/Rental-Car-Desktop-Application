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
    public partial class CarRentRegister : Form
    {
        public CarRentRegister()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CarRent;Integrated Security=True");
    }
}
