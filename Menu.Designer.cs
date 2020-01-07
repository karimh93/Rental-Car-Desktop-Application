using System;

namespace CarRent
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carRentRegisterLabel = new System.Windows.Forms.Label();
            this.carRentUpdateLabel = new System.Windows.Forms.Label();
            this.rentListLabel = new System.Windows.Forms.Label();
            this.availableCarListLabel = new System.Windows.Forms.Label();
            this.registerCustomerLabel = new System.Windows.Forms.Label();
            this.customerUpdateLabel = new System.Windows.Forms.Label();
            this.customerListLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carRentRegisterLabel
            // 
            this.carRentRegisterLabel.AutoSize = true;
            this.carRentRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.carRentRegisterLabel.Location = new System.Drawing.Point(12, 21);
            this.carRentRegisterLabel.Name = "carRentRegisterLabel";
            this.carRentRegisterLabel.Size = new System.Drawing.Size(192, 16);
            this.carRentRegisterLabel.TabIndex = 0;
            this.carRentRegisterLabel.Text = "1  Register New Car Rent";
            // 
            // carRentUpdateLabel
            // 
            this.carRentUpdateLabel.AutoSize = true;
            this.carRentUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.carRentUpdateLabel.Location = new System.Drawing.Point(12, 48);
            this.carRentUpdateLabel.Name = "carRentUpdateLabel";
            this.carRentUpdateLabel.Size = new System.Drawing.Size(148, 16);
            this.carRentUpdateLabel.TabIndex = 1;
            this.carRentUpdateLabel.Text = "2  Update Car Rent";
            // 
            // rentListLabel
            // 
            this.rentListLabel.AutoSize = true;
            this.rentListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.rentListLabel.Location = new System.Drawing.Point(12, 74);
            this.rentListLabel.Name = "rentListLabel";
            this.rentListLabel.Size = new System.Drawing.Size(98, 16);
            this.rentListLabel.TabIndex = 2;
            this.rentListLabel.Text = "3  List Rents";
            // 
            // availableCarListLabel
            // 
            this.availableCarListLabel.AutoSize = true;
            this.availableCarListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.availableCarListLabel.Location = new System.Drawing.Point(12, 100);
            this.availableCarListLabel.Name = "availableCarListLabel";
            this.availableCarListLabel.Size = new System.Drawing.Size(163, 16);
            this.availableCarListLabel.TabIndex = 3;
            this.availableCarListLabel.Text = "4  List Available Cars";
            // 
            // registerCustomerLabel
            // 
            this.registerCustomerLabel.AutoSize = true;
            this.registerCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.registerCustomerLabel.Location = new System.Drawing.Point(12, 126);
            this.registerCustomerLabel.Name = "registerCustomerLabel";
            this.registerCustomerLabel.Size = new System.Drawing.Size(191, 16);
            this.registerCustomerLabel.TabIndex = 4;
            this.registerCustomerLabel.Text = "5  Register new Customer";
            // 
            // customerUpdateLabel
            // 
            this.customerUpdateLabel.AutoSize = true;
            this.customerUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.customerUpdateLabel.Location = new System.Drawing.Point(12, 153);
            this.customerUpdateLabel.Name = "customerUpdateLabel";
            this.customerUpdateLabel.Size = new System.Drawing.Size(151, 16);
            this.customerUpdateLabel.TabIndex = 5;
            this.customerUpdateLabel.Text = "6  Update Customer";
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.customerListLabel.Location = new System.Drawing.Point(12, 178);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(132, 16);
            this.customerListLabel.TabIndex = 6;
            this.customerListLabel.Text = "7  List Customers";
            // 
            // quitLabel
            // 
            this.quitLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.quitLabel.AutoSize = true;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.quitLabel.Location = new System.Drawing.Point(12, 202);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(55, 16);
            this.quitLabel.TabIndex = 7;
            this.quitLabel.Text = "8  Quit";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 379);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.customerUpdateLabel);
            this.Controls.Add(this.registerCustomerLabel);
            this.Controls.Add(this.availableCarListLabel);
            this.Controls.Add(this.rentListLabel);
            this.Controls.Add(this.carRentUpdateLabel);
            this.Controls.Add(this.carRentRegisterLabel);
            this.Name = "Menu";
            this.Text = "Menu Screen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuScreenForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carRentRegisterLabel;
        private System.Windows.Forms.Label carRentUpdateLabel;
        private System.Windows.Forms.Label rentListLabel;
        private System.Windows.Forms.Label availableCarListLabel;
        private System.Windows.Forms.Label registerCustomerLabel;
        private System.Windows.Forms.Label customerUpdateLabel;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.Label quitLabel;
    }
}