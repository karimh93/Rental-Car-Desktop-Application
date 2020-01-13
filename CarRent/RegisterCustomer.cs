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
    public partial class RegisterCustomer : Form
    {
        
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRent;Integrated Security=True");

        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            this.Close();
            formMenu.Show();
        }

        private void RegisterCustomerBtn_Click(object sender, EventArgs e)
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
                Console.WriteLine("The Birth Date is not valid");
            }

            if (clientNameTextBox.Text == "")
            {
                Console.WriteLine("Please introduce a name");
            }
            
            if (locationTextBox.Text == "")
            {
                Console.WriteLine("Please introduce a location");
            }

            if (zipCodeTextBox.Text.Length != 5)
            {
                Console.WriteLine("Please introduce a Zip Code with 5 characters");
            }

            else
            {

                
                SqlCommand firstCommand = new SqlCommand("Select * FROM Customers WHERE Name = '" + clientNameTextBox.Text + "'", con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(firstCommand);
                dataAdapter.Fill(ds);
                
                int i = ds.Tables[0].Rows.Count;

                

                if (i > 0)
                {
                    MessageBox.Show("The customer already exists.");
                    ds.Clear();
                }
                else
                {

                    SqlCommand secondCommand = con.CreateCommand();
                    secondCommand.CommandType = CommandType.Text;
                    secondCommand.CommandText = "insert into Customers values('" + clientNameTextBox.Text + "' , '" +
                                             birthDateTextBox.Text + "' , '" + locationTextBox.Text + "')";

                    secondCommand.ExecuteNonQuery();

                    Close();

                    Menu form = new Menu();
                    form.Show();
                }
            }

            con.Close();

        }

    }


    }


