namespace CarRent
{
    partial class CarRentRegister
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
            this.carModelLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.RegisterCarBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.carModelLabel.Location = new System.Drawing.Point(24, 18);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(79, 16);
            this.carModelLabel.TabIndex = 0;
            this.carModelLabel.Text = "Car Model";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.clientIdLabel.Location = new System.Drawing.Point(24, 65);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(70, 16);
            this.clientIdLabel.TabIndex = 1;
            this.clientIdLabel.Text = "Client ID ";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.startDateLabel.Location = new System.Drawing.Point(24, 112);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(81, 16);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start Date ";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.endDateLabel.Location = new System.Drawing.Point(24, 155);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(76, 16);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date ";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.cityLabel.Location = new System.Drawing.Point(24, 199);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(38, 16);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City ";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(121, 18);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(115, 20);
            this.carModelTextBox.TabIndex = 5;
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(121, 65);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(115, 20);
            this.clientIdTextBox.TabIndex = 6;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(121, 111);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(115, 20);
            this.startDateTextBox.TabIndex = 7;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(121, 154);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(115, 20);
            this.endDateTextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(121, 199);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(115, 20);
            this.cityTextBox.TabIndex = 9;
            // 
            // RegisterCarBtn
            // 
            this.RegisterCarBtn.Location = new System.Drawing.Point(202, 246);
            this.RegisterCarBtn.Name = "RegisterCarBtn";
            this.RegisterCarBtn.Size = new System.Drawing.Size(96, 23);
            this.RegisterCarBtn.TabIndex = 10;
            this.RegisterCarBtn.Text = "Submit";
            this.RegisterCarBtn.UseVisualStyleBackColor = true;
            this.RegisterCarBtn.Click += new System.EventHandler(this.RegisterCarBtn_MouseClick);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(12, 246);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(100, 23);
            this.MenuBtn.TabIndex = 11;
            this.MenuBtn.Text = "Back";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // CarRentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 290);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.RegisterCarBtn);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.clientIdTextBox);
            this.Controls.Add(this.carModelTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.carModelLabel);
            this.Name = "CarRentRegister";
            this.Text = "Register New Car ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button RegisterCarBtn;
        private System.Windows.Forms.Button MenuBtn;
    }
}