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
    public partial class CarRentUpdate : Form
    {
        public CarRentUpdate()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
                (@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CarRent;Integrated Security=True");

        private void MenuBtn_Click(object sender, EventArgs e)
        {

            Menu formMenu = new Menu();
            this.Hide();
            formMenu.Show();


        }

        private void UpdateCarBtn_MouseClick(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)
            (?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?
            (?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)
            (?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");

            bool isValidStartDate = regex.IsMatch(startDateTextBox.Text.Trim());
            bool isValidEndDate = regex.IsMatch(endDateTextBox.Text.Trim());

            DateTime dateAndTime;

            isValidStartDate = DateTime.TryParseExact(startDateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out dateAndTime);

            isValidEndDate = DateTime.TryParseExact(endDateTextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out dateAndTime);



            con.Open();

            if (!isValidStartDate || startDateTextBox.Text == "" || !isValidEndDate || endDateTextBox.Text == "")
            {
                MessageBox.Show("The date is not valid.");
            }

            if (cityTextBox.Text == "")
            {
                MessageBox.Show("Please introduce a city.");
            }
            DateTime startData = DateTime.Parse(startDateTextBox.Text);
            DateTime endData = DateTime.Parse(endDateTextBox.Text);

            if (startData > endData)
            {
                MessageBox.Show("The end data has to be bigger than the start data.");
            }

            else
            {
                SqlCommand firstCommand = con.CreateCommand();
                firstCommand.CommandText = "Select * from CarRentRegister where CarRentID = '" + carRentIDTextBox.Text + "'";
                firstCommand.Parameters.AddWithValue("@CarRentID", carRentIDTextBox.Text);
                SqlDataAdapter firstDataAdapter = new SqlDataAdapter(firstCommand);
                DataTable firstDataTable = new DataTable();
                firstDataAdapter.Fill(firstDataTable);


                
                SqlCommand secondCommand = con.CreateCommand();
                secondCommand.CommandText = "Select * from Customers where CostumerID = '" + clientIdTextBox.Text + "'";
                secondCommand.Parameters.AddWithValue("@CostumerID", clientIdTextBox.Text);
                SqlDataAdapter secondDataAdapter = new SqlDataAdapter(secondCommand);
                DataTable secondDataTable = new DataTable();
                secondDataAdapter.Fill(secondDataTable);


                SqlCommand thirdCommand = con.CreateCommand();
                thirdCommand.CommandText = "Select * from Cars where Model = '" + carModelTextBox.Text + "'";
                thirdCommand.Parameters.AddWithValue("@Model", carModelTextBox.Text);
                SqlDataAdapter thirdDataAdapter = new SqlDataAdapter(thirdCommand);
                DataTable thirdDataTable = new DataTable();
                thirdDataAdapter.Fill(thirdDataTable);
               

                SqlCommand fourthCommand = con.CreateCommand();
                fourthCommand.CommandText = "Select * from Customers where Location = '" + cityTextBox.Text + "'";
                fourthCommand.Parameters.AddWithValue("@Location", cityTextBox.Text);
                SqlDataAdapter fourthDataAdapter = new SqlDataAdapter(fourthCommand);
                DataTable fourthDataTable = new DataTable();
                fourthDataAdapter.Fill(fourthDataTable);


                if (firstDataTable.Rows.Count > 0 && secondDataTable.Rows.Count > 0 && thirdDataTable.Rows.Count > 0
                    && fourthDataTable.Rows.Count>0 )
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " UPDATE CarRentRegister SET ClientID = '" + clientIdTextBox.Text + "' , CarModel = '" + carModelTextBox.Text + "' , StartDate = '" + startDateTextBox.Text + "' ," +
                        " EndDate = '" + endDateTextBox.Text + "' , City = '" + cityTextBox.Text + "' Where CarRentID = '" + carRentIDTextBox.Text + "'";

                    cmd.ExecuteNonQuery();

                    Close();


                    Menu form = new Menu();
                    form.Show();
                }

                else
                {
                    MessageBox.Show("The model of the car or the client ID or the location it does not exists in our database.");
                }

                con.Close();

            }
        }
    }
}
    

    
 
