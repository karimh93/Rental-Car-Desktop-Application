using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRent;Integrated Security=True");
        DataSet ds = new DataSet();
       

        

            
      
        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();

            Close();
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)
            (?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?
            (?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)
            (?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");

            bool isValidBirthDate = regex.IsMatch(birthDateTextBox.Text.Trim());


            DateTime dateAndTime;

            isValidBirthDate = DateTime.TryParseExact(birthDateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out dateAndTime);

            con.Open();

            if (!isValidBirthDate || birthDateTextBox.Text == "")
            {
                MessageBox.Show("Invalid birth date.");
            }

            else if (clientNameTextBox.Text == "")
            {
                MessageBox.Show("Introduce a client name.");
            }

            else if (locationTextBox.Text == "")
            {
                MessageBox.Show("Introduce a location.");
            }

            else if (zipCodeTextBox.Text.Length != 5)
            {
                MessageBox.Show("The ZIP Code must be composed of 5 characters.");
            }

            else if (clientIdTextBox.Text == "")
            {
                MessageBox.Show("Introduce an ID to know what customer you want to update.");
            }


            else
            {

                SqlCommand cmd2;
                cmd2 = new SqlCommand("Select * FROM Customers WHERE CostumerID = '" + clientIdTextBox.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;

                if (i > 0)
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = " UPDATE Customers SET Name = '" + clientNameTextBox.Text + "' " +
                        ", BirthDate = '" + birthDateTextBox.Text + "' , Location = '" + locationTextBox.Text +
                        "' Where CostumerID = '" + clientIdTextBox.Text + "'";

                    cmd.ExecuteNonQuery();

                    Close();

                    Menu form = new Menu();
                    form.Show();
                }

                else
                {
                    MessageBox.Show("The customer with this ID " + clientIdTextBox.Text + " does not exists.");
                    ds.Clear();
                }
            }
            con.Close();
        }
    }
    }


    