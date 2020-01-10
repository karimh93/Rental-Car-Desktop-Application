namespace CarRent
{
    partial class RegisterCustomer
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
            this.MenuBtn = new System.Windows.Forms.Button();
            this.RegisterCustomerBtn = new System.Windows.Forms.Button();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(26, 265);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(100, 23);
            this.MenuBtn.TabIndex = 23;
            this.MenuBtn.Text = "Back";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // RegisterCustomerBtn
            // 
            this.RegisterCustomerBtn.Location = new System.Drawing.Point(216, 265);
            this.RegisterCustomerBtn.Name = "RegisterCustomerBtn";
            this.RegisterCustomerBtn.Size = new System.Drawing.Size(96, 23);
            this.RegisterCustomerBtn.TabIndex = 22;
            this.RegisterCustomerBtn.Text = "Submit";
            this.RegisterCustomerBtn.UseVisualStyleBackColor = true;
            this.RegisterCustomerBtn.Click += new System.EventHandler(this.RegisterCustomerBtn_Click);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(135, 191);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(115, 20);
            this.zipCodeTextBox.TabIndex = 21;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(135, 116);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(115, 20);
            this.birthDateTextBox.TabIndex = 20;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(135, 74);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.clientNameTextBox.TabIndex = 19;
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(135, 32);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(115, 20);
            this.clientIdTextBox.TabIndex = 18;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.cityLabel.Location = new System.Drawing.Point(38, 191);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 16);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "ZIP Code";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.endDateLabel.Location = new System.Drawing.Point(38, 116);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(76, 16);
            this.endDateLabel.TabIndex = 15;
            this.endDateLabel.Text = "Birth Date";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.startDateLabel.Location = new System.Drawing.Point(38, 74);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(92, 16);
            this.startDateLabel.TabIndex = 14;
            this.startDateLabel.Text = "Client Name";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.clientIdLabel.Location = new System.Drawing.Point(38, 32);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(70, 16);
            this.clientIdLabel.TabIndex = 13;
            this.clientIdLabel.Text = "Client ID ";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(135, 152);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(115, 20);
            this.locationTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Location";
            // 
            // RegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 324);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.RegisterCustomerBtn);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.clientIdLabel);
            this.Name = "RegisterCustomer";
            this.Text = "RegisterCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button RegisterCustomerBtn;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label1;
    }
}