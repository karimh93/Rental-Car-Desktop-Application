using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MenuScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                CarRentRegister formRegister = new CarRentRegister();
                formRegister.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D2)
            {
                CarRentUpdate formUpdate = new CarRentUpdate();
                formUpdate.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D3)
            {
                RentList formList = new RentList();
                formList.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D4)
            {
                AvailableCarList formAvailableCars = new AvailableCarList();
                formAvailableCars.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D5)
            {
                RegisterCustomer formCustomerRegister = new RegisterCustomer();
                formCustomerRegister.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D6)
            {
                CustomerUpdate formUpdateCustomer = new CustomerUpdate();
                formUpdateCustomer.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D7)
            {
                CustomerList formCustomerList = new CustomerList();
                formCustomerList.Show();

                Dispose();
            }

            else if (e.KeyCode == Keys.D8)
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("This is not a valid option.");
            }
        }
    }
}
